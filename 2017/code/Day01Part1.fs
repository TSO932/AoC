namespace AoC2017

module Day01Part1 =
    let solveCaptha (input:string) =

        input
            |> Seq.pairwise
            |> Seq.append [(input[input.Length - 1], input[0])]
            |> Seq.filter (fun (a, b) -> a = b)
            |> Seq.sumBy (fun (c, _) -> int (c.ToString()))