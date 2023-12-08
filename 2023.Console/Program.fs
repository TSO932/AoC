open System.IO
open _2023

printfn "Day  1 Part 1: %A" (Day01Part1.calibrate (File.ReadAllLines("../2023.Input/Day01/input.txt")))
printfn "Day  1 Part 2: %A" (Day01Part2.calibrate (File.ReadAllLines("../2023.Input/Day01/input.txt")))
printfn "Day  2 Part 1: %A" (Day02Part1.gameSum (File.ReadAllLines("../2023.Input/Day02/input.txt")))
printfn "Day  2 Part 2: %A" (Day02Part2.cubePowers (File.ReadAllLines("../2023.Input/Day02/input.txt")))
printfn "Day  4 Part 1: %A" (Day04Part1.getSum (File.ReadAllLines("../2023.Input/Day04/input.txt")))
printfn "Day  4 Part 2: %A" (Day04Part2.getSum (File.ReadAllLines("../2023.Input/Day04/input.txt")))
printfn "Day  7 Part 1: %A" (Day07Part1.rankHands (File.ReadAllLines("../2023.Input/Day07/input.txt")))
printfn "Day  7 Part 2: %A" (Day07Part2.rankHands (File.ReadAllLines("../2023.Input/Day07/input.txt")))
printfn "Day  8 Part 1: %A" (Day08Part1.countSteps (File.ReadAllLines("../2023.Input/Day08/input.txt")))
printfn "Day  8 Part 2: %A" (Day08Part2.countSteps (File.ReadAllLines("../2023.Input/Day08/input.txt")))  //18727 too low