namespace _2023

open System

module Day13Part2 =

    let findHoriz(input:seq<string>) =      
        
        let pattern = Seq.toArray input
        let height = Seq.length input

        let isMirror (i:int, pattern:string[]) =
            let lengthOfReflection = min (i + 1) (height - i - 1)
            let top = pattern[i + 1 - lengthOfReflection .. i]
            let bottom = pattern[i + 1 .. i + lengthOfReflection]

            top = Array.rev bottom

        seq {0 .. height - 2}
        |> Seq.map (fun i -> if isMirror(i, pattern) then i + 1 else 0)
        |> Seq.filter ((<) 0)

    let findVert(input:seq<string>) =
        
        let pattern = array2D input
        let height, width = Array2D.length1 pattern, Array2D.length2 pattern

        let rotated =
            Array2D.init width height (fun row column -> Array2D.get pattern (height - column - 1) row)
            |> Seq.cast<char>
            |> Seq.chunkBySize height
            |> Seq.map String

        findHoriz rotated

    let findHoriz100s(input:seq<string>) =

        input
        |> findHoriz
        |> Seq.map (fun h -> h * 100)

    let removeMatch(orginal, alteratives) =
        
        alteratives
        |> Seq.filter ((<>) orginal)
        |> Seq.sort
        |> Seq.rev
        |> Seq.head

    let getVarients(input:seq<string>) =

        let toArray (arr: 'T [,]) = arr |> Seq.cast<'T> |> Seq.toArray

        let orginalGrid =
            let arrays = input |> Seq.map (Array.ofSeq) |> Array.ofSeq
            let maxHeight = arrays.Length
            let maxWidth = arrays[0].Length
            Array2D.init maxHeight maxWidth (fun i j -> arrays[i][j])

        let getVarient(i, j, c) =

            let varient = Array2D.copy orginalGrid
            Array2D.set varient i j (if c = '#' then '.' else '#')  
   
            toArray(varient)
            |> Array.chunkBySize (Array2D.length2 varient)
            |> Array.map String

        let varients =

            orginalGrid
            |> Array2D.mapi (fun i j c -> getVarient(i, j, c))

        toArray(varients)
        |> Array.toSeq

    let getSum(input:seq<string>) =
        
        let patterns =
            input
            |> Day13Part1.split
        
        let orginalVerts =
            patterns
            |> Seq.map findVert

        let orginalHoriz =
            patterns
            |> Seq.map findHoriz100s

        let orginals =
            Seq.zip orginalVerts orginalHoriz
            |> Seq.map (fun orig -> Seq.append (fst orig) (snd orig))
            |> Seq.map Seq.max
        
        let varients =
            patterns
            |> Seq.map getVarients

        let alternativeVerts =
            varients
            |> Seq.map (fun a -> a |> Seq.map findVert)

        let alternativeHoriz =
            varients
            |> Seq.map (fun a -> a |> Seq.map findHoriz100s)

        let alternatives =
            Seq.zip alternativeVerts alternativeHoriz
            |> Seq.map (fun orig -> Seq.append (fst orig) (snd orig))
            |> Seq.map Seq.concat
        
        Seq.zip orginals alternatives
        |> Seq.sumBy (fun a -> removeMatch((fst a, snd a)))
