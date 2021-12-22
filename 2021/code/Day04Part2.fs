namespace AoC2021

module Day04Part2 =

 let playBingo (input:seq<string>) =

        let rec play(cards:seq<string[,]>, calledNumbers:seq<string>, lastCalledNumber:string) =
            
            if Seq.length calledNumbers = 0 then
                -1
            else
                let completedCards = Seq.map Day04Part1.checkForBingo cards |> Seq.filter fst |> Seq.map snd
                if Seq.length completedCards > 0 && Seq.length cards = 1 then
                    Seq.max completedCards * int lastCalledNumber
                else
                    let nextCalledNumber = Seq.head calledNumbers
                    let stillInPlay = cards |> Seq.filter (fun card -> not (fst (Day04Part1.checkForBingo(card)))) 
                    play(stillInPlay |> Seq.map (fun c -> c |> Array2D.map (fun x -> if x = nextCalledNumber then "*" else x)), Seq.tail calledNumbers, nextCalledNumber)

        let info = Day04Part1.getInfo(input)
        play(fst info, snd info, "")