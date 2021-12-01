namespace AoC2021

module Day01Part1 =
    let countDepthIncreases (input:seq<string>) =

        input |> Array.ofSeq |> Array.pairwise |> Seq.filter (fun (a, b) -> int a < int b) |> Seq.length