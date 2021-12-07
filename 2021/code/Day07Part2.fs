namespace AoC2021

module Day07Part2 =

    let rec sumFormula(i:int64) =
        if i <= 1 then
            i
        else
            i + sumFormula(i - 1L)

    let findMinimum (crabs:seq<int64>) =

        seq {Seq.min crabs .. Seq.max crabs} |> Seq.map (fun x -> crabs |> Seq.sumBy (fun c -> sumFormula(abs (c - x)))) |> Seq.min

    let run(input:string) = findMinimum(input.Split ',' |> Seq.map int64)



    