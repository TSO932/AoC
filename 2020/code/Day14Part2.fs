namespace AoC2020
open System.Collections.Generic
open System

module Day14Part2 =

    let convertMask(mask:string) =
        let rec convert(flexMask:char array, newMasks:seq<string>) =
            if flexMask.Length = 0 then
                newMasks
            else
                convert(flexMask.[1..], match flexMask.[0] with
                                        | 'X' ->
                                            newMasks |> Seq.collect (fun m -> seq {(m + "0"); (m + "1")})
                                        | '1' ->
                                            newMasks |> Seq.map (fun m -> m + "1")
                                        | '0' ->
                                            newMasks |> Seq.map (fun m -> m + "X")
                                        |  _  ->
                                            invalidArg "ConverMask expects only '0', '1' or 'X'" (flexMask |> List.ofArray |> string) )

        convert(Array.ofSeq mask, seq { "" })

    let rec getBinaryFromDecimal (decimal:int64) =

        if decimal < 2L then
            string decimal
        else
            getBinaryFromDecimal (decimal / 2L) + string (decimal % 2L)

    let applyBitmask(input:string, masks:seq<string>) =
           (Seq.map ((fun m -> Day14Part1.applyBitmask(input, m)) >> (fun bin -> Day14Part1.getDecimalFromBinary(bin))) masks)
    
    let parseMemoryPair(input:string) =

        let values = input.[4..].Split("] = ") |> Array.ofSeq |> Array.map int64
        (values.[0], values.[1])

    let initializeFerryDockingProgram(instructions:seq<string>) =

        let mutable masks = Seq.empty
        let memory = new Dictionary<int64, int64>()

        for instruction in instructions do
            if instruction.[..6] = "mask = " then
                masks <- convertMask(instruction.[7..])
            else
                let (location, value) = parseMemoryPair(instruction)
                let locations = applyBitmask(getBinaryFromDecimal(location), masks)
                for loc in locations do
                    memory.Remove(loc) |> ignore
                    memory.Add(loc, value)

        memory.Values |> Seq.sumBy id 
