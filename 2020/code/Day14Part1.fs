namespace AoC2020
open System.Collections.Generic
open System

module Day14Part1 =

    let rec getBinaryFromDecimal (decimal:int) =

        if decimal < 2 then
            string decimal
        else
            getBinaryFromDecimal (decimal / 2) + string (decimal % 2)

    let getDecimalFromBinary (binary:string) =
        binary |> List.ofSeq |> List.rev |> List.mapi (fun i x -> int64 (string x) * pown 2L i) |> List.sumBy id

    let applyBitmask(input:string, mask:string) =
       
        List.map2 (fun i m -> if m = 'X' then i else m) (List.ofSeq (input.PadLeft(mask.Length, '0'))) (List.ofSeq (mask.PadLeft(input.Length, 'X'))) |> Array.ofList |> String

    let parseMemoryPair(input:string) =

        let values = input.[4..].Split("] = ") |> Array.ofSeq |> Array.map int
        (values.[0], values.[1])

    let initializeFerryDockingProgram(instructions:seq<string>) =

        let mutable mask = ""
        let memory = new Dictionary<int, int64>()

        for instruction in instructions do
            if instruction.[..6] = "mask = " then
                mask <- instruction.[7..]
            else
                let (location, value) = parseMemoryPair(instruction)
                memory.Remove(location) |> ignore
                memory.Add(location, getDecimalFromBinary(applyBitmask(getBinaryFromDecimal(value), mask)))

        memory.Values |> Seq.sumBy id 
