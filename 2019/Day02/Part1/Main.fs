let runProgram (inputString:string) =
    let intcode = inputString.Split ',' |> Array.map System.Int32.Parse

    let mutable index = 0

    while intcode.[index] <> 99 do
        if intcode.[index] = 1 then
            intcode.[intcode.[index + 3]] <- intcode.[intcode.[index + 1]] + intcode.[intcode.[index + 2]]
        elif intcode.[index] = 2 then
            intcode.[intcode.[index + 3]] <- intcode.[intcode.[index + 1]] * intcode.[intcode.[index + 2]]

        index <- index + 4
        
    printfn "%A" (intcode)

runProgram("1,9,10,3,2,3,11,0,99,30,40,50")
runProgram("1,0,0,0,99")
runProgram("2,3,0,3,99")
runProgram("2,4,4,5,99,0")
runProgram("1,1,1,4,99,5,6,0,99")
runProgram("99,99,99") // paste input values over the dummy values in the string
