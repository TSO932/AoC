namespace _2024

open System

module Day09Part1 =

    let run(inputLine:string) =

        let disk =
            inputLine
            |> Array.ofSeq
            |> Array.map (Char.ToString >> int)
            |> Array.mapi (fun i v -> Array.replicate v (if i % 2 = 0 then i / 2 else -1))
            |> Array.concat

        let rec moveFile(disk) =

            let firstSpace = disk |> Array.findIndex ((=) -1) 
            let lastBlock = disk |> Array.findIndexBack ((<=) 0)

            if lastBlock < firstSpace then
                disk
            else
                disk
                |> Array.updateAt firstSpace disk[lastBlock]
                |> Array.updateAt lastBlock -1
                |> moveFile
        
        disk
        |> moveFile
        |> Array.mapi (fun i v -> if v > 0 then int64(i * v) else 0)
        |> Array.sum





