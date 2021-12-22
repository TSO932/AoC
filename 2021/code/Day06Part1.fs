namespace AoC2021

module Day06Part1 =

    let ageFish (fish:int) =

        if fish = 0 then
            [6; 8]
        else
            [fish - 1]

    let ageFishes (fish:seq<int>) = fish |> Seq.map ageFish |> Seq.concat

    let rec fishTimer (fish:seq<int>, day:int, target:int) =

        if day = target then
            Seq.length fish
        else
            fishTimer(ageFishes fish, day + 1, target)

    let countFish (input:string, target:int) = fishTimer(input.Split ',' |> Seq.map int, 0, target)

    let run (input:string) = countFish(input, 80)

    