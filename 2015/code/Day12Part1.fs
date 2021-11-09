namespace AoC2015

open System

module Day12Part1 =

    let rec sumNumbers(input:string) =
        input.Split [|':'; '{'; '}'; '['; ']'; '"'; ','|] |> Seq.map (fun s -> Int32.TryParse s) |> Seq.sumBy snd
        