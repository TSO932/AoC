namespace AoC2019

module Day04Part2 =

    let isNotDecreasing (input) =
        Day04Part1.isNotDecreasing (input)
    
    let isWinningAtSnap (input) =
        let digits = string input
        Set.ofSeq [0..digits.Length - 2] |> Seq.map (fun i -> digits.[i] = digits.[i + 1]  && (i = 0 || (digits.[i] <> digits.[i - 1])) && (i = digits.Length - 2 || (digits.[i + 1] <> digits.[i + 2])))|> Seq.exists (fun b -> b = true)

    let runProgram (inputString:string) =
        let range = inputString.Split '-' |> Seq.map int |> List.ofSeq
        Set.ofSeq [range.[0]..range.[1]] |> Set.filter (fun x -> isNotDecreasing x) |> Set.filter (fun x -> isWinningAtSnap x) |> Seq.length