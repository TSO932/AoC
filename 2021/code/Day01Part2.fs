namespace AoC2021

module Day01Part2 =
    let countDepthIncreases (input:seq<string>) =

        input |> Seq.windowed 3 |> Seq.map (fun t -> Seq.sumBy int t) |> Seq.pairwise |> Seq.filter (fun (a, b) -> a < b) |> Seq.length