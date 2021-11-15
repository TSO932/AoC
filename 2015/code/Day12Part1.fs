namespace AoC2015

open System

module Day12Part1 =

    let rec sumNumbers(input:string) = input.Split [|':'; '{'; '}'; '['; ']'; '"'; ','|] |> Seq.map Int32.TryParse |> Seq.sumBy snd
