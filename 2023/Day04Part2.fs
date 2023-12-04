namespace _2023

open System.Collections.Generic

module Day04Part2 =

    let getNewCards (input:string) =
 
        let numbers =
            input[5..].Split [|':'; '|'|]
            |> Seq.map (fun s -> s.Split ' ')
            |> Seq.map (fun q -> Seq.filter ((<>) "") q)
            |> Seq.toArray

        let cardNumber =
            numbers[0]
            |> Seq.head
            |> int

        numbers[1]
        |> Seq.filter (fun n1 -> numbers[2] |> Seq.exists (fun n2 -> n1 = n2))
        |> Seq.length
        |> (fun n -> (cardNumber, seq { cardNumber + 1 .. cardNumber + n}))

    let getSum (input:seq<string>) =
        
        let cardMap =
            input
            |> Seq.map getNewCards
            |> Map

        let startingCards = Seq.length input

        let cardCounts = new Dictionary<int, int>()
        seq {1 .. Seq.length input}
        |> Seq.iter (fun c -> cardCounts.Add (c, 1))

        let play (cardNumber) =
            let updateCount (playedCard, wonCard) =
                let count = cardCounts[wonCard] + cardCounts[playedCard]
                cardCounts.Remove (wonCard) |> ignore
                cardCounts.Add (wonCard, count)

            cardMap[cardNumber] |> Seq.iter (fun c -> updateCount (cardNumber, c))
                
        seq {1 .. startingCards}
        |> Seq.iter play

        seq {1 .. startingCards}
        |> Seq.sumBy (fun c -> cardCounts[c])
        
