open System.IO
open AoC2022

[<EntryPoint>]
let main argv =

    printfn "Day  1 Part 1: %A" (Day01Part1.FindElfCarryingMostCalories (File.ReadAllLines("../input/Day01/input.txt")))
    printfn "Day  1 Part 2: %A" (Day01Part2.FindElvesCarryingMostCalories (File.ReadAllLines("../input/Day01/input.txt")))
    printfn "Day  2 Part 1: %A" (Day02Part1.GetTotal (File.ReadAllLines("../input/Day02/input.txt")))
    printfn "Day  2 Part 2: %A" (Day02Part2.GetTotal (File.ReadAllLines("../input/Day02/input.txt")))
    printfn "Day  3 Part 1: %A" (Day03Part1.GetSumOfPriorities (File.ReadAllLines("../input/Day03/input.txt")))
    printfn "Day  3 Part 2: %A" (Day03Part2.GetSumOfPriorities (File.ReadAllLines("../input/Day03/input.txt")))
    printfn "Day  4 Part 1: %A" (Day04Part1.GetNumberOfPairsWhereOneRangeFullyContainsTheOther (File.ReadAllLines("../input/Day04/input.txt")))
    printfn "Day  6 Part 1: %A" (Day06Part1.FindPosition (File.ReadAllLines("../input/Day06/input.txt")[0]))
    printfn "Day  6 Part 2: %A" (Day06Part2.FindPosition (File.ReadAllLines("../input/Day06/input.txt")[0]))
    printfn "Day  7 Part 1: %A" (Day07Part1.runProgram (File.ReadAllLines("../input/Day07/input.txt")))
    printfn "Day  7 Part 2: %A" (Day07Part2.runProgram (File.ReadAllLines("../input/Day07/input.txt")))
    printfn "Day  8 Part 1: %A" (Day08Part1.countVisibleTrees (File.ReadAllLines("../input/Day08/input.txt")))

    printfn "Day 15 Part 1: %A" (Day15Part1.GetOverlaps (File.ReadAllLines("../input/Day15/input.txt")))

    0 // return an integer exit code 