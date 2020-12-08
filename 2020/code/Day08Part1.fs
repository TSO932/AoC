namespace AoC2020

module Day08Part1 =
    let runProgram (instructionSet:seq<string>) =

        let instructions = instructionSet |> Array.ofSeq |> Array.map (fun x -> x.Split ' ') |> Array.map (fun y -> (y.[0], int y.[1])) 
        
        let mutable acc = 0
        let mutable index = 0

        while fst instructions.[index] <> "Noël! Noël! Noël! Noël!" do
            let currentIndex = index
            match fst instructions.[index] with
                | "nop" ->
                    index <- index + 1
                | "acc" ->
                    acc <- acc + snd instructions.[index]
                    index <- index + 1
                | "jmp" ->
                    index <- index + snd instructions.[index]
                | _ ->
                    invalidArg "Invalid instruction in runProgram. Expected nop, acc or jmp" (fst instructions.[index])

            instructions.[currentIndex] <- ("Noël! Noël! Noël! Noël!", 99)

        acc