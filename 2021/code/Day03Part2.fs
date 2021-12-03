namespace AoC2021

open System

module Day03Part2 =
    let run (input:seq<string>) =

        let rec getMostOrLeastCommonDigits(input:seq<list<int>>, digit:int, fstOrSnd) =
            if Seq.length input <= 1 then
                input
            else
                let mostPopular = input |> Seq.map (fun n -> n[digit .. n.Length - 1]) |> Day03Part1.getMostCommonAndLeastCommonFirstDigit |> fstOrSnd
                getMostOrLeastCommonDigits(Seq.filter (fun s -> s[digit] = mostPopular) input, digit + 1, fstOrSnd)

        let getDecimal(bits:seq<list<int>>) = bits |> Seq.exactlyOne |> Day03Part1.getDecimal

        let diagnostic = Day03Part1.diagnostic(input)
        getDecimal(getMostOrLeastCommonDigits(diagnostic, 0, fst)) * getDecimal(getMostOrLeastCommonDigits(diagnostic, 0, snd))