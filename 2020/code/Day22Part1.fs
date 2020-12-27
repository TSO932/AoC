namespace AoC2020
open System.Text.RegularExpressions

module Day22Part1 =

    let readCards (startingDecks:seq<string>) =
        let numberCards = startingDecks |> Seq.filter (fun x -> Regex.IsMatch (x, @"^[1-9][0-9]*$")) |> Seq.map int |> List.ofSeq
        numberCards |> List.chunkBySize (numberCards.Length / 2) |> Array.ofList

    let playRound (decks:int list array) = 
        let topA = List.head decks.[0]
        let topB = List.head decks.[1]
        let deckA = List.tail decks.[0]
        let deckB = List.tail decks.[1]

        if topA > topB then
            [| List.append deckA [topA; topB]; deckB|]
        else
            [| deckA; List.append deckB [topB; topA]|]

    let scoreDeck (deck:int list) =
        deck |> List.rev |> List.mapi (fun i x -> x * (i + 1)) |> List.sumBy id


    let playCombat (startingDecks:seq<string>) =

        let decks = readCards(startingDecks)

        let rec play(decks:int list array) =
            if decks.[0].IsEmpty then
                decks.[1]
            elif decks.[1].IsEmpty then
                decks.[0]
            else
                play(playRound(decks))

        scoreDeck(play(decks))
        