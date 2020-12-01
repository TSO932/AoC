namespace AoC2019

module Day07Part1 =
    let runProgram (inputString:string, inputValues:int array) =
        let intcode = inputString.Split ',' |> Array.map System.Int32.Parse

        let mutable index = 0
        let mutable inputIndex = 0
        let mutable outputValue = 0

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
                intcode.[intcode.[index + 1]] <- inputValues.[inputIndex]
                inputIndex <- inputIndex + 1
                index <- index + 2

            elif opcode = 4 then
                outputValue <- getParameterValue(1)
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
        
        outputValue
        
    let runPrograms (inputString:string, instructions) =
        instructions |> List.fold (fun i j -> runProgram (inputString, [|j;i|])) 0

    let findHighestSignal (inputString:string) =

        //Someone else's code here!  https://stackoverflow.com/questions/1526046/f-permutations   F# for Scientists (page 166-167) Jon D Harrop
        let rec distribute e = function
            | [] -> [[e]]
            | x::xs' as xs -> (e::xs)::[for xs in distribute e xs' -> x::xs]

        let rec permute = function
            | [] -> [[]]
            | e::xs -> List.collect (distribute e) (permute xs)
        //End of JD's code
        
        permute [0; 1; 2; 3; 4] |> List.map (fun s -> runPrograms (inputString, s)) |> List.max