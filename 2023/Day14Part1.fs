namespace _2023

open System

module Day14Part1 =

    let rec tilt (input: char[]) =
        
        let shiftAlong (input:string) =
            input.Replace (".O",  "O.")

        let tilted =
            input
            |> String
            |> shiftAlong
            |> Seq.toArray

        if tilted = input then
            tilted
        else
            tilt tilted

    let getSum(input:seq<string>) =      
        
        let platform =
            input
            |> array2D
            |> Day11Part1.rotateGridBy90DegreesToTheRight
            |> Day11Part1.rotateGridBy90DegreesToTheRight
            |> Day11Part1.rotateGridBy90DegreesToTheRight

        let height = Array2D.length1 platform

        seq {0 .. height - 1}
        |> Seq.map (fun i -> tilt platform[i, *])
        |> array2D
        |> Array2D.mapi (fun v h c -> if c = 'O' then height - h else 0)
        |> Seq.cast<int>
        |> Seq.sum