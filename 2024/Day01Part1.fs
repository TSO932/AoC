namespace _2024

open System

module Day01Part1 =
    let run (input: seq<string>) =
        
        let parseLine(inputLine:string) =
            let splits =  inputLine.Split ([|' '|], System.StringSplitOptions.RemoveEmptyEntries)
            splits[0], splits[1]

        let columns =
            input
            |> Seq.map parseLine

        let columnA =
            columns
            |> Seq.map fst
            |> Seq.map Int32.Parse
            |> Seq.sort

        let columnB =
            columns
            |> Seq.map snd
            |> Seq.map Int32.Parse
            |> Seq.sort

        (columnA, columnB)
        ||> Seq.zip
        |> Seq.map (fun t -> abs (fst t - snd t))
        |> Seq.sum
