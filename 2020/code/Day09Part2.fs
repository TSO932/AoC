namespace AoC2020

module Day09Part2 =
    let findWeakness (dataSequence:seq<string>, invalidNumber:int64) =

        let intArray = dataSequence |> Seq.map int64 |> Array.ofSeq
        
        let mutable weakness = 0L
        for start in seq {0..((Array.length intArray) - 1)} do
            let mutable isBust = false
            for finish in seq {1..(Array.length intArray)} do
                if weakness = 0L && not isBust && start <> finish && finish - start < 101 then
                    match invalidNumber.CompareTo(intArray.[start..finish] |> Seq.sum) with
                    |  0 -> 
                        let sortedArray = intArray.[start..finish] |> Array.sort
                        weakness <- sortedArray.[0] + sortedArray.[sortedArray.Length - 1]
                    | -1 ->
                        isBust <- true
                    |  _ ->
                        isBust <- false

        weakness

    let findEncryptionWeakness (dataSequence:seq<string>)
        = findWeakness(dataSequence, Day09Part1.findInvalidNumber(dataSequence))