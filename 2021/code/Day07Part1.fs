namespace AoC2021

module Day07Part1 =

    let findMinimum (crabs:seq<int>) =

        seq {Seq.min crabs .. Seq.max crabs} |> Seq.map (fun x -> crabs |> Seq.sumBy (fun c -> if x > c then x - c else c - x)) |> Seq.min

    let run(input:string) = findMinimum(input.Split ',' |> Seq.map int)


    