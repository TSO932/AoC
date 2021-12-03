open System.IO
open AoC2021

[<EntryPoint>]
let main argv =

    printfn "Day  1 Part 1: %i" (Day01Part1.countDepthIncreases (File.ReadAllLines("../input/Day01/input.txt")))
    printfn "Day  1 Part 2: %i" (Day01Part2.countDepthIncreases (File.ReadAllLines("../input/Day01/input.txt")))

    printfn "Day  3 Part 1: %A" (Day03Part1.run (File.ReadAllLines("../input/Day03/input.txt")))
    0 // return an integer exit code 