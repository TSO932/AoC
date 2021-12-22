namespace AoC2021

module Day08Part1 =
    let countAppearances(patterns:seq<string>) =
        
        let countSegments(segmentPatterns:seq<string>) =

            let isMatch(segment:string) =
                match segment.Length with
                |2 |3 |4 |7 -> true
                |_          -> false

            segmentPatterns |> Seq.filter isMatch |> Seq.length

        patterns
        |> Seq.map (fun signal -> signal.Split '|') |> Seq.map (fun signal -> signal.[1].Split ' ') 
        |> Seq.sumBy countSegments