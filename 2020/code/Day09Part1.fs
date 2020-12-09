namespace AoC2020

module Day09Part1 =
    let findInvalidNum (dataSequence:seq<string>, preambleLength:int) =

        let intArray = dataSequence |> Array.ofSeq |> Array.map int64
        
        let checkValidity(i:int) =
            let range = intArray.[(i - 1 - preambleLength)..(i - 1)]
            range |> Array.collect (fun x -> (range |> Array.map (fun y -> x + y))) |> Array.contains intArray.[i]
            
        intArray
            |> Array.mapi (fun i x -> (x, if i <= preambleLength then true else checkValidity i)) 
            |> Array.filter (fun b -> snd b = false) |> Array.map fst |> Array.exactlyOne

    let findInvalidNumber (dataSequence:seq<string>) = findInvalidNum(dataSequence, 25)