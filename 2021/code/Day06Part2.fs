namespace AoC2021

module Day06Part2 =

    let ageFishes (fish:seq<int*int64>) =

        fish |> Seq.map (fun (day, quantity) -> (Day06Part1.ageFish day |> Seq.map (fun d -> (d, quantity)))) |> Seq.concat
        |> Seq.groupBy fst |> Seq.map (fun (day, quantities) -> (day, (quantities |> Seq.sumBy snd)))
        
    let rec fishTimer (fish:seq<int*int64>, day:int, target:int) =

        if day = target then
            Seq.sumBy snd fish
        else
            fishTimer(ageFishes fish, day + 1, target)

    let countFish (input:string, target:int) = fishTimer(input.Split ',' |> Seq.map int |> Seq.countBy id |> Seq.map (fun (d, q) -> (d, int64 q)), 0, target)

    let run (input:string) = countFish(input, 256)

    