namespace AoC2019

module Day13Part1 =

    let runProgram (inputString:string) =

        let isDebug = false

        let intcode:(int64 array) = Array.concat [|inputString.Split ',' |> Array.map System.Int64.Parse; (Array.zeroCreate 10000)|] 
        let mutable index = 0

        let mutable currentLocation = (0L, 0L)
        let mutable outputNumber = 1
        let mutable locations = Map.empty

        let mutable inputValue = 0L
        let mutable outputValue = 0L
        let mutable relativeBase = 0

        while intcode.[index] <> 99L && locations.Count < 10000 do

            let opcode = intcode.[index] - 100L * (intcode.[index] / 100L)
            
            let modeSettings =
                let digits = (string intcode.[index]).PadLeft(5, '0')
                digits.[0..digits.Length - 3] |> List.ofSeq |> List.rev
            
            let indexRef = ref index
            let relativeBaseRef = ref relativeBase
            
            let getParameterValue(position:int) =
                if isDebug then printfn "DEBUG index %i relativeBase %i opcode %i position %i mode %s intcode value %i modeSettings %O " index relativeBase opcode position (string modeSettings.[position - 1]) intcode.[index + position] modeSettings

                match modeSettings.[position - 1] with
                | '0' -> intcode.[int intcode.[!indexRef + position]]  //positional mode
                | '1' -> intcode.[!indexRef + position]  //immediate mode
                | '2' -> intcode.[!relativeBaseRef + int intcode.[!indexRef + position]]  //relative mode
                |  _  -> invalidArg "Invalid modeSetting for getParameterValue. Expected 0, 1 or 2" (string modeSettings.[position - 1])
                
            let getIndexForWrite(position:int) =
                match modeSettings.[position - 1] with
                | '0' -> int intcode.[!indexRef + position]  //positional mode
                | '2' -> !relativeBaseRef + int intcode.[!indexRef + position]  //relative mode
                |  _  -> invalidArg "Invalid modeSetting for getIndexForWrite. Expected 0 or 2" (string modeSettings.[position - 1])

            if opcode = 1L then
                intcode.[getIndexForWrite(3)] <- getParameterValue(1) + getParameterValue(2)
                index <- index + 4

            elif opcode = 2L then
                intcode.[getIndexForWrite(3)] <- getParameterValue(1) * getParameterValue(2)
                index <- index + 4

            elif opcode = 3L then
                inputValue <- 0L

                intcode.[getIndexForWrite(1)] <- inputValue
                index <- index + 2

            elif opcode = 4L then
                outputValue <- getParameterValue(1)
                index <- index + 2
                
                if outputNumber = 1 then          
                    currentLocation <- (outputValue, snd currentLocation)
                    outputNumber <- 2
                elif outputNumber = 2 then
                    currentLocation <- (fst currentLocation, outputValue)
                    outputNumber <- 3
                else
                    locations <- locations |> Map.add currentLocation outputValue
                    outputNumber <- 1

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
                relativeBase <- relativeBase + (getParameterValue(1) |> int)
                index <- index + 2

        locations |> Map.filter (fun _ value -> value = 2L) |> Map.count