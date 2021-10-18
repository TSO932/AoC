namespace AoC2015

module Day10Part1 =

    let rec lookAndSayLoop(say:string, look:string) =

        let charList = look |> Array.ofSeq |> Seq.pairwise |> Seq.map (fun (a,b) -> (a = b, b)) |> Seq.append [|(true, look.[0])|] |> List.ofSeq
        let remaining = Seq.skipWhile (fun (b, _) -> b) charList
        let newSay = say + string (Seq.length charList - Seq.length remaining) + string (snd (Seq.head charList))

        if Seq.isEmpty remaining then
            newSay
        else
            let newLook = look.[(Seq.length look - Seq.length remaining)..]
            lookAndSayLoop(newSay, newLook)

    let lookAndSay(look:string) = lookAndSayLoop("", look)

    let lookAndSayRepeat(repeats:int, look:string) =
        let mutable say = look
        for i in 1 .. repeats do
            say <- lookAndSay(say)
            printfn "%i %i" i (say.Length)
        say.Length
