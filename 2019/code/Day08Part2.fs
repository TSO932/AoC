namespace AoC2019

module Day08Part2 =
    let runProgram(code:string) =
   
        let flattenImage (layers) =
            let mutable mergedLayer = layers |> Seq.head |> Seq.map (fun x -> '2')
            for layer in layers do
                mergedLayer <- Seq.map2 (fun a b -> if a = '2' then b else a) mergedLayer layer
            mergedLayer |> Seq.map (fun c -> if c = '0' then ' ' else '*')

        for line in (code |> Seq.chunkBySize (25 * 6) |> flattenImage |> Array.ofSeq |> System.String |> Seq.chunkBySize (25) |> Seq.map (fun a -> a |> Array.ofSeq |> System.String)) do
            printfn "%s" line
