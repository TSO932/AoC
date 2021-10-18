namespace AoC2015

open System

module Day10Part1 =

    let rec lookAndSayLoop(say:list<sbyte>, look:list<sbyte>) =

        let remaining = match List.tryFindIndex ((<>) look.Head) look.Tail with
                         | Some index -> look.[index + 1..]
                         | None       -> List.Empty

        let newSay = List.append say [sbyte (List.length look - List.length remaining); List.head look]

        if Seq.isEmpty remaining then
            newSay
        else
            let newLook = look.[(Seq.length look - Seq.length remaining)..]
            lookAndSayLoop(newSay, newLook)

    let lookAndSay(look:list<sbyte>) = lookAndSayLoop([], look)

    let lookAndSayRepeat(repeats:int, look:string) =
        let mutable say = look |> List.ofSeq |> List.map (Char.GetNumericValue >> sbyte)
        for i in 1 .. repeats do
            say <- lookAndSay(say)
            printfn "%i %i" i (say.Length)
        say.Length
