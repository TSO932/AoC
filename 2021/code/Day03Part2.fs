namespace AoC2021

open System

module Day03Part2 =
    let run (input:seq<string>) =

        let diagnostic = input |> Seq.map (fun d -> Seq.toList d)

        let getMostCommonAndLeastCommonFirstDigit(input:seq<list<char>>) =
            let groupByStartingDigit = input |> Seq.groupBy Seq.head

            let getCountOfNs(n:char) = groupByStartingDigit |> Seq.filter (fun (c, _) -> c = n) |> Seq.exactlyOne |> snd |> Seq.length

            match getCountOfNs('1').CompareTo(getCountOfNs('0')) with
            | -1 -> ('0', '1')
            | _  -> ('1', '0')

        let rec getMostOrLeastCommonDigits(input:seq<list<char>>, digit:int, fstOrSnd) =
            if Seq.length input <= 1 then
                input
            else
                let mostPopular = input |> Seq.map (fun n -> n[digit .. n.Length - 1]) |> getMostCommonAndLeastCommonFirstDigit |> fstOrSnd
                getMostOrLeastCommonDigits(Seq.filter (fun s -> s[digit] = mostPopular) input, digit + 1, fstOrSnd)

        let getDecimal(bits:seq<list<char>>) = bits |> Seq.exactlyOne |> Seq.fold (fun a b -> a * 2 + if b = '1' then 1 else 0) 0

        getDecimal(getMostOrLeastCommonDigits(diagnostic, 0, fst)) * getDecimal(getMostOrLeastCommonDigits(diagnostic, 0, snd))


        // let getDecimal(bits:seq<int>) = bits |> Seq.fold (fun a b -> a * 2 + b) 0

        // let mostCommonAndLeastCommonDigits = getMostCommonAndLeastCommonDigits(diagnostic, []) 
        
        // getDecimal(Seq.map fst mostCommonAndLeastCommonDigits) * getDecimal(Seq.map snd mostCommonAndLeastCommonDigits)




