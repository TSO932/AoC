namespace _2023

open System

module Day14Part2 = 

    let rec tilt = Day14Part1.tilt

    let rotate(input:char[,]) =      
        
        let platform =
            input
            |> Day11Part1.rotateGridBy90DegreesToTheRight
            |> Day11Part1.rotateGridBy90DegreesToTheRight
            |> Day11Part1.rotateGridBy90DegreesToTheRight

        let height = Array2D.length1 platform

        seq {0 .. height - 1}
        |> Seq.map (fun i -> tilt platform[i, *])
        |> array2D

    let calculateSum(input:char[,]) =      

        let height = Array2D.length1 input

        seq {0 .. height - 1}
        |> Seq.map (fun i -> tilt input[i, *])
        |> array2D
        |> Array2D.mapi (fun v h c -> if c = 'O' then height - h else 0)
        |> Seq.cast<int>
        |> Seq.sum

    let getSum(input:seq<string>) =         
        
            input
            |> array2D
            |> rotate
            |> calculateSum
