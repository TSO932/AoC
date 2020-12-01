namespace AoC2019

module Day04Part1 =

    let isNotDecreasing (input) =
        let digits = string input
        Set.ofSeq [0..digits.Length - 2] |> Seq.map (fun i -> digits.[i] <= digits.[i + 1]) |> Seq.forall (fun b -> b = true)
    
    let isWinningAtSnap (input) =
        let digits = string input
        Set.ofSeq [0..digits.Length - 2] |> Seq.map (fun i -> digits.[i] = digits.[i + 1]) |> Seq.exists (fun b -> b = true)
        
    let runProgram (inputString:string) =
        let range = inputString.Split '-' |> Seq.map int |> List.ofSeq
        Set.ofSeq [range.[0]..range.[1]] |> Set.filter (fun x -> isNotDecreasing x) |> Set.filter (fun x -> isWinningAtSnap x) |> Seq.length