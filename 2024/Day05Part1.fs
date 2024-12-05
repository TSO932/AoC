namespace _2024

open System

module Day05Part1 =

    let run(input:seq<string>) =

        let pageRules = input |> Seq.filter (fun s -> s.Contains("|"))

        let isPackValid(pack) =

            let isOutOfOrder(page) =
                Seq.contains (snd page + "|" + fst page) pageRules
            
            pack
            |> Seq.pairwise
            |> Seq.exists isOutOfOrder
            |> not

        let getMiddlePage(input) =
            let inputArray = Seq.toArray input
            inputArray[(Seq.length input) / 2]

        input
        |> Seq.filter (fun s -> s.Contains(","))
        |> Seq.map (fun s -> s.Split ',')
        |> Seq.filter isPackValid
        |> Seq.sumBy (getMiddlePage >> Int32.Parse)
