namespace AoC2020

module Day10Part1 =
    let calculate (adapters:seq<string>) =

        let chain = adapters |> Seq.map int |> Seq.sort |> Seq.append (seq {0}) |> Seq.windowed 2 |> Seq.groupBy (fun x -> x.[1] - x.[0])
        
        let count(i:int) = chain |> Seq.filter (fun x -> fst x = i) |> Seq.map snd |> Seq.exactlyOne |> Seq.length
        
        count(1) * (1 + count(3))