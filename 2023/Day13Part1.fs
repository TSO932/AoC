namespace _2023

open System

module Day13Part1 =

    let findHoriz(input:seq<string>) =      
        
        let pattern = Seq.toArray input
        let height = Seq.length input
        let width = input |> Seq.head |> Seq.length

        let isMirror (i:int, pattern:string[]) =
            let lengthOfReflection = min (i + 1) (height - i - 1)
            let top = pattern[i + 1 - lengthOfReflection .. i]
            let bottom = pattern[i + 1 .. i + lengthOfReflection]

            top = Array.rev bottom

        seq {0 .. height - 2}
        |> Seq.sumBy (fun i -> if isMirror(i, pattern) then i + 1 else 0)

    let findVert(input:seq<string>) =
        
        let pattern = array2D input
        let height, width = Array2D.length1 pattern, Array2D.length2 pattern

        let rotated =
            Array2D.init width height (fun row column -> Array2D.get pattern (height - column - 1) row)
            |> Seq.cast<char>
            |> Seq.chunkBySize height
            |> Seq.map String

        findHoriz rotated

    let split input =
        let mutable i = 0
        input
        |> Seq.groupBy (fun x ->
            if x = String.Empty then
                i <- i + 1
            i)
        |> Seq.map snd
        |> Seq.map (fun p -> if Seq.head p = String.Empty then Seq.tail p else p)

    let getSum(input:seq<string>) =
        
        input
        |> split
        |> Seq.map (fun p -> findVert p + 100 *  findHoriz p)
        |> Seq.sum
