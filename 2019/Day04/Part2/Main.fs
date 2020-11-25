let isNotDecreasing (input) =
    let digits = string input
    Set.ofSeq [0..digits.Length - 2] |> Seq.map (fun i -> digits.[i] <= digits.[i + 1]) |> Seq.forall (fun b -> b = true)
    
let isWinningAtSnap (input) =
    let digits = string input
    Set.ofSeq [0..digits.Length - 2] |> Seq.map (fun i -> digits.[i] = digits.[i + 1]  && (i = 0 || (digits.[i] <> digits.[i - 1])) && (i = digits.Length - 2 || (digits.[i + 1] <> digits.[i + 2])))|> Seq.exists (fun b -> b = true)
        
printfn "%b" (isNotDecreasing(11)) //true (equals)
printfn "%b" (isNotDecreasing(12)) //true (greater than)
printfn "%b" (isNotDecreasing(10)) //false (less than)
printfn "%b" (isNotDecreasing(111110))  //final pair is false

printfn "%b" (isWinningAtSnap(11)) //true (snap)
printfn "%b" (isWinningAtSnap(12)) //true (not snap)
printfn "%b" (isWinningAtSnap(123455))  //final pair matches
printfn "%b" (isWinningAtSnap(112233))  //example 1
printfn "%b" (isWinningAtSnap(123444))  //example 2
printfn "%b" (isWinningAtSnap(111122))  //example 3
let range = Set.ofSeq [1..2]  // paste input values over the dummy values using the .. notation for a sequence

printfn "%O" (range |> Set.filter (fun x -> isNotDecreasing x) |> Set.filter (fun x -> isWinningAtSnap x) |> Seq.length)
