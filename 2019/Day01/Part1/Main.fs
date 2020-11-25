
let fuelCalc x = x / 3 - 2

//Tests
printfn "%i" ([12] |> List.map fuelCalc |> List.sum)

printfn "%i" ([14] |> List.map fuelCalc |> List.sum)

printfn "%i" ([1969] |> List.map fuelCalc |> List.sum)

printfn "%i" ([100756] |> List.map fuelCalc |> List.sum)

//Run (paste input values over the dummy values in the list below)
printfn "%i" ( [
    1
    222
    3
    ]  |> List.map fuelCalc |> List.sum)



