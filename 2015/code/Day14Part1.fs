namespace AoC2015

module Day14Part1 =

    type Reindeer =
       {  Speed:int
          Duration:int
          Rest:int }

    let parseReindeerPerformanceStats(deer:string) =
        let splits = deer.Split [|' '|]
        { Speed = int splits[3]; Duration = int splits[6]; Rest = int splits[13] }

    let getDistance(deer:Reindeer, time:int) =
        ((time / (deer.Duration + deer.Rest)) * deer.Duration + min deer.Duration (time % (deer.Duration + deer.Rest))) * deer.Speed
    
    let getWinningDistance(deer:seq<string>) =
        deer |> Seq.map parseReindeerPerformanceStats |> Seq.map (fun d -> getDistance (d, 2503)) |> Seq.max
 
               