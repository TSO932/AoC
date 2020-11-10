
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

//Run
printfn "%i" ( [
    132897
    131436
    107839
    98498
    141198
    147530
    65491
    142162
    89575
    95090
    147097
    129782
    144858
    68745
    102201
    103225
    113363
    111744
    91402
    72832
    122801
    121257
    52343
    73228
    92718
    147235
    88278
    86305
    75761
    63778
    60566
    125207
    65341
    72035
    117227
    101003
    91830
    121549
    116387
    62337
    124495
    76900
    149440
    94380
    72932
    74131
    147816
    137870
    135540
    99187
    78513
    81784
    77323
    122089
    126365
    148263
    71299
    56483
    100098
    118856
    101395
    106244
    129590
    104179
    76867
    57756
    83790
    80722
    133943
    78243
    92963
    69222
    117193
    63871
    111459
    107930
    116514
    124433
    84165
    144701
    144033
    99114
    52861
    86496
    134584
    126356
    149743
    70192
    142814
    73271
    111543
    60035
    146067
    100679
    116636
    104316
    84510
    59851
    101893
    55611
    ]  |> List.map fuelCalc |> List.sum)
