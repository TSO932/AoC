namespace AoC2017

module Day01Part2 =
    let solveCaptha (input:string) =

        let left = input[ .. ((input.Length / 2) - 1)]
        let right = input[(input.Length / 2) .. ]

        (left, right)
            ||> Seq.zip
            |> Seq.filter (fun (a, b) -> a = b)
            |> Seq.sumBy (fun (c, _) -> 2 * int (c.ToString()))
