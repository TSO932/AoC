namespace AoC2019

module Day01Part1 = 
    let fuelCalc x  = x / 3 - 2

    let sumFuel (list:seq<string>) =
        list |> Seq.map int |> List.ofSeq |> List.sumBy fuelCalc
        