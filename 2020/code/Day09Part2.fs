namespace AoC2020

module Day09Part2 =
    let findWeakness (dataSequence:seq<string>, invalidNumber:int64) =

        let intArray = dataSequence |> Seq.map int64 |> Array.ofSeq
        
        let mutable weakness = 0L
        let mutable isNotAnswered = true

        for length in seq {1..((Array.length intArray) - 2)} do
            if isNotAnswered then
                for start in seq {0..((Array.length intArray) - 2)} do
                    if isNotAnswered && invalidNumber = (intArray.[start..(start + length)] |> Seq.sum) then
                        let sortedArray = intArray.[start..(start + length)] |> Array.sort
                        weakness <- sortedArray.[0] + sortedArray.[sortedArray.Length - 1]
                        isNotAnswered <- false

        weakness

    let findEncryptionWeakness (dataSequence:seq<string>)
        = findWeakness(dataSequence, Day09Part1.findInvalidNumber(dataSequence))