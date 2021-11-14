namespace AoC2015

module Day14Part2 =

    let getWinningPointScore(deer:seq<Day14Part1.Reindeer>, raceTime:int) =

        let getDistancesForAllReindeer(deer:seq<Day14Part1.Reindeer>, raceTime:int) =

            let getDistancesForOneReindeer(deer:Day14Part1.Reindeer, raceTime:int) =
                seq {1..raceTime} |> Seq.map (fun t -> Day14Part1.getDistance (deer, t))

            deer |> Seq.map (fun d -> getDistancesForOneReindeer(d, raceTime))

        let getFurthestDistancesAlongRoute(deer:seq<Day14Part1.Reindeer>, raceTime:int) =

            let getFurthestDistanceAtOneTime(deer:seq<Day14Part1.Reindeer>, splitTime:int) =
                deer |> Seq.map (fun d -> Day14Part1.getDistance (d, splitTime)) |> Seq.max

            seq {1..raceTime} |> Seq.map (fun t -> getFurthestDistanceAtOneTime (deer, t))

        let getPointScoreForOneReindeer(deerDistances:seq<int>, leadingDistances:seq<int>) =
            (deerDistances, leadingDistances) ||> Seq.map2 (fun deerPosn maxPosn -> if deerPosn = maxPosn then 1 else 0) |> Seq.sum

        getDistancesForAllReindeer(deer, raceTime) |> Seq.map (fun d -> getPointScoreForOneReindeer(d, getFurthestDistancesAlongRoute(deer, raceTime))) |> Seq.max

    let getWinningScore(deer:seq<string>) =
        getWinningPointScore(Seq.map Day14Part1.parseReindeerPerformanceStats deer, 2503)