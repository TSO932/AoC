open System.IO
open AoC2017

[<EntryPoint>]
let main argv =

    printfn "Day  1 Part 1: %i" (Day01Part1.solveCaptha (File.ReadAllLines("../input/Day01/input.txt")[0]))
    printfn "Day  1 Part 2: %i" (Day01Part2.solveCaptha (File.ReadAllLines("../input/Day01/input.txt")[0]))
    printfn "Day  2 Part 1: %i" (Day02Part1.checkSum (File.ReadAllLines("../input/Day02/input.txt")))
    printfn "Day  2 Part 2: %i" (Day02Part2.getSum (File.ReadAllLines("../input/Day02/input.txt")))
    printfn "Day  3 Part 1: %i" (Day03Part1.getDistance (File.ReadAllLines("../input/Day03/input.txt")))
    printfn "Day  3 Part 2: %i" (Day03Part2.getValue (File.ReadAllLines("../input/Day03/input.txt")))

    0 // return an integer exit code 