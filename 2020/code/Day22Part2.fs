namespace AoC2020
open System.Text.RegularExpressions

module Day22Part2 =

    let isDebug = false

    let playCombat (startingDecks:seq<string>) =

        let decks = Day22Part1.readCards(startingDecks)
       
        let rec newPlay(decks:int list array) =
            if isDebug then printfn "NewPlay %A" decks

            let mutable initialDecks = Array.empty
            
            let rec play(decks:int list array) =
                if isDebug then printfn "Play %A" decks

                let playRound (decks:int list array) =
                    
                    let topA = List.head decks.[0]
                    let topB = List.head decks.[1]
                    let deckA = List.tail decks.[0]
                    let deckB = List.tail decks.[1]

                    if topA <= deckA.Length && topB <= deckB.Length then
                        if fst (newPlay( [| deckA.[0..(topA - 1)]; deckB.[0..(topB - 1)] |] )) then
                            [| List.append deckA [topA; topB]; deckB|]
                        else
                            [| deckA; List.append deckB [topB; topA]|]

                    elif topA > topB then
                        [| List.append deckA [topA; topB]; deckB|]
                    else
                        [| deckA; List.append deckB [topB; topA]|]

                if decks.[0].IsEmpty then
                    (false, decks.[1])
                elif decks.[1].IsEmpty then
                    (true, decks.[0])
                elif Array.contains decks initialDecks then
                    if isDebug then printfn "deadlock"
                    (true, decks.[0])
                else
                    initialDecks <- Array.append initialDecks [| decks |]       
                    play(playRound(decks))

            play(decks)

        Day22Part1.scoreDeck (snd (newPlay(decks)) )        