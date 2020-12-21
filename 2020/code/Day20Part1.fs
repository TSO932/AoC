namespace AoC2020

module Day20Part1 =
    let findCorners (pixels:seq<string>) =

        let isDebug = true
        
        let p = Seq.map (fun x -> (Seq.head x, Seq.tail x)) (pixels |> Seq.filter  (fun x -> x.Length > 0) |> Seq.chunkBySize 11)
        let pix = p |> Seq.map (fun x -> (int64 (fst x).[5..8], (Array2D.init 10 10 (fun i j -> (snd x |> Array.ofSeq).[i].[j]))))

        let getEdges(pixel:char[,]) = 
            let edges = seq {pixel.[0, 0..9]; pixel.[9, 0..9]; pixel.[0..9, 0]; pixel.[0..9, 9] }
            Seq.concat (seq {edges; edges |> Seq.map (Array.rev)}) |> Seq.map System.String.Concat

        let pixelsEdges = pix |> Seq.map (fun (tileNumber, pixel) -> (tileNumber, getEdges(pixel)))

        let allEdges = Seq.collect snd pixelsEdges

        let countMatches(a:seq<string>) =
            let mutable matchCount = -8
            for i in a do
                for j in allEdges do
                    if i = j then
                        matchCount <- matchCount + 1
            matchCount

        pixelsEdges |> Seq.filter (fun (_, edges) -> countMatches(edges) = 4) |> Seq.fold (fun acc (elem, _) -> acc * elem ) 1L