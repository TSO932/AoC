namespace AoC2015

open System.Collections.Generic

module Day02Part1 =

    let getAreaForPresent (box:string) =
        let dimensions =   box.Split 'x'

        let l = int dimensions.[0]
        let w = int dimensions.[1]
        let h = int dimensions.[2]

        let sides = [|l * w ; l * h ; w * h |]

        2 * Array.sum sides + Array.min sides


    let getTotalArea (input:seq<string>) =

        input |> Seq.sumBy (fun b -> getAreaForPresent b)
