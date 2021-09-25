namespace AoC2015

open System.Collections.Generic

module Day02Part2 =

    let getLengthForPresent (box:string) =
        let dimensions =   box.Split 'x'

        let l = int dimensions.[0]
        let w = int dimensions.[1]
        let h = int dimensions.[2]

        2 * (l + w + h - Array.max [|l ; w ; h |]) + l * w * h

    let getTotalLength (input:seq<string>) =

        input |> Seq.sumBy (fun b -> getLengthForPresent b)
