namespace AoC2021

module Day09Part1 =
    let sumOfLocalMinima(floorPlan:seq<string>) =
        
        let arrays = floorPlan |> Seq.map (Array.ofSeq) |> Array.ofSeq
        let maxHeight = arrays.Length
        let maxWidth = arrays[0].Length
        let matrix = Array2D.init maxHeight maxWidth (fun i j -> arrays[i][j]) |> Array2D.map (fun c -> int (c.ToString()))

        let valueIfLocalMinumum(v, h, c) =
            let locality = matrix[(max 0 (h - 1))..(min maxHeight (h + 1)),(max 0 (v - 1))..(min maxWidth (v + 1))]
            if locality |> Seq.cast<int> |> Seq.min = c then
                c + 1
            else
                0 
        
        matrix |> Array2D.mapi (fun h v c -> valueIfLocalMinumum(v, h, c)) |> Seq.cast<int> |> Seq.fold (fun acc x -> acc + x) 0