namespace _2024

open System

module Day09Part2 =

    let run(inputLine:string) =

        let disk =
            inputLine
            |> Array.ofSeq
            |> Array.map (Char.ToString >> int)
            |> Array.mapi (fun i v -> Array.replicate v ((if i % 2 = 0 then i / 2 else -1), v))
            |> Array.concat

        let rec moveFile(disk) =
            let lastBlock = disk |> Array.tryFindIndexBack (fun (id, len) -> id >= 0  && len >= 0)

            if lastBlock.IsNone then
                disk
            else
                let blockLength = snd disk[lastBlock.Value]
                let firstSpace = disk |> Array.tryFindIndex (fun(id, len) -> id = -1 && len >= blockLength)
                
                if firstSpace.IsNone || lastBlock.Value < firstSpace.Value then
                    // set second attribute to -1 to hide  from future searches 
                    Seq.init blockLength (fun v -> lastBlock.Value - v)
                    |> Seq.fold (fun arr v -> arr |> Array.updateAt v (fst arr[lastBlock.Value], -1)) disk
                    |> moveFile
                else
                    // place block in new position
                    let blockPlaced = 
                        Seq.init blockLength (fun v -> v + firstSpace.Value)
                        |> Seq.fold (fun arr v -> arr |> Array.updateAt v (fst arr[lastBlock.Value], -1)) disk

                    // adjust space after new block
                    let extraSpaces = snd disk[firstSpace.Value] - blockLength
                    let spacedAdjusted =
                        Seq.init extraSpaces (fun v -> v + firstSpace.Value + blockLength)
                        |> Seq.fold (fun arr v -> arr |> Array.updateAt v (-1, extraSpaces)) blockPlaced

                    // remove block from old position
                    Seq.init blockLength (fun v -> lastBlock.Value - v)
                    |> Seq.fold (fun arr v -> arr |> Array.updateAt v (-1, -1)) spacedAdjusted
                    |> moveFile
                
        disk
        |> moveFile
        |> Array.mapi (fun i v -> if fst v > 0 then int64(i * fst v) else 0)
        |> Array.sum





