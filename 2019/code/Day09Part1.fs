namespace AoC2019

module Day09Part1 =
    let runProgram (inputString:string, inputVals:int64 array) =

        let isDebug = false
        let isShowAllOutputs = true
        
        let intcodes = inputVals |> Array.map (fun s -> Array.concat [|inputString.Split ',' |> Array.map System.Int64.Parse; (Array.zeroCreate 1000)|]) 
        let inputValues = inputVals |> Array.map (fun x -> [|x|])
        inputValues.[0] <- Array.append inputValues.[0] [|0L|]
        
        let indices = Array.zeroCreate inputValues.Length
        let inputIndices = Array.zeroCreate inputValues.Length
        let outputValues = Array.zeroCreate inputValues.Length
        let relativeBases = Array.zeroCreate inputValues.Length
        let mutable currentMachine = 0
        
        while intcodes.[currentMachine].[indices.[currentMachine]] <> 99L do
        
            let mutable index = indices.[currentMachine]
            let intcode = intcodes.[currentMachine]
     
            let opcode = intcode.[index] - 100L * (intcode.[index] / 100L)
            
            if isDebug then printfn "SRT index %i opcode %i machine %i base %i output %i intcode.[index]... %i %i %i %i" index opcode currentMachine relativeBases.[currentMachine] outputValues.[currentMachine] intcode.[index] intcode.[index + 1] intcode.[index + 2] intcode.[index + 3]
            
            let modeSettings =
                let digits = (string intcode.[index]).PadLeft(5, '0')
                digits.[0..digits.Length - 3] |> List.ofSeq |> List.rev
            
            let indexRef = ref index
            let relativeBase = ref relativeBases.[currentMachine]
            
            let getParameterValue(position:int) =
                if modeSettings.[position - 1] = '0' then
                    intcode.[int intcode.[!indexRef + position]]  //positional mode
                elif modeSettings.[position - 1] = '1' then
                    intcode.[!indexRef + position]  //immediate mode
                else
                    intcode.[!relativeBase + int intcode.[!indexRef + position]]  //relative mode
                
            let getIndexForWrite(position:int) =
                if modeSettings.[position - 1] = '0' then
                    int intcode.[!indexRef + position]  //positional mode
                else
                    !relativeBase + int intcode.[!indexRef + position]  //relative mode
                    
            if opcode = 1L then
                intcode.[getIndexForWrite(3)] <- getParameterValue(1) + getParameterValue(2)
                index <- index + 4

            elif opcode = 2L then
                intcode.[getIndexForWrite(3)] <- getParameterValue(1) * getParameterValue(2)
                index <- index + 4

            elif opcode = 3L then
                intcode.[getIndexForWrite(1)] <- inputValues.[currentMachine].[inputIndices.[currentMachine]]
                inputIndices.[currentMachine] <- inputIndices.[currentMachine] + 1
                index <- index + 2

            elif opcode = 4L then
                outputValues.[currentMachine] <- getParameterValue(1)
                index <- index + 2

            elif opcode = 5L then
                index <- if getParameterValue(1) <> 0L then (getParameterValue(2) |> int)
                         else index + 3
                    
            elif opcode = 6L then
                index <- if getParameterValue(1) = 0L then (getParameterValue(2) |> int)
                         else index + 3

            elif opcode = 7L then
                intcode.[getIndexForWrite(3)] <- if getParameterValue(1) < getParameterValue(2) then 1L else 0L
                index <- index + 4
                
            elif opcode = 8L then
                intcode.[getIndexForWrite(3)] <- if getParameterValue(1) = getParameterValue(2) then 1L else 0L
                index <- index + 4
                
            elif opcode = 9L then
                relativeBases.[currentMachine] <- relativeBases.[currentMachine] + (getParameterValue(1) |> int)
                index <- index + 2
                
            indices.[currentMachine] <- index
            intcodes.[currentMachine] <- intcode
            
            if opcode = 4L then
                if isShowAllOutputs then printfn "machine %i index %i output %i" currentMachine index outputValues.[currentMachine]
                
                let oldMachine = currentMachine
                currentMachine <- if currentMachine = inputValues.Length - 1 then 0 else currentMachine + 1
                inputValues.[currentMachine] <- Array.append inputValues.[currentMachine] [|outputValues.[oldMachine]|]
            
            if isDebug then printfn "END index %i opcode %i machine %i base %i output %i intcode %A" index opcode currentMachine relativeBases.[currentMachine] outputValues.[currentMachine] intcode
            
        outputValues.[inputValues.Length - 1]