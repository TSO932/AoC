namespace AoC2022

module Day03Part2 =

    let GetBadge (backpacks:seq<string>) =

        let packs = Array.ofSeq backpacks

        packs[0]
            |> Seq.filter (fun c -> Seq.exists (fun c1 -> c1 = c) packs[1])
            |> Seq.filter (fun c -> Seq.exists (fun c1 -> c1 = c) packs[2])
            |> Seq.head

    let GetSumOfPriorities (backpacks:seq<string>) =

        backpacks
            |> Seq.chunkBySize 3
            |> Seq.sumBy (fun backpacks -> backpacks |> GetBadge |> Day03Part1.GetPriority)