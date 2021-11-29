namespace AoC2015

module Day21Part2 =

  let findDearestLosingOption() =
    Day21Part1.getOptions() |> Seq.filter (fun p -> not (Day21Part1.fight(p, Day21Part1.Stats(0, 8, 2, 109)))) |> Seq.map (fun p -> p.Cost) |> Seq.max
