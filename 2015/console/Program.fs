open System.IO
open AoC2015

[<EntryPoint>]
let main argv =

    printfn "Day 1 Part 1: %i" (Day01Part1.getFloor (File.ReadAllLines("../input/Day01/input.txt")))
    printfn "Day 1 Part 2: %i" (Day01Part2.getFirstStepIntoBasement (File.ReadAllLines("../input/Day01/input.txt")))

    0 // return an integer exit code