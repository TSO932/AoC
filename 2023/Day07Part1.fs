namespace _2023

open System

module Day07Part1 =

    let getLabelScore (label:char) =
        match label with
        | 'A' -> 13
        | 'K' -> 12
        | 'Q' -> 11
        | 'J' -> 10
        | 'T' -> 9
        | _ -> int label - 49

    let getLabelScoresForHand (hand:string) = 
        hand
        |> Seq.map getLabelScore
        |> Seq.toArray
        |> fun a -> a[0] * 38416 + a[1] * 2744 + a[2] * 196 + a[3] * 14 + a[4]


    let getType (hand:string) =

        let sorted = hand
                        |> Seq.countBy id
                        |> Seq.map snd
                        |> Seq.sort
                        |> String.Concat

        match sorted with
            | "5" -> 3226944
            | "14" -> 2689120
            | "23" -> 2151296  
            | "113" -> 1613472
            | "122" -> 1075648
            | "1112" -> 537824
            | _ -> 0

    let getPreScore (hand:string) =
        getType(hand) + getLabelScoresForHand(hand)

    let rankHands (hands:seq<string>) =
        hands
        |> Seq.map (fun h -> (h[..4], int h[6..]))
        |> Seq.sortBy (fun hand -> getPreScore(fst hand))
        |> Seq.mapi (fun i hand -> (i + 1) * snd hand)
        |> Seq.sum
