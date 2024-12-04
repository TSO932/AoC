namespace _2024

open System
open System.Text.RegularExpressions

module Day03Part2 =

    let getDos(input:string) =
        Regex.Matches(input, "do\(\)")
        |> Seq.map (fun a -> a.Index)
        |> Seq.map (fun i -> (i, true))

    let getDonts(input:string) =
        Regex.Matches(input, "don't\(\)")
        |> Seq.map (fun a -> a.Index)
        |> Seq.map (fun i -> (i, false))

    let getDosAndDonts(input:string) =
        Seq.append (getDos(input)) (getDonts(input))
        |> Seq.sortBy snd

    let isIndexPositionEnabled(rules, i) =
        rules
        |> Seq.filter (fun (j, _) -> j < i)
        |> Seq.append [(-1, true)]
        |> Seq.sortBy fst
        |> Seq.last
        |> snd

    let getEnabledInstructions(input:string) =

        let rules = getDosAndDonts(input)

        input
        |> Seq.toArray
        |> Array.mapi (fun i c -> (c, isIndexPositionEnabled (rules, i)))
        |> Array.filter (fun (_, b) -> b)
        |> Array.map fst
        |> System.String

    let getSum(input:string) =
        input
        |> getEnabledInstructions
        |> Day03Part1.getInstructions
        |> Seq.sumBy Day03Part1.getMultiple

    let run(input:seq<string>) =
        input
        |> Seq.sumBy getSum