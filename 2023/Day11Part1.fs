namespace _2023

module Day11Part1 =

    let rotateGridBy90DegreesToTheRight grid = //https://fssnip.net/7Wk
        let height, width = Array2D.length1 grid, Array2D.length2 grid
        Array2D.init width height (fun row column -> Array2D.get grid (height - column - 1) row)

    let expand(input:seq<string>) =      
        
        let addRowIfEmpty(input:char[,]) =

            let blankLine =
                String.replicate (input.GetLength 1) "."
                |> Seq.toArray

            seq {0..  (input.GetLength 0) - 1}
            |> Seq.map (fun i -> input[i, *])
            |> Seq.map (fun col -> if col = blankLine then [col; col] else [col] )
            |> Seq.concat
            |> Seq.toArray
            |> array2D

        input
        |> array2D
        |> addRowIfEmpty
        |> rotateGridBy90DegreesToTheRight
        |> addRowIfEmpty


    let findGalaxies(cosmos:char[,]) =

        let rec go x y gg =
            if   y >= Array2D.length1 cosmos then
                gg
            elif x >= Array2D.length2 cosmos then
                go 0 (y + 1) gg
            elif cosmos[y, x] = '#' then 
                go (x + 1) y (Seq.append [|(x, y)|] gg)
            else go (x + 1) y gg

        go 0 0 Seq.empty

    let getSum(input:seq<string>) =
        let gg =
            input
            |> expand
            |> findGalaxies
        
        gg
        |> Seq.map (fun g1 -> gg |> Seq.map (fun g2 -> abs ((fst g1) - (fst g2)) + abs ((snd g1) - (snd g2))))
        |> Seq.concat
        |> Seq.sum
        |> fun i -> i / 2
