namespace _2024

open System

module Day01Part2 =
    let run (input: seq<string>) =
        
        let parseLine(inputLine:string) =
            let splits =  inputLine.Split ([|' '|], StringSplitOptions.RemoveEmptyEntries)
            splits[0], splits[1]

        let columns =
            input
            |> Seq.map parseLine

        let columnA =
            columns
            |> Seq.map fst
            |> Seq.map Int32.Parse

        let columnB =
            columns
            |> Seq.map snd
            |> Seq.map Int32.Parse

        let countMatches (nums:seq<int>, i:int) =
            nums
            |> Seq.filter ((=) i)
            |> Seq.length
            
        columnA
        |> Seq.map (fun i -> i * countMatches(columnB, i) )
        |> Seq.sum
