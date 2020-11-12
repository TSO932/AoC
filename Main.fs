let intcode = "1,9,10,3,2,3,11,0,99,30,40,50".Split ',' |> Array.map System.Int32.Parse

let intcode = inputString.Split ',' |> Array.map System.Int32.Parse

let mutable index = 0

while intcode.[index] <> 99 do
    if intcode.[index] = 1 then
        intcode.[index + 3] <- intcode.[intcode.[index + 1]] + intcode.[intcode.[index + 2]]
    elif intcode.[index] = 2 then
        intcode.[index + 3] <- intcode.[intcode.[index + 1]] * intcode.[intcode.[index + 2]]

    printfn "%A" (intcode)

    index <- index + 4
