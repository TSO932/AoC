namespace AoC2015

module Day05Part2 =

    let isValidRule1 (input:string) =
         input |> Seq.mapi (fun i _ -> input.[i..]) |> Seq.exists (fun s -> s.Length > 3 && s.[2..].Contains(s.[0..1]))

    let isValidRule2 (input:string) =
         input |> Seq.windowed 3 |> Seq.exists (fun a -> a.[0] = a.[2])
    
    let isValid (input:string) =
        isValidRule1(input) && isValidRule2(input)

    let countNiceStrings (input:seq<string>) =

        input |> Array.ofSeq |> Seq.filter isValid |> Seq.length