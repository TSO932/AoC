namespace AoC2021

module Day14Part1 =
    let parseRules(input:seq<string>) =

        input
        |> Seq.tail
        |> Seq.tail
        |> Seq.map (fun rule -> ( (rule[0], rule[1]), rule[6]))
        |> Map.ofSeq

    let insert(rules:Map<char*char,char>, input:string) =

        input.Substring(0, 1) +
        ( input
        |> Seq.windowed 2
        |> Seq.map ( fun c -> [ rules[c[0], c[1]]; c[1] ])
        |> Seq.concat
        |> Seq.toArray
        |> System.String )

    let rec doSteps(rules:Map<char*char,char>, input:string, stepCount:int) =
        if stepCount = 0 then
            input
        else
            doSteps(rules, insert(rules, input), stepCount - 1)
    
    let rec largestMinusSmallest(input:string) =

        let counts =
            input
            |> Seq.countBy id
            |> Seq.sortBy snd
            |> Seq.map snd

        let smallest = counts |> Seq.head
        let largest  = counts |> Seq.rev |> Seq.head

        largest - smallest

    let run(input:seq<string>) = largestMinusSmallest ( doSteps (  parseRules (input), Seq.head input , 10 ) )