namespace _2023

module Day16Part2 =
    let countTiles(input:seq<string>) = 
        let mirrorGrid = array2D input

        let height = Array2D.length1 mirrorGrid
        let width  = Array2D.length2 mirrorGrid

        let downers =
            seq{0 .. width - 1}
            |> Seq.map (fun i -> (-1, i, 1, 0))
        
        let uppers =
            seq{0 .. width - 1}
            |> Seq.map (fun i -> (height, i, -1, 0))

        let lefters =
            seq{0 .. height - 1}
            |> Seq.map (fun i -> (i, -1, 0, 1))
        
        let righters =
            seq{0 .. height - 1}
            |> Seq.map (fun i -> (i, width, 0, -1))

        let inwards =
            Seq.concat [|downers; uppers; lefters; righters|]

        let addTile(y, h, dv, dh, tiles) =
            [|(y, h, dv, dh)|]
            |> Array.append tiles
            |> Array.sort
            |> Array.distinct

        let rec movePart1(currents:seq<int*int*int*int>, tiles:(int*int*int*int)[]) =

            if Seq.isEmpty currents then
                tiles
                |> Seq.map (fun (v, h, _, _) -> (v, h))
                |> Seq.distinct
                |> Seq.length
            else
                let moved =
                    currents
                    |> Seq.map (
                        fun (v, h, dv, dh) ->

                            let v2 = v + dv
                            if v2 < 0 || v2 > height - 1 then
                                Seq.empty
                            else
                                let h2 = h + dh
                                if h2 < 0 || h2 > width - 1 then
                                    Seq.empty
                                else
                                    match mirrorGrid[v2, h2] with
                                    | '.' ->
                                        seq { (v2, h2, dv, dh) }
                                    | '|' ->
                                        if dh = 0 then
                                            seq { (v2, h2, dv, dh) }
                                        else
                                            seq { (v2, h2, -1, 0); (v2, h2, 1, 0) }
                                    | '-' ->
                                        if dv = 0 then
                                            seq { (v2, h2, dv, dh) }
                                        else
                                            seq { (v2, h2, 0, -1); (v2, h2, 0, 1) }

                                    | '/' ->
                                        match (dv, dh) with
                                        | (0, 1) -> seq { (v2, h2, -1, 0) }
                                        | (0, -1) -> seq { (v2, h2, 1, 0) }
                                        | (1, 0) -> seq { (v2, h2, 0, -1) }
                                        | (_, _) -> seq { (v2, h2, 0, 1) }
                                    | _ ->
                                        match (dv, dh) with
                                        | (0, 1) -> seq { (v2, h2, 1, 0) }
                                        | (0, -1) -> seq { (v2, h2, -1, 0) }
                                        | (1, 0) -> seq { (v2, h2, 0, 1) }
                                        | (_, _) -> seq { (v2, h2, 0, -1) } )
                                        
                    |> Seq.concat
                    |> Seq.filter (fun c -> not (Array.contains c tiles)) 

                let newTiles =
                    moved
                    |> Seq.fold (fun a (v, h, dv, dh) -> addTile (v, h, dv, dh, a)) tiles

                movePart1 (moved, newTiles)


        let move(currents, tiles) =
            let result = movePart1(currents, tiles)
            // printfn "%i" result
            result 

        inwards
        |> Seq.map (fun a -> move (seq {a}, Array.empty))
        |> Seq.max
