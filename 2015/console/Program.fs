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
    printfn "Day  7 Part 2: %i" (Day07Part2.getSignalValueA (File.ReadAllLines("../input/Day07/input.txt")))
    // printfn "Day  7 Part 1: %i" (Day07Part1.getSignalValueA (File.ReadAllLines("../Code/aoC/2015/input/Day07/input.txt")))
    printfn "Day  8 Part 1: %i" (Day08Part1.countCharacters (File.ReadAllLines("../input/Day08/input.txt")))
    printfn "Day  8 Part 2: %i" (Day08Part2.countCharacters (File.ReadAllLines("../input/Day08/input.txt")))
    printfn "Day  9 Part 1: %i" (Day09Part1.findShortestDistance (File.ReadAllLines("../input/Day09/input.txt")))
    printfn "Day  9 Part 2: %i" (Day09Part2.findLongestDistance (File.ReadAllLines("../input/Day09/input.txt")))
    printfn "Day 10 Part 1: %i" (Day10Part1.lookAndSayRepeat (40, File.ReadAllLines("../input/Day10/input.txt").[0]))
    printfn "Day 10 Part 2: %i" (Day10Part1.lookAndSayRepeat (50, File.ReadAllLines("../input/Day10/input.txt").[0]))
    //printfn "Day 10 Part 1 Elapsed Milliseconds: %f " (PerformanceMeasure.measurePerformance(Day10Part1.lookAndSayRepeat, (25, File.ReadAllLines("../input/Day10/input.txt").[0])))

    0 // return an integer exit code