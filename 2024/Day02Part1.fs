namespace _2024

open System

module Day02Part1 =

    let isValid(input:string) =
        let seq1 =
            input.Split ' '
            |> Seq.map Int32.Parse

        let seqA =
            seq1
            |> Seq.rev
            |> Seq.tail
            |> Seq.rev

        let seqB = Seq.tail seq1

        let diffs =
            (seqA, seqB)
            ||> Seq.zip
            |> Seq.map (fun (a, b) -> b - a)
        
        let maxDiff = Seq.max diffs
        let minDiff = Seq.min diffs

        ( (maxDiff > 0 && minDiff > 0)  || (maxDiff < 0 && minDiff < 0) ) && maxDiff <= 3 && minDiff >= -3


    let run (input: seq<string>) =
        
        input
        |> Seq.filter isValid
        |> Seq.length