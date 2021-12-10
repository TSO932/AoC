namespace AoC2021

module Day10Part2 =

    let autoCompleteScore(input:string) =

        let score(c:char, i:int64) =
            match c with
                | '(' -> 5L * i + 1L
                | '[' -> 5L * i + 2L
                | '{' -> 5L * i + 3L
                | _   -> 5L * i + 4L // '<' expected

        input |> Day10Part1.removeAllPairedBrackets |> Seq.rev |> Seq.fold (fun a c -> score (c, a)) 0L


    let getMedianScore(input:seq<string>) =
        let scores = input |> Seq.filter (fun s -> Day10Part1.scoreFirstIllegalCharacter s = 0 ) |> Seq.map autoCompleteScore |> Array.ofSeq |> Array.sort

        let middle = (Array.length scores) / 2
        scores[middle]
