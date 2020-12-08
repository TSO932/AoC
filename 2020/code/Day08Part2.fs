namespace AoC2020

module Day08Part2 =
    let runProgram (instructions:array<string*int>) =
        
        let mutable acc = 0
        let mutable index = 0

        while index < instructions.Length && fst instructions.[index] <> "Noël! Noël! Noël! Noël!" do
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

        (index = instructions.Length, acc)

    let fixAndRun(instructionSet:seq<string>) =

        let instructions = instructionSet |> Array.ofSeq |> Array.map (fun x -> x.Split ' ') |> Array.map (fun y -> (y.[0], int y.[1])) 

        let magi = ("Wise Men", 3)
        let flipInstruction(instruction:string*int) =
            match fst instruction with
                | "nop" -> ("jmp", snd instruction)
                | "jmp" -> ("nop", snd instruction)
                | _     -> magi

        let getChangedInstructions(i:int) =
            let instr = Array.copy instructions
            instr.[i] <- flipInstruction(instr.[i])
            instr

        seq {0..(instructions.Length - 1)}
            |> Seq.map getChangedInstructions
            |> Seq.filter (fun x -> not (Array.exists ((=) magi) x))
            |> Seq.map runProgram
            |> Seq.filter fst
            |> Seq.exactlyOne
            |> snd
        
