namespace AoC2015

open System.Collections.Generic

module Day03Part1 =


    let moveSleigh (direction:char, house:int*int) =

        match direction with
        | '^' -> (fst house + 1, snd house)
        | 'v' -> (fst house - 1, snd house)
        | '>' -> (fst house    , snd house + 1)
        | '<' -> (fst house    , snd house - 1)
        |  _  -> house

    let mapPositions (directions:string) =

        Seq.toList directions |> Seq.scan (fun h d -> moveSleigh (d, h)) (0, 0)


    let countHouses (directions:string) =

        mapPositions directions |> Seq.countBy id |> Seq.filter (fun x -> snd x > 0) |> Seq.length

    let countLuckyHouses (input:seq<string>) =
    
        input |> Array.ofSeq |> Array.head |> countHouses
