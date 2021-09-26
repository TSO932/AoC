namespace AoC2015

open System.Collections.Generic

module Day03Part2 =


    let moveSleigh (direction:char, house:int*int) =

        match direction with
        | '^' -> (fst house + 1, snd house)
        | 'v' -> (fst house - 1, snd house)
        | '>' -> (fst house    , snd house + 1)
        | '<' -> (fst house    , snd house - 1)
        |  _  -> house

    let mapPositions (directions) =

        directions |> Seq.scan (fun h d -> moveSleigh (d, h)) (0, 0)

    let mapPositionsOfTwoSantas (directions:string) =

        let directionPairs = directions |> Seq.pairwise |> Seq.mapi (fun i x -> i%2=0, x) |> Seq.filter fst |> Seq.map snd

        let directionsForOne (turn) = 
            Seq.map turn directionPairs |> mapPositions

        Seq.append (directionsForOne fst) (directionsForOne snd)
        
    let countHouses (directions:string) =

        mapPositionsOfTwoSantas directions |> Seq.countBy id |> Seq.filter (fun x -> snd x > 0) |> Seq.length

    let countLuckyHouses (input:seq<string>) =
    
        input |> Array.ofSeq |> Array.head |> countHouses
