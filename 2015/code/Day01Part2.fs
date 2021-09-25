namespace AoC2015

open System.Collections.Generic

module Day01Part2 =
    let getFirstStepIntoBasement (input:seq<string>) =

        input |> Array.ofSeq |> Array.head |> Seq.scan (fun i c -> match c with '(' -> i + 1 | ')' -> i - 1 | _ -> i) 0 |> Seq.mapi (fun i x -> if x < 0 then i else 99999) |> Seq.min
