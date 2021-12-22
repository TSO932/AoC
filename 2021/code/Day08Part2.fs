namespace AoC2021

open System

module Day08Part2 =
        
    let getDecoder(signalPatterns:string) =

        let signals = signalPatterns.Split ' ' |> Seq.map (fun n -> n |> Seq.sort |> String.Concat ) |> Seq.filter ((<>) "|")

        let eight = signals |> Seq.filter (fun pattern -> pattern.Length = 7) |> Seq.head
        let seven = signals |> Seq.filter (fun pattern -> pattern.Length = 3) |> Seq.head
        let four  = signals |> Seq.filter (fun pattern -> pattern.Length = 4) |> Seq.head
        let one   = signals |> Seq.filter (fun pattern -> pattern.Length = 2) |> Seq.head

        let removeOneSegments(pattern:string) =
            pattern, pattern |> Seq.filter (fun c -> not (c = one[0] || c = one[1])) |> Seq.length

        let three =  signals |> Seq.map removeOneSegments |> Seq.filter (fun (_, le) -> le = 3) |> Seq.head |> fst

        let leftOvers = signals |> Seq.filter (fun s -> not (s = one || s = four || s = three || s = seven || s = eight))

        let length5s = leftOvers |> Seq.filter (fun s -> s.Length = 5)
        let length6s = leftOvers |> Seq.filter (fun s -> s.Length = 6)

        let removeFourSegments(pattern:string) =
            pattern, pattern |> Seq.filter (fun c -> not (c = four[0] || c = four[1] || c = four[2] || c = four[3])) |> Seq.length

        let two  = length5s |> Seq.map removeFourSegments |> Seq.filter (fun (_, le) -> le = 3) |> Seq.head |> fst
        let five = length5s |> Seq.map removeFourSegments |> Seq.filter (fun (_, le) -> le = 2) |> Seq.head |> fst
        let nine = length6s |> Seq.map removeFourSegments |> Seq.filter (fun (_, le) -> le = 2) |> Seq.head |> fst

        let removeFiveSegments(pattern:string) =
            pattern, pattern |> Seq.filter (fun c -> not (c = five[0] || c = five[1] || c = five[2] || c = five[3] || c = five[4])) |> Seq.length

        let stillLeft = leftOvers |> Seq.filter (fun s -> not (s = two || s = five || s = nine))

        let zero = stillLeft |> Seq.map removeFiveSegments  |> Seq.filter (fun (_, le) -> le = 2) |> Seq.head |> fst
        let six  = stillLeft |> Seq.map removeFiveSegments  |> Seq.filter (fun (_, le) -> le = 1) |> Seq.head |> fst

        Map [ (zero, 0); (one, 1); (two, 2); (three, 3); (four, 4); (five, 5); (six, 6); (seven, 7); (eight, 8); (nine, 9) ]

    let getOutputValue(input:string) =

        let decoder = getDecoder(input)

        let rec displayReader(output:int, input:seq<int>) =
            if Seq.length input < 1 then
                output
            else
                displayReader(output * 10 + Seq.head input, Seq.tail input)

        let leftRight = input.Split '|'
        let digits = leftRight[1].Split ' ' |> Seq.filter (fun s -> s.Length > 0) |> Seq.map (fun s -> decoder[(s |> Seq.sort |> String.Concat)])
        displayReader(0, digits)

    let sumOutputs(input:seq<string>) = input |> Seq.map getOutputValue |> Seq.sum