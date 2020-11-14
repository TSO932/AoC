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
    
    printfn "%i" (permute [0; 1; 2; 3; 4] |> List.map (fun s -> runPrograms (inputString, s)) |> List.max)
        
findHighestSignal("3,15,3,16,1002,16,10,16,1,16,15,15,4,15,99,0,0") //example 1
findHighestSignal("3,23,3,24,1002,24,10,24,1002,23,-1,23,101,5,23,23,1,24,23,23,4,23,99,0,0") //example 2
findHighestSignal("3,31,3,32,1002,32,10,32,1001,31,-2,31,1007,31,0,33,1002,33,7,33,1,33,31,31,1,32,31,31,4,31,99,0,0,0") //example 3

findHighestSignal("3,8,1001,8,10,8,105,1,0,0,21,42,55,64,85,98,179,260,341,422,99999,3,9,101,2,9,9,102,5,9,9,1001,9,2,9,1002,9,5,9,4,9,99,3,9,1001,9,5,9,1002,9,4,9,4,9,99,3,9,101,3,9,9,4,9,99,3,9,1002,9,4,9,101,3,9,9,102,5,9,9,101,4,9,9,4,9,99,3,9,1002,9,3,9,1001,9,3,9,4,9,99,3,9,1002,9,2,9,4,9,3,9,101,1,9,9,4,9,3,9,101,1,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,101,1,9,9,4,9,3,9,101,1,9,9,4,9,3,9,101,2,9,9,4,9,3,9,1001,9,1,9,4,9,3,9,1002,9,2,9,4,9,3,9,1001,9,2,9,4,9,99,3,9,1002,9,2,9,4,9,3,9,101,2,9,9,4,9,3,9,1001,9,2,9,4,9,3,9,101,2,9,9,4,9,3,9,102,2,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,101,1,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,102,2,9,9,4,9,3,9,101,2,9,9,4,9,99,3,9,1002,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,101,1,9,9,4,9,3,9,1001,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,101,1,9,9,4,9,3,9,101,2,9,9,4,9,3,9,101,2,9,9,4,9,3,9,102,2,9,9,4,9,3,9,102,2,9,9,4,9,99,3,9,102,2,9,9,4,9,3,9,102,2,9,9,4,9,3,9,1001,9,2,9,4,9,3,9,1001,9,1,9,4,9,3,9,1001,9,1,9,4,9,3,9,101,1,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,101,2,9,9,4,9,3,9,1002,9,2,9,4,9,3,9,1002,9,2,9,4,9,99,3,9,1001,9,1,9,4,9,3,9,102,2,9,9,4,9,3,9,1001,9,1,9,4,9,3,9,1002,9,2,9,4,9,3,9,1002,9,2,9,4,9,3,9,101,2,9,9,4,9,3,9,1001,9,1,9,4,9,3,9,1002,9,2,9,4,9,3,9,102,2,9,9,4,9,3,9,102,2,9,9,4,9,99")
