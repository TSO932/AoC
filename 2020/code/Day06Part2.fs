namespace AoC2020

open System

module Day06Part2 =
    let countYeses (customsForms:seq<string>) =
        let forms = (customsForms |> Seq.map (fun x -> if x = "" then "#" else "!" + x) |> Seq.concat |> Seq.toArray |> String).Split "#"
        
        let countAllYeses(passengerGroup:string) =
            let talliesByGroup = passengerGroup |> Seq.distinct |> Seq.map (fun c -> (passengerGroup |> Seq.filter ((=) c) |> Seq.length)) |> Seq.sortBy (fun n -> -n) |> List.ofSeq
            talliesByGroup.Tail |> Seq.filter ((=) talliesByGroup.Head) |> Seq.length

        forms |> Seq.map countAllYeses |> Seq.sum 
        