﻿namespace _2023

module Day05Part1 =
    let mapValueSingle (fromValue, destinationRangeStart, sourceRangeStart, rangeLength) =
        if fromValue >= sourceRangeStart && fromValue <= sourceRangeStart + rangeLength then
            fromValue - sourceRangeStart + destinationRangeStart
        else
            fromValue
    let mapValueAll (fromValue, mapping:seq<int[]>) =
        mapping
        |> Seq.map (fun m -> mapValueSingle (fromValue, m[0], m[1], m[2]))
        |> Seq.filter ((<>) fromValue)
        |> fun x -> if Seq.isEmpty x then fromValue else Seq.head x
       
    let parseMapLine(line:string) =
        line.Split ' '
        |> Seq.map int
        |> Seq.toArray

    let getNextValue(fromValue, input:seq<string>) =
        mapValueAll (fromValue, Seq.map parseMapLine input  )
