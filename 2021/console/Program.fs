open System.IO
open AoC2021

[<EntryPoint>]
let main argv =

    printfn "Day  1 Part 1: %i" (Day01Part1.countDepthIncreases (File.ReadAllLines("../input/Day01/input.txt")))
    printfn "Day  1 Part 2: %i" (Day01Part2.countDepthIncreases (File.ReadAllLines("../input/Day01/input.txt")))

    printfn "Day  3 Part 1: %i" (Day03Part1.run (File.ReadAllLines("../input/Day03/input.txt")))
    printfn "Day  3 Part 2: %i" (Day03Part2.run (File.ReadAllLines("../input/Day03/input.txt")))

    printfn "Day  4 Part 1: %i" (Day04Part1.playBingo (File.ReadAllLines("../input/Day04/input.txt")))
    printfn "Day  4 Part 2: %i" (Day04Part2.playBingo (File.ReadAllLines("../input/Day04/input.txt")))

    printfn "Day  5 Part 1: %i" (Day05Part1.findCrossings (File.ReadAllLines("../input/Day05/input.txt")))
    printfn "Day  5 Part 2: %i" (Day05Part2.findCrossings (File.ReadAllLines("../input/Day05/input.txt")))

    printfn "Day  6 Part 1: %i" (Day06Part1.run (File.ReadAllLines("../input/Day06/input.txt")[0]))
    printfn "Day  6 Part 2: %i" (Day06Part2.run (File.ReadAllLines("../input/Day06/input.txt")[0]))

    printfn "Day  7 Part 1: %i" (Day07Part1.run (File.ReadAllLines("../input/Day07/input.txt")[0]))
    printfn "Day  7 Part 2: %i" (Day07Part2.run (File.ReadAllLines("../input/Day07/input.txt")[0]))

    printfn "Day  8 Part 1: %i" (Day08Part1.countAppearances (File.ReadAllLines("../input/Day08/input.txt")))
    printfn "Day  8 Part 2: %i" (Day08Part2.sumOutputs (File.ReadAllLines("../input/Day08/input.txt")))

    printfn "Day  9 Part 1: %i" (Day09Part1.sumOfLocalMinima (File.ReadAllLines("../input/Day09/input.txt")))
    printfn "Day  9 Part 2: %i" (Day09Part2.productOfBiggestBasins (File.ReadAllLines("../input/Day09/input.txt")))

    printfn "Day 10 Part 1: %i" (Day10Part1.getScore (File.ReadAllLines("../input/Day10/input.txt")))
    printfn "Day 10 Part 2: %i" (Day10Part2.getMedianScore (File.ReadAllLines("../input/Day10/input.txt")))

    printfn "Day 11 Part 1: %i" (Day11Part1.run (File.ReadAllLines("../input/Day11/input.txt")))
    printfn "Day 11 Part 2: %i" (Day11Part2.run (File.ReadAllLines("../input/Day11/input.txt")))

    printfn "Day 12 Part 1: %i" (Day12Part1.run (File.ReadAllLines("../input/Day12/input.txt")))
    // printfn "Day 12 Part 2: %i" (Day12Part2.run (File.ReadAllLines("../input/Day12/input.txt")))
    
    printfn "Day 13 Part 1: %i" (Day13Part1.CountAfterFirstFold (File.ReadAllLines("../input/Day13/input.txt")))

    for line in (Day13Part2.DoAllFolds (File.ReadAllLines("../input/Day13/input.txt"))) do
        printfn "Day 13 Part 2: %s" line 

    printfn "Day 14 Part 1: %i" (Day14Part1.run (File.ReadAllLines("../input/Day14/input.txt")))
    printfn "Day 14 Part 2: %i" (Day14Part2.run (File.ReadAllLines("../input/Day14/input.txt")))

    // printfn "Day 25 Part 1: %i" (Day25Part1.run (File.ReadAllLines("../input/Day25/input.txt")))

    printfn "Day 98 Part 1: %i" (Day98Part1.getSum (File.ReadAllLines("../input/Day98/input.txt")))

    0 // return an integer exit code 
