namespace _2024

open System
open System.Collections.Generic

module Day11Part1 =

    let rec countNumberOfDigits(input:uint64) =
        if input <= 9UL then
            1
        else
            1 + countNumberOfDigits (input / 10UL)

    let isEven(digits:int) = digits % 2 = 0

    let split(input:uint64, digits:int) =

        let divisor = pown 10UL (digits / 2)
        let quotient = input / divisor
        let remainder = input % divisor
        [|quotient; remainder|]

    let blink(stone:uint64) =

        if stone = 0UL then
            [|1UL|]
        else
            let digits = countNumberOfDigits(stone)

            if isEven(digits) then
                split(stone, digits)
            else
                [|stone * 2024UL|]

    let blinkMem =
        let memoriser = new Dictionary<uint64, array<uint64>>();
        
        fun a ->
            let exist, results = memoriser.TryGetValue a
            match exist with
            | true -> results
            | _ -> 
                let results = blink a
                memoriser.Add(a, results)
                results

    let parseLine(inputLine:string) =
        inputLine.Split " "
        |> Seq.map (fun s -> (UInt64.Parse s, 1UL))
        |> Seq.toArray

    let blinkMult =
        let memoryBank = blinkMem

        fun (v, qty) ->
            memoryBank(v)
            |> Array.map (fun v -> (v, qty))

    let blinkLine =
        let memoryBank = blinkMult

        fun (stoneLine:array<uint64*uint64>) ->

            stoneLine
            |> Array.map (fun (st, count) -> memoryBank(st, count))
            |> Array.concat
            |> Array.groupBy fst
            |> Array.map (fun (v, grp) -> (v, grp |> Array.sumBy snd))

    let blinkRepeat(stoneLine:array<uint64*uint64>, reps) =
        reps
        |> Array.zeroCreate
        |> Array.fold (fun acc _ -> blinkLine(acc)) stoneLine

    let countStones(stoneLine:array<uint64*uint64>) =
        stoneLine
        |> Array.sumBy snd

    let runN(input:string, reps) =
        
        input
        |> parseLine
        |> (fun k -> blinkRepeat(k, reps))
        |> countStones

    let run(input) = runN(input, 25)
