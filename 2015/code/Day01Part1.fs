namespace AoC2015

module Day01Part1 =
    let getFloor (input:seq<string>) =

        input |> Array.ofSeq |> Array.head |> Seq.countBy id |> Seq.map (fun (c, i) -> match c with '(' -> i | ')' -> -i | _ -> 0) |> Seq.sum
