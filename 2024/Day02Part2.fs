namespace _2024

open System

module Day02Part2 =

    let isValid(input:string) =

        let isValid1(seq1:seq<int>) =
        
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


        let arr1 =
            input.Split ' '
            |> Array.map Int32.Parse

        let lastIndex = Array.length arr1 - 1

        let trunArr(i) =
            match i with
            | 0 -> arr1[1 ..]
            | 4 -> arr1[.. lastIndex - 1]   // works with 4 but not lastIndex ????
            | _ -> Array.concat [ arr1[.. i - 1]; arr1[i + 1..] ]

        seq {0 .. lastIndex}
        |> Seq.map trunArr
        |> Seq.map isValid1
        |> Seq.exists ((=) true)


    let run (input: seq<string>) =
        
        input
        |> Seq.filter isValid
        |> Seq.length