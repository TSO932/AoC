namespace AoC2021

module Day03Part1 =
    let run (input:seq<string>) =

        let diagnostic = input |> Seq.map (fun d -> Seq.toList d) 

        let mostCommonFirstDigit(input:seq<list<char>>, tiebreak:int) =
            let groupByStartingDigit = input |> Seq.groupBy Seq.head

            let getCountOfNs(n:char) = groupByStartingDigit |> Seq.filter (fun (c, _) -> c = n) |> Seq.exactlyOne |> snd |> Seq.length

            match getCountOfNs('1').CompareTo(getCountOfNs('0')) with
            |  1 -> 1
            | -1 -> 0
            |  _ -> tiebreak      

        let rec getmostCommonDigits(input:seq<list<char>>, tiebreak:int, result:seq<int>) =
            if input |> Seq.head |> Seq.length = 0 then
                result
            else
                getmostCommonDigits(Seq.map List.tail input, tiebreak, Seq.append result [mostCommonFirstDigit(input, tiebreak)])
        
        let getDecimal(bits:seq<int>) = bits |> Seq.fold (fun a b -> a * 2 + b) 0 
        getDecimal( getmostCommonDigits(diagnostic, 1, []) )




