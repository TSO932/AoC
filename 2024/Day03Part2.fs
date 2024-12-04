namespace _2024

open System
open System.Text.RegularExpressions

module Day03Part2 =

    let skipInst = "mul(0,0)"

    let getEnabledInstruction ((_, isEnabled:bool), input:string) =
        match input with
        | "don't()" -> (skipInst, false)
        | "do()" -> (skipInst, true)
        | _ -> if isEnabled then (input, true) else (skipInst, false)

    let getInstructions(input:string) =
        Regex.Matches(input, "mul\(\d{1,3},\d{1,3}\)|do\(\)|don't\(\)")
        |> Seq.scan (fun acc a -> getEnabledInstruction (acc, a.Value)) (skipInst, true)
        |> Seq.filter snd
        |> Seq.map fst

    let getSum(input:string) =
        input
        |> getInstructions
        |> Seq.sumBy Day03Part1.getMultiple

    let run(input:seq<string>) =
        input
        |> Seq.sumBy getSum