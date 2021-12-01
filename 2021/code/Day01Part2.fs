namespace AoC2021

module Day01Part2 =
    let countDepthIncreases (input:seq<string>) =

        input |> Array.ofSeq |> Array.windowed 3 |> Seq.map (fun t -> Seq.sumBy int t) |> Seq.pairwise |> Seq.filter (fun (a, b) -> int a < int b) |> Seq.length