open System.IO
open _2023

printfn "Day  1 Part 1: %A" (Day01Part1.calibrate (File.ReadAllLines("../2023.Input/Day01/input.txt")))
printfn "Day  1 Part 2: %A" (Day01Part2.calibrate (File.ReadAllLines("../2023.Input/Day01/input.txt")))
printfn "Day  2 Part 1: %A" (Day02Part1.gameSum (File.ReadAllLines("../2023.Input/Day02/input.txt")))
printfn "Day  2 Part 2: %A" (Day02Part2.cubePowers (File.ReadAllLines("../2023.Input/Day02/input.txt")))