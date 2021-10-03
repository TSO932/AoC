open System.IO
open AoC2015

[<EntryPoint>]
let main argv =

    printfn "Day  1 Part 1: %i" (Day01Part1.getFloor (File.ReadAllLines("../input/Day01/input.txt")))
    printfn "Day  1 Part 2: %i" (Day01Part2.getFirstStepIntoBasement (File.ReadAllLines("../input/Day01/input.txt")))
    printfn "Day  2 Part 1: %i" (Day02Part1.getTotalArea (File.ReadAllLines("../input/Day02/input.txt")))
    printfn "Day  2 Part 1: %i" (Day02Part2.getTotalLength (File.ReadAllLines("../input/Day02/input.txt")))
    printfn "Day  3 Part 1: %i" (Day03Part1.countLuckyHouses (File.ReadAllLines("../input/Day03/input.txt")))
    printfn "Day  3 Part 2: %i" (Day03Part2.countLuckyHouses (File.ReadAllLines("../input/Day03/input.txt")))
    printfn "Day  4 Part 1: %i" (Day04Part1.getAdventCoin (File.ReadAllLines("../input/Day04/input.txt")))
    printfn "Day  4 Part 2: %i" (Day04Part2.getAdventCoin (File.ReadAllLines("../input/Day04/input.txt")))
    printfn "Day  5 Part 1: %i" (Day05Part1.countNiceStrings (File.ReadAllLines("../input/Day05/input.txt")))
    printfn "Day  5 Part 2: %i" (Day05Part2.countNiceStrings (File.ReadAllLines("../input/Day05/input.txt")))
    printfn "Day  6 Part 1: %i" (Day06Part1.followInstructions (File.ReadAllLines("../input/Day06/input.txt")))
    printfn "Day  6 Part 2: %i" (Day06Part2.followInstructions (File.ReadAllLines("../input/Day06/input.txt")))
    printfn "Day  7 Part 1: %i" (Day07Part1.getSignalValueA (File.ReadAllLines("../input/Day07/input.txt")))

    0 // return an integer exit code