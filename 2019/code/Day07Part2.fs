namespace AoC2019

module Day07Part2 =
    let runProgram (inputString:string, inputVals:int array) =

        let intcodes = inputVals |> Array.map (fun s -> inputString.Split ',' |> Array.map System.Int32.Parse)

        let inputValues = inputVals |> Array.map (fun x -> [|x|])
        inputValues.[0] <- Array.append inputValues.[0] [|0|]
        
        let indices = inputVals |> Array.map (fun s -> 0)
        let inputIndices = inputVals |> Array.map (fun s -> 0)
        let outputValues = inputVals |> Array.map (fun s -> 0)
        let mutable currentMachine = 0
        
        while intcodes.[currentMachine].[indices.[currentMachine]] <> 99 do
        
            let mutable index = indices.[currentMachine]
            let intcode = intcodes.[currentMachine]
           
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
                intcode.[intcode.[index + 1]] <- inputValues.[currentMachine].[inputIndices.[currentMachine]]
                inputIndices.[currentMachine] <- inputIndices.[currentMachine] + 1
                index <- index + 2

            elif opcode = 4 then
                outputValues.[currentMachine] <- getParameterValue(1)
                //printfn "output from machine %i = %i" currentMachine outputValues.[currentMachine]
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

            indices.[currentMachine] <- index
            intcodes.[currentMachine] <- intcode
            
            if opcode = 4 then
                let oldMachine = currentMachine
                currentMachine <- if currentMachine = inputValues.Length - 1 then 0 else currentMachine + 1
                inputValues.[currentMachine] <- Array.append inputValues.[currentMachine] [|outputValues.[oldMachine]|]
            
        outputValues.[inputValues.Length - 1]

    let findHighestSignal (inputString:string) =

        //Someone else's code here!  https://stackoverflow.com/questions/1526046/f-permutations   F# for Scientists (page 166-167) Jon D Harrop
        let rec distribute e = function
            | [] -> [[e]]
            | x::xs' as xs -> (e::xs)::[for xs in distribute e xs' -> x::xs]

        let rec permute = function
            | [] -> [[]]
            | e::xs -> List.collect (distribute e) (permute xs)
        //End of JD's code
        
        permute [5; 6; 7; 8; 9] |> List.map (fun phase -> runProgram (inputString, (phase |> Array.ofList))) |> List.max
