namespace AoC2021

module Day03Part1 =
    let run (input:seq<string>) =

        let diagnostic = input |> Seq.map (fun d -> Seq.toList d) 

        let getMostCommonAndLeastCommonFirstDigit(input:seq<list<char>>) =
            let groupByStartingDigit = input |> Seq.groupBy Seq.head

            let getCountOfNs(n:char) = groupByStartingDigit |> Seq.filter (fun (c, _) -> c = n) |> Seq.exactlyOne |> snd |> Seq.length

            match getCountOfNs('1').CompareTo(getCountOfNs('0')) with
            | -1 -> (0, 1)
            | _  -> (1, 0)

        let rec getMostCommonAndLeastCommonDigits(input:seq<list<char>>, result:seq<int*int>) =
            if input |> Seq.head |> Seq.length = 0 then
                result
            else
                getMostCommonAndLeastCommonDigits(Seq.map List.tail input, Seq.append result [getMostCommonAndLeastCommonFirstDigit(input)])
        
        let getDecimal(bits:seq<int>) = bits |> Seq.fold (fun a b -> a * 2 + b) 0

        let mostCommonAndLeastCommonDigits = getMostCommonAndLeastCommonDigits(diagnostic, []) 
        
        getDecimal(Seq.map fst mostCommonAndLeastCommonDigits) * getDecimal(Seq.map snd mostCommonAndLeastCommonDigits)




