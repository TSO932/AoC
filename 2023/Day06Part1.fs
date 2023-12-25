namespace _2023

module Day06Part1 =

    let countWinners (time, distance) =
        seq {0L..time}
        |> Seq.countBy (fun t -> (time - t) * t > distance)
        |> Seq.filter (fun el -> fst el)
        |> Seq.head
        |> snd
