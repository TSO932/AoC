namespace AoC2019

module Day05Part1 =
    let runProgram (inputString:string, inputValue) =
        let intcode = inputString.Split ',' |> Array.map System.Int32.Parse

        let mutable index = 0
        let mutable inputOutput = inputValue

        while intcode.[index] <> 99 do
            
            let opcode = intcode.[index] - 100 * (intcode.[index] / 100)
            
            let immediateModeSettings =
                let digits = (string intcode.[index]).PadLeft(5, '0')
                digits.[0..digits.Length - 3] |> Seq.map (fun c -> if c = '1' then true else false) |> List.ofSeq |> List.rev
               
            if opcode = 1 then
                intcode.[intcode.[index + 3]] <- (if immediateModeSettings.[0] then intcode.[index + 1] else intcode.[intcode.[index + 1]]) + if immediateModeSettings.[1] then intcode.[index + 2] else intcode.[intcode.[index + 2]]
                index <- index + 4

            elif opcode = 2 then
                intcode.[intcode.[index + 3]] <- (if immediateModeSettings.[0] then intcode.[index + 1] else intcode.[intcode.[index + 1]]) * if immediateModeSettings.[1] then intcode.[index + 2] else intcode.[intcode.[index + 2]]
                index <- index + 4

            elif opcode = 3 then
                intcode.[intcode.[index + 1]] <- inputOutput
                index <- index + 2

            elif opcode = 4 then
                inputOutput <- if immediateModeSettings.[0] then intcode.[index + 1] else intcode.[intcode.[index + 1]]
                index <- index + 2

        inputOutput