
let basicFuelCalc x = max 0 (x / 3 - 2)

let fuelCalc x =
    let mutable allFuel = 0
    let mutable newFuel = basicFuelCalc x
    allFuel <- allFuel + newFuel
    
    while newFuel > 8 do
        newFuel <- basicFuelCalc newFuel
        allFuel <- allFuel + newFuel
    
    allFuel 
        
//Tests

printfn "%i" ([1] |> List.map fuelCalc |> List.sum)  // avoid negative fuel
printfn "%i" ([8] |> List.map fuelCalc |> List.sum)  // largest amound of fuel which requires no more
printfn "%i" ([9] |> List.map fuelCalc |> List.sum)  // smallest amount of fuel wich requirs extra

printfn "%i" ([14] |> List.map fuelCalc |> List.sum)  // example 1

printfn "%i" ([1969] |> List.map fuelCalc |> List.sum) // example 2

printfn "%i" ([100756] |> List.map fuelCalc |> List.sum) // example 3

//Run (paste input values over the dummy values in the list below)
printfn "%i" ( [
    1
    222
    3
    ]  |> List.map fuelCalc |> List.sum)
