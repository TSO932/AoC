let isNotDecreasing (input) =
    let digits = string input
    Set.ofSeq [0..digits.Length - 2] |> Seq.map (fun i -> digits.[i] <= digits.[i + 1]) |> Seq.forall (fun b -> b = true)
    
let isWinningAtSnap (input) =
    let digits = string input
    Set.ofSeq [0..digits.Length - 2] |> Seq.map (fun i -> digits.[i] = digits.[i + 1]) |> Seq.exists (fun b -> b = true)
        
printfn "%b" (isNotDecreasing(11)) //true (equals)
printfn "%b" (isNotDecreasing(12)) //true (greater than)
printfn "%b" (isNotDecreasing(10)) //false (less than)
printfn "%b" (isNotDecreasing(111110))  //final pair is false

printfn "%b" (isWinningAtSnap(11)) //true (snap)
printfn "%b" (isWinningAtSnap(12)) //true (not snap)
printfn "%b" (isWinningAtSnap(123455))  //final pair matches

let range = Set.ofSeq [136818..685979]

printfn "%O" (range |> Set.filter (fun x -> isNotDecreasing x) |> Set.filter (fun x -> isWinningAtSnap x) |> Seq.length)
