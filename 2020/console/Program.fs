open System.IO
open AoC2020

[<EntryPoint>]
let main argv =

    printfn "Day  1 Part 1: %i" (Day01Part1.fixExpenses (File.ReadAllLines("../input/Day01/input.txt")))
    printfn "Day  1 Part 2: %i" (Day01Part2.fixExpenses (File.ReadAllLines("../input/Day01/input.txt")))

    printfn "Day  2 Part 1: %i" (Day02Part1.checkPasswords (File.ReadAllLines("../input/Day02/input.txt")))
    printfn "Day  2 Part 2: %i" (Day02Part2.checkPasswords (File.ReadAllLines("../input/Day02/input.txt")))
    0 // return an integer exit code
