namespace _2023

module Day05Part2 =
    let getSeeds (input) =
        input
        |> Seq.map (fun (start, length) -> seq{start .. (start + length - 1L)})
        |> Seq.concat

    let findLowestLocation(seedInput, maps) =
        Day05Part1.findLowestLocation (getSeeds(seedInput), maps)