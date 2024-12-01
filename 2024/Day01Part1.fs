namespace _2024

open System

module Day01Part1 =
    let run (input: seq<string>) =
        
        let parseLine(inputLine:string) =
            let splits =  inputLine.Split ([|' '|], StringSplitOptions.RemoveEmptyEntries)
            splits[0], splits[1]

        let columns =
            input
            |> Seq.map parseLine

        let sortNumbers (f) =
            columns
            |> Seq.map (f >> Int32.Parse)
            |> Seq.sort

        let columnA = sortNumbers fst
        let columnB = sortNumbers snd

        (columnA, columnB)
        ||> Seq.zip
        |> Seq.map (fun t -> abs (fst t - snd t))
        |> Seq.sum
