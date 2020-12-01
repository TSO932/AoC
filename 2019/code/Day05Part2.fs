namespace AoC2019

module Day05Part2 =
    let runProgram (inputString:string, inputValue) =
        let intcode = inputString.Split ',' |> Array.map System.Int32.Parse

        let mutable index = 0
        let mutable inputOutput = inputValue

        while intcode.[index] <> 99 do
            
            let opcode = intcode.[index] - 100 * (intcode.[index] / 100)
                       
            let immediateModeSettings =
                let digits = (string intcode.[index]).PadLeft(5, '0')
                digits.[0..digits.Length - 3] |> Seq.map (fun c -> if c = '1' then true else false) |> List.ofSeq |> List.rev
            
            let indexRef = ref index
            let getParameterValue(position:int) =
                if immediateModeSettings.[position - 1] then intcode.[!indexRef + position] else intcode.[intcode.[!indexRef + position]]
                
            if opcode = 1 then
                intcode.[intcode.[index + 3]] <- getParameterValue(1) + getParameterValue(2)
                index <- index + 4

            elif opcode = 2 then
                intcode.[intcode.[index + 3]] <- getParameterValue(1) * getParameterValue(2)
                index <- index + 4

            elif opcode = 3 then
                intcode.[intcode.[index + 1]] <- inputOutput
                index <- index + 2

            elif opcode = 4 then
                inputOutput <- getParameterValue(1)
                index <- index + 2

            elif opcode = 5 then
                index <- if getParameterValue(1) <> 0 then getParameterValue(2)
                         else index + 3
                    
            elif opcode = 6 then
                index <- if getParameterValue(1) = 0 then getParameterValue(2)
                         else index + 3

            elif opcode = 7 then
                intcode.[intcode.[index + 3]] <- if getParameterValue(1) < getParameterValue(2) then 1 else 0
                index <- index + 4
                
            elif opcode = 8 then
                intcode.[intcode.[index + 3]] <- if getParameterValue(1) = getParameterValue(2) then 1 else 0
                index <- index + 4
                
        inputOutput 