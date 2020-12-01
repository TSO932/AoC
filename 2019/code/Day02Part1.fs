namespace AoC2019

module Day02Part1 =
    let runProgram (inputString:string) =
        let intcode = inputString.Split ',' |> Array.map System.Int32.Parse

        let mutable index = 0

        while intcode.[index] <> 99 do
            if intcode.[index] = 1 then
                intcode.[intcode.[index + 3]] <- intcode.[intcode.[index + 1]] + intcode.[intcode.[index + 2]]
            elif intcode.[index] = 2 then
                intcode.[intcode.[index + 3]] <- intcode.[intcode.[index + 1]] * intcode.[intcode.[index + 2]]

            index <- index + 4
        
        intcode

    let getFirstIntCode inputString =
        (runProgram inputString).[0] 