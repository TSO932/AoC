namespace AoC2022

module Day01Part1 =
    let FindElfCarryingMostCalories (input:seq<string>) =
        input
            |> Seq.scan (fun accum entry -> if entry = "" then (fst accum + 1, 0) else (fst accum, int entry)) (0, 0)
            |> Seq.groupBy fst
            |> Seq.map (fun (_, s) -> s |> Seq.sumBy snd ) 
            |> Seq.max