namespace _2024

open System
open System.Text.RegularExpressions

module Day03Part1 =

    let getMultiple(input:string) =
        let numbers =  input.Split ','
        let a = Int64.Parse (numbers[0].Replace ("mul(", ""))
        let b = Int64.Parse (numbers[1].Replace (")", ""))

        a * b

    let getInstructions(input:string) =
        Regex.Matches(input, "mul\(\d{1,3},\d{1,3}\)")
        |> Seq.map (fun a -> a.Value)

    let getSum(input:string) =
        input
        |> getInstructions
        |> Seq.sumBy getMultiple

    let run(input:seq<string>) =
        input
        |> Seq.sumBy getSum