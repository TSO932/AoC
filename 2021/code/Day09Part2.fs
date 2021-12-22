namespace AoC2021

module Day09Part2 =
    let productOfBiggestBasins(floorPlan:seq<string>) =
        
        let arrays = floorPlan |> Seq.map (Array.ofSeq) |> Array.ofSeq
        let maxHeight = arrays.Length
        let maxWidth = arrays[0].Length
        let matrix = Array2D.init maxHeight maxWidth (fun i j -> arrays[i][j]) |> Array2D.map (fun c -> int (c.ToString()))

        let valueOfLocalMinumum(h, v, c) =
            let locality = matrix[(max 0 (v - 1))..(min maxHeight (v + 1)),(max 0 (h - 1))..(min maxWidth (h + 1))]
            if locality |> Seq.cast<int> |> Seq.min = c then
                [(h, v)]
            else
                []
        
        let minima = matrix |> Array2D.mapi (fun h v c -> valueOfLocalMinumum(v, h, c)) |> Seq.cast<seq<int*int>> |> Seq.concat

        let checkRing(x:int*int) =
            let h = fst x
            let v = snd x
            let left  = if h > 0             && matrix[v, h - 1] < 9 then [(h - 1, v)] else []
            let right = if h < maxWidth - 1  && matrix[v, h + 1] < 9 then [(h + 1, v)] else []
            let up    = if v > 0             && matrix[v - 1, h] < 9 then [(h, v - 1)] else []
            let down  = if v < maxHeight - 1 && matrix[v + 1, h] < 9 then [(h, v + 1)] else []
            Seq.concat [left; right; up; down]

        let rec checkRings(locations:seq<int*int>) =
            let wider = locations |> Seq.map checkRing |> Seq.append [locations] |> Seq.concat |> Seq.distinct
            if Seq.length wider = Seq.length locations then
                locations
            else
                checkRings(wider)

        minima |> Seq.map (fun loc -> checkRings [loc]) |> Seq.map Seq.length |> Seq.sort |> Seq.rev |> Seq.windowed 3 |> Seq.head |> Seq.fold (fun prod x -> x * prod) 1

