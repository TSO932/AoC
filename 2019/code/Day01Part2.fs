namespace AoC2019

module Day01Part2 = 

    let fuelCalc mass =

        let basicFuelCalc x = max 0 (x / 3 - 2)

        let rec totalFuelCalc x = 
            if x <= 8 then
                x
            else
                x + totalFuelCalc (basicFuelCalc x)

        totalFuelCalc (basicFuelCalc mass)


    let sumFuel (list:seq<string>) =
        list |> Seq.map int |> List.ofSeq |> List.sumBy fuelCalc