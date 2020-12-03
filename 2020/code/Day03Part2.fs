namespace AoC2020

module Day03Part2 =
    let countTrees (forestMap:seq<string>) =

        let isDebug = false
        
        let arrays = forestMap |> Seq.map (String.replicate (7 * Seq.length forestMap)) |> Seq.map (Array.ofSeq) |> Array.ofSeq
        let matrix = Array2D.init arrays.Length arrays.[0].Length (fun i j -> arrays.[i].[j])

        if isDebug then printfn "%A" matrix

        let routes = [(1, 1), (3, 1), (5, 1), (7, 1), (1, 2)]

        let treeCount(route:int*int) =
            matrix |> Array2D.mapi (fun y x c -> if c = '#' && x * snd route = y * fst route then 1 else 0) |> Seq.cast<int> |> Seq.sum

        let tc1 = treeCount (1, 1)
        let tc2 = treeCount (3, 1)
        let tc3 = treeCount (5, 1)
        let tc4 = treeCount (7, 1)
        let tc5 = treeCount (1, 2)

        tc1 * tc2 * tc3 * tc4 * tc5        