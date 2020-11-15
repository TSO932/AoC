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
    
    printfn "%i" (permute [5; 6; 7; 8; 9] |> List.map (fun phase -> runProgram (inputString, (phase |> Array.ofList))) |> List.max)
        
findHighestSignal("3,26,1001,26,-4,26,3,27,1002,27,2,27,1,27,26,27,4,27,1001,28,-1,28,1005,28,6,99,0,0,5") //example 1
findHighestSignal("3,52,1001,52,-5,52,3,53,1,52,56,54,1007,54,5,55,1005,55,26,1001,54,-5,54,1105,1,12,1,53,54,53,1008,54,0,55,1001,55,1,55,2,53,55,53,4,53,1001,56,-1,56,1005,56,6,99,0,0,0,0,10") //example 2

findHighestSignal("3,8,1001,8,10,8,105,1,0,0,21,42,55,64,85,98,179,260,341,422,99999,3,9,101,2,9,9,102,5,9,9,1001,9,2,9,1002,9,5,9,4,9,99,3,9,1001,9,5,9,1002,9,4,9,4,9,99,3,9,101,3,9,9,4,9,99,3,9,1002,9,4,9,101,3,9,9,102,5,9,9,101,4,9,9,4,9,99,3,9,1002,9,3,9,1001,9,3,9,4,9,99,3,9,1002,9,2,9,4,9,3,9,101,1,9,9,4,9,3,9,101,1,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,101,1,9,9,4,9,3,9,101,1,9,9,4,9,3,9,101,2,9,9,4,9,3,9,1001,9,1,9,4,9,3,9,1002,9,2,9,4,9,3,9,1001,9,2,9,4,9,99,3,9,1002,9,2,9,4,9,3,9,101,2,9,9,4,9,3,9,1001,9,2,9,4,9,3,9,101,2,9,9,4,9,3,9,102,2,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,101,1,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,102,2,9,9,4,9,3,9,101,2,9,9,4,9,99,3,9,1002,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,101,1,9,9,4,9,3,9,1001,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,101,1,9,9,4,9,3,9,101,2,9,9,4,9,3,9,101,2,9,9,4,9,3,9,102,2,9,9,4,9,3,9,102,2,9,9,4,9,99,3,9,102,2,9,9,4,9,3,9,102,2,9,9,4,9,3,9,1001,9,2,9,4,9,3,9,1001,9,1,9,4,9,3,9,1001,9,1,9,4,9,3,9,101,1,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,101,2,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,1002,9,2,9,4,9,99,3,9,1001,9,1,9,4,9,3,9,102,2,9,9,4,9,3,9,1001,9,1,9,4,9,3,9,1002,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,101,2,9,9,4,9,3,9,1001,9,1,9,4,9,3,9,1002,9,2,9,4,9,3,9,102,2,9,9,4,9,3,9,102,2,9,9,4,9,99")

