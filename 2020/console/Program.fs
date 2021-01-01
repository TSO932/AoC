open System.IO
open AoC2020

[<EntryPoint>]
let main argv =

    // printfn "Day  1 Part 1: %i" (Day01Part1.fixExpenses (File.ReadAllLines("../input/Day01/input.txt")))
    // printfn "Day  1 Part 2: %i" (Day01Part2.fixExpenses (File.ReadAllLines("../input/Day01/input.txt")))

    // printfn "Day  2 Part 1: %i" (Day02Part1.checkPasswords (File.ReadAllLines("../input/Day02/input.txt")))
    // printfn "Day  2 Part 2: %i" (Day02Part2.checkPasswords (File.ReadAllLines("../input/Day02/input.txt")))

    // printfn "Day  3 Part 1: %i" (Day03Part1.countTrees (File.ReadAllLines("../input/Day03/input.txt")))
    // printfn "Day  3 Part 2: %i" (Day03Part2.countTrees (File.ReadAllLines("../input/Day03/input.txt")))

    // printfn "Day  4 Part 1: %i" (Day04Part1.validateCredentials(Day04Part1.formatCredentials (File.ReadAllLines("../input/Day04/input.txt"))))
    // printfn "Day  4 Part 2: %i" (Day04Part2.validateCredentials(Day04Part1.formatCredentials (File.ReadAllLines("../input/Day04/input.txt"))))

    // printfn "Day  5 Part 1: %i" (Day05Part1.findHighestSeatId(File.ReadAllLines("../input/Day05/input.txt")))
    // printfn "Day  5 Part 1: %i" (Day05Part2.findMySeat(File.ReadAllLines("../input/Day05/input.txt")))

    // printfn "Day  6 Part 1: %i" (Day06Part1.countYeses(File.ReadAllLines("../input/Day06/input.txt")))
    // printfn "Day  6 Part 2: %i" (Day06Part2.countYeses(File.ReadAllLines("../input/Day06/input.txt")))

    // printfn "Day  7 Part 1: %i" (Day07Part1.myPrecious(File.ReadAllLines("../input/Day07/input.txt")))
    // printfn "Day  7 Part 2: %i" (Day07Part2.myPrecious(File.ReadAllLines("../input/Day07/input.txt")))

    // printfn "Day  8 Part 1: %i" (Day08Part1.runProgram(File.ReadAllLines("../input/Day08/input.txt")))
    // printfn "Day  8 Part 2: %i" (Day08Part2.fixAndRun(File.ReadAllLines("../input/Day08/input.txt")))

    // printfn "Day  3 Part 1 Elapsed Milliseconds: %f " (PerformanceMeasure.measurePerformance(Day03Part1.countTrees, File.ReadAllLines("../input/Day03/input.txt")))
    // printfn "Day  3 Part 2 Elapsed Milliseconds: %f " (PerformanceMeasure.measurePerformance(Day03Part2.countTrees, File.ReadAllLines("../input/Day03/input.txt")))

    // printfn "Day  9 Part 1: %i" (Day09Part1.findInvalidNumber(File.ReadAllLines("../input/Day09/input.txt")))
    // printfn "Day  9 Part 2: %i" (Day09Part2.findEncryptionWeakness(File.ReadAllLines("../input/Day09/input.txt")))

    // printfn "Day  9 Part 1 Elapsed Milliseconds: %f " (PerformanceMeasure.measurePerformance(Day09Part1.findInvalidNumber, File.ReadAllLines("../input/Day09/input.txt")))
    // printfn "Day  9 Part 2 Elapsed Milliseconds: %f " (PerformanceMeasure.measurePerformance(Day09Part2.findEncryptionWeakness, File.ReadAllLines("../input/Day09/input.txt")))

    // printfn "Day 10 Part 1: %i" (Day10Part1.calculate(File.ReadAllLines("../input/Day10/input.txt")))
    // printfn "Day 10 Part 1: %i" (Day10Part2.calculate(File.ReadAllLines("../input/Day10/input.txt")))

    // printfn "Day 10 Part 2 Elapsed Milliseconds: %f " (PerformanceMeasure.measurePerformance(Day10Part2.calculate, File.ReadAllLines("../input/Day10/input.txt")))

    // printfn "Day 11 Part 1: %i" (Day11Part1.countSeats(File.ReadAllLines("../input/Day11/input.txt")))
    // printfn "Day 11 Part 1: %i" (Day11Part2.countSeats(File.ReadAllLines("../input/Day11/input.txt")))

    // printfn "Day 12 Part 1: %i" (Day12Part1.navigate(File.ReadAllLines("../input/Day12/input.txt")))
    // printfn "Day 12 Part 2: %i" (Day12Part2.navigate(File.ReadAllLines("../input/Day12/input.txt")))

    // printfn "Day 14 Part 1: %i" (Day14Part1.initializeFerryDockingProgram(File.ReadAllLines("../input/Day14/input.txt")))
    // printfn "Day 14 Part 2: %i" (Day14Part2.initializeFerryDockingProgram(File.ReadAllLines("../input/Day14/input.txt")))

    // let startingNumbers = Day15Part1.getStartingNumbers(File.ReadAllLines("../input/Day15/input.txt"))
    // printfn "Day 15 Part 1: %i" (Day15Part1.playMemoryGame(startingNumbers))
    // printfn "Day 15 Part 1: %i" (Day15Part2.playMemoryGame(startingNumbers))
    // printfn "Day 15 Part 2 Elapsed Milliseconds: %f " (PerformanceMeasure.measurePerformance(Day15Part2.playMemoryGame, startingNumbers))
    
    // printfn "Day 17 Part 1: %i" (Day17Part1.countActiveCells(File.ReadAllLines("../input/Day17/input.txt")))
    // printfn "Day 17 Part 2: %i" (Day17Part2.countActiveCells(File.ReadAllLines("../input/Day17/input.txt")))

    printfn "Day 18 Part 1: %i" (Day18Part1.sumValues(File.ReadAllLines("../input/Day18/input.txt")))

    // printfn "Day 20 Part 1: %i" (Day20Part1.findCorners(File.ReadAllLines("../input/Day20/input.txt")))
    // printfn "Day 20 Part 1 Elapsed Milliseconds: %f " (PerformanceMeasure.measurePerformance(Day20Part1.findCorners, File.ReadAllLines("../input/Day20/input.txt")))

    // printfn "Day 22 Part 1: %i" (Day22Part1.playCombat(File.ReadAllLines("../input/Day22/input.txt")))
    // printfn "Day 22 Part 2: %i" (Day22Part2.playCombat(File.ReadAllLines("../input/Day22/input.txt")))

    // printfn "Day 23 Part 1: %A" (Day23Part1.playGame(File.ReadAllLines("../input/Day23/input.txt")))
    // printfn "Day 23 Part 2: %A" (Day23Part2.playGame(File.ReadAllLines("../input/Day23/input.txt")))
    // printfn "Day 23 Part 2 Elapsed Milliseconds: %f " (PerformanceMeasure.measurePerformance(Day23Part2.playGame, File.ReadAllLines("../input/Day23/input.txt")))

    // printfn "Day 24 Part 1: %i" (Day24Part1.countTiles(File.ReadAllLines("../input/Day24/input.txt")))
    // printfn "Day 24 Part 2: %i" (Day24Part2.countTiles(File.ReadAllLines("../input/Day24/input.txt")))

    //printfn "Day 25 Part 1: %i" (Day25Part1.merryChristmas(File.ReadAllLines("../input/Day25/input.txt")))
    0 // return an integer exit code
