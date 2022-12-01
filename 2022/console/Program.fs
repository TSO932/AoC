open System.IO
open AoC2022

[<EntryPoint>]
let main argv =

    printfn "Day  1 Part 1: %A" (Day01Part1.FindElfCarryingMostCalories (File.ReadAllLines("../input/Day01/input.txt")))
    printfn "Day  1 Part 2: %A" (Day01Part2.FindElvesCarryingMostCalories (File.ReadAllLines("../input/Day01/input.txt")))

    0 // return an integer exit code 