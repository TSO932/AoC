namespace AoC2020

open System

module Day06Part1 =
    let countYeses (customsForms:seq<string>) =
        let forms = (customsForms |> Seq.map (fun x -> if x = "" then "#" else x) |> Seq.concat |> Seq.toArray |> String).Split "#"
        forms |> Seq.map (fun x -> (x |> Seq.distinct |> Seq.length)) |> Seq.sum 
        
        