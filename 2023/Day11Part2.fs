namespace _2023


module Day11Part2 =
       
    let findEmptyRows(input:char[,]) =

        let blankLine =
            String.replicate (input.GetLength 1) "."
            |> Seq.toArray

        seq {0..  (input.GetLength 0) - 1}
        |> Seq.map (fun i -> (i, input[i, *]))
        |> Seq.map (fun (i, col) -> if col = blankLine then seq {i} else Seq.empty)
        |> Seq.concat

    let findEmptyColumns(input:char[,]) =
        input
        |> Day11Part1.rotateGridBy90DegreesToTheRight
        |> findEmptyRows

    let getSumX(multipler:int64, input:seq<string>) =
        let gMap =
            input
            |> Seq.map (fun s -> s.ToCharArray())
            |> Seq.toArray
            |> array2D
        
        let emptyRows = findEmptyRows gMap
        let emptyColumns = findEmptyColumns gMap
        let galaxies = Day11Part1.findGalaxies gMap

        let dist (n1, n2, empties) =
            if n1 = n2 then
                0L
            else
                let range =
                    if n1 < n2 then
                        seq {(n1 + 1) .. (n2 - 1)}
                    else
                        seq {(n2 + 1) .. (n1 - 1)}

                range
                |> Seq.map (fun g -> if Seq.contains g empties then multipler else 1L)
                |> Seq.sum
                |> fun n -> n + 1L         
            
        let xDist (x1, x2) = dist (x1, x2, emptyColumns)
        let yDist (y1, y2) = dist (y1, y2, emptyRows)

        galaxies
        |> Seq.map (fun g1 -> galaxies |> Seq.map (fun g2 -> xDist (fst g1, fst g2) + yDist (snd g1, snd g2)))
        |> Seq.concat
        |> Seq.sum
        |> fun i -> i / 2L

    let getSum(input:seq<string>) = getSumX (1000000L, input)