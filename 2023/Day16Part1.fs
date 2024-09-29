namespace _2023

module Day16Part1 =

    let countTiles(input:seq<string>) = 
        let mirrorGrid = array2D input

        let height = Array2D.length1 mirrorGrid
        let width  = Array2D.length2 mirrorGrid
        
        let addTile(y, h, dv, dh, tiles) =
            [|(y, h, dv, dh)|]
            |> Array.append tiles
            |> Array.sort
            |> Array.distinct

        let rec move(currents:seq<int*int*int*int>, tiles:(int*int*int*int)[]) =

            // printfn "%i %i" (Seq.length currents) (Seq.length tiles)

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

                move (moved, newTiles)
                            
        move (seq {(0, -1, 0, 1)}, Array.empty)
