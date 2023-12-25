namespace _2023

module Day05Part3 =

    let getTransitionPoint(mapEntry:int64[]) =
        seq {mapEntry[1]; mapEntry[1] + mapEntry[2]}

    let getTransitionPoints (mapping:seq<int64[]>) =
        mapping
        |> Seq.map getTransitionPoint
        |> Seq.concat
        |> Seq.distinct
        |> Seq.sort

    let mapBackSingle (toValue, destinationRangeStart, sourceRangeStart, rangeLength) =
        // used in reverse
        Day05Part1.mapValueSingle (toValue, sourceRangeStart, destinationRangeStart, rangeLength)

    let mapBackAll (toValue, mapping:seq<int64[]>) =
        mapping
        |> Seq.map (fun m -> mapBackSingle (toValue, m[0], m[1], m[2]))
        |> Seq.filter ((<>) toValue)
        |> fun x -> if Seq.isEmpty x then toValue else Seq.head x

    let backOneLevel(transitionPoints:seq<int64>, mapping:seq<int64[]>) =

        //map existing transition points back from destination to source
        let existing =
            transitionPoints
            |> Seq.map (fun p -> mapBackAll(p, mapping))

        //get new transition points for this level
        let newPoints = getTransitionPoints(mapping)

        Seq.append newPoints existing
        |> Seq.distinct
        |> Seq.sort

    let backAllLevels(input:seq<seq<string>>) =
        input
        |> Seq.rev
        |> Seq.map (fun line -> Seq.map Day05Part1.parseMapLine line)
        |> Seq.fold (fun acc map -> backOneLevel (acc, map)) Seq.empty

    let getSeedsToCheck (seeds, transitionPoints) =
        seeds
        |> Seq.map (fun (start, length) -> transitionPoints |> Seq.filter (fun tp -> tp >= start && tp <= start + length - 1L))
        |> Seq.concat
        |> Seq.append (seeds |> Seq.map fst)
        |> Seq.distinct
        |> Seq.sort
        
    let findLowestLocation(seedInput, maps) =
        let backMap = backAllLevels maps
        let seedsToCheck = getSeedsToCheck (seedInput, backMap)

        // printfn "backMap %A" backMap
        // printfn "seedsToCheck %A" seedsToCheck
        // printfn "seedInput %A" seedInput

        // seedsToCheck
        // |> Seq.map (fun seed -> (seed, Day05Part1.mapSeedToLocation(seed, maps)))
        // |> Seq.filter (fun (_, d) -> d = 61994329L)
        // |> fun q -> printfn "61994329L: %A" q

        // backMap
        // |> Seq.map (fun seed -> (seed, Day05Part1.mapSeedToLocation(seed, maps)))
        // |> Seq.filter (fun (_, d) -> d = 15880236L)
        // |> fun q -> printfn "15880236L: %A" q



        Day05Part1.findLowestLocation (seedsToCheck, maps)

        

