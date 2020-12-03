namespace AoC2020

module Day03Part1 =
    let countTrees (forestMap:seq<string>) =

        let isDebug = false
        
        let arrays = forestMap |> Seq.map (String.replicate (3 * Seq.length forestMap)) |> Seq.map (Array.ofSeq) |> Array.ofSeq
        let matrix = Array2D.init arrays.Length arrays.[0].Length (fun i j -> arrays.[i].[j])

        if isDebug then printfn "%A" matrix

        let treeCount = matrix |> Array2D.mapi (fun y x c -> if c = '#' && x = 3 * y then 1 else 0)
        
        if isDebug then printfn "%A" treeCount
        
        treeCount |> Seq.cast<int> |> Seq.sum
        