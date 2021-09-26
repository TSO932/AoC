namespace AoC2015

open System.Text.RegularExpressions

module Day05Part1 =

    let isValidRule1 (input:string) =
         Regex.IsMatch (input, "(.*[aeiou].*){3,}")

    let isValidRule2 (input:string) =
         Regex.IsMatch (input, @"(.)\1")

    let isValidRule3 (input:string) =
         not (Regex.IsMatch (input, "ab|cd|pq|xy"))
    
    let isValid (input:string) =
        isValidRule1(input) && isValidRule2(input) && isValidRule3(input)

    let countNiceStrings (input:seq<string>) =

        input |> Array.ofSeq |> Seq.filter isValid |> Seq.length