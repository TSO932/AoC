namespace AoC2019

module Day08Part1 =
    let runProgram(code:string) =
        let calc(char, layer) = layer |> Seq.where (fun t -> fst t = char) |> Seq.head |> snd
        code |> Seq.chunkBySize (25 * 6) |> Seq.sortBy (fun a -> (a |> Seq.filter (fun c -> c ='0') |> Seq.length)) |> Seq.head |> Seq.countBy (fun c -> c) |> (fun a -> calc('1',a) * calc('2',a))
