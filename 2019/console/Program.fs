open System.IO
open AoC2019

[<EntryPoint>]
let main argv =

    let getInputLine (relativePath) = File.ReadAllLines(relativePath).[0]

    printfn "Day  1 Part 1: %i" (Day01Part1.sumFuel (File.ReadAllLines("../input/Day01/input.txt")))
    printfn "Day  1 Part 2: %i" (Day01Part2.sumFuel (File.ReadAllLines("../input/Day01/input.txt")))

    printfn "Day  2 Part 1: %i" (Day02Part1.getFirstIntCode (getInputLine "../input/Day02/edited.txt"))
    printfn "Day  2 Part 2: %i" (Day02Part2.runProgram (getInputLine "../input/Day02/edited.txt"))

    let input03 = File.ReadAllLines("../input/Day03/input.txt")
    printfn "Day  3 Part 1: %i" (Day03Part1.getIntersection (input03.[0], input03.[1]))
    printfn "Day  3 Part 2: %i" (Day03Part2.getIntersection (input03.[0], input03.[1]))

    printfn "Day  4 Part 1: %i" (Day04Part1.runProgram (getInputLine "../input/Day04/input.txt"))
    printfn "Day  4 Part 2: %i" (Day04Part2.runProgram (getInputLine "../input/Day04/input.txt"))
    
    printfn "Day  5 Part 1: %i" (Day05Part1.runProgram (getInputLine "../input/Day05/input.txt", 1))
    printfn "Day  5 Part 2: %i" (Day05Part2.runProgram (getInputLine "../input/Day05/input.txt", 5))

    printfn "Day  6 Part 1: %i" (Day06Part1.getTotalOrbitCount (File.ReadAllLines("../input/Day06/input.txt")))
    printfn "Day  6 Part 2: %i" (Day06Part2.getShortestTransfer (File.ReadAllLines("../input/Day06/input.txt")))

    printfn "Day  7 Part 1: %i" (Day07Part1.findHighestSignal (getInputLine "../input/Day07/input.txt"))
    printfn "Day  7 Part 2: %i" (Day07Part2.findHighestSignal (getInputLine "../input/Day07/input.txt"))

    printfn "Day  8 Part 1: %i" (Day08Part1.runProgram (getInputLine "../input/Day08/input.txt"))
    printfn "Day  8 Part 2:"
    Day08Part2.runProgram (getInputLine "../input/Day08/input.txt")


    0 // return an integer exit code

