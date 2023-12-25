namespace _2023

open System

module Day01Part1 =
    let calibrate (input: seq<string>) =
        input
        |> Seq.map Seq.toList
        |> Seq.map (Seq.filter (fun x -> x >= '0' && x <= '9'))
        |> Seq.map (fun q -> (q |> Seq.head |> Char.ToString ) + (q |> Seq.rev |> Seq.head |> Char.ToString))
        |> Seq.sumBy Int32.Parse
