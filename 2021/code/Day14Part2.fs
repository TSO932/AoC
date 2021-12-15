namespace AoC2021

module Day14Part2 =

    let parseRules(input:seq<string>) =

        input
        |> Seq.tail
        |> Seq.tail
        |> Seq.map (fun rule -> (rule[0], rule[1]), seq { (rule[0], rule[6]); (rule[6], rule[1]) } )
        |> Map.ofSeq

    let getStarting(input:string) =
        input 
        |> Seq.pairwise
        |> Seq.map (fun p -> (p, 1L))


    let insert(rules:Map<char*char, seq<char*char>>, input:seq<(char*char)*int64>) =

        input
        |> Seq.map ( fun (p, i) -> rules[p] |> Seq.map ( fun a -> (a, i) ) )
        |> Seq.concat
        |> Seq.groupBy fst
        |> Seq.map ( fun (p, x) -> (p, x |> Seq.sumBy snd) )

    let rec doSteps(rules:Map<char*char, seq<char*char>>, input:seq<(char*char)*int64>, stepCount:int) =
        if stepCount = 0 then
            input
        else
            doSteps(rules, insert(rules, input), stepCount - 1)

    let rec largestMinusSmallest(final:seq<(char*char)*int64>, initial:string ) =

        let bookends(c:char) =
            if   c = initial[0] && c = initial[String.length initial - 1] then 2L
            elif c = initial[0] || c = initial[String.length initial - 1] then 1L
            else 0L

        let counts =
            final
            |> Seq.map ( fun ((a, b), i) -> [(a, i); (b, i)] )
            |> Seq.concat
            |> Seq.groupBy fst
            |> Seq.map ( fun (c, i) -> (bookends c)  + (i |> Seq.sumBy snd) )
            |> Seq.sort

        let smallest = ( counts |> Seq.head ) / 2L
        let largest  = ( counts |> Seq.rev |> Seq.head ) / 2L
    
        largest - smallest

    let run(input:seq<string>) =
        largestMinusSmallest ( doSteps ( parseRules (input), input |> Seq.head |> getStarting , 40 ), Seq.head input )