namespace AoC2021

module Day05Part2 =

    let findCrossings(input:seq<string>) =
        input |> Seq.map Day05Part1.Line |> Seq.fold (fun grid line -> Day05Part1.applyLine(grid, line.X1, line.Y1, line.X2, line.Y2, true)) (Array2D.zeroCreate 1000 1000) |> Day05Part1.countPointsWithNOrMore