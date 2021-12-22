namespace AoC2021

module Day04Part1 =

    let getInfo (input:seq<string>) =
        let calledNumbers = (Seq.head input).Split ','
        let bingoCards = input |> Seq.filter  (fun x -> x.Length = 14) |> Seq.map (fun r -> r.Replace("  "," ").Trim(' ').Split ' ') |> Seq.chunkBySize 5 |> Seq.map array2D
        (bingoCards, calledNumbers)

    let checkForBingo (card:string[,]) =
        let bingo = Array.replicate 5 "*"
        if seq {0..4} |> Seq.map (fun n -> [card[n, *]; card[*, n]]) |> Seq.concat |> Seq.map ((=) bingo) |> Seq.contains true then
            (true, (card |> Array2D.map (fun x -> if x = "*" then 0 else int x) |> Seq.cast<int> |> Seq.sum))
        else 
            (false, 0)


    let playBingo (input:seq<string>) =

        let rec play(cards:seq<string[,]>, calledNumbers:seq<string>, lastCalledNumber:string) =
            
            if Seq.length calledNumbers = 0 then
                -1
            else
                let completedCards = Seq.map checkForBingo cards |> Seq.filter fst |> Seq.map snd
                if Seq.length completedCards > 0 then
                    Seq.max completedCards * int lastCalledNumber
                else
                    let nextCalledNumber = Seq.head calledNumbers
                    play(cards |> Seq.map (fun c -> c |> Array2D.map (fun x -> if x = nextCalledNumber then "*" else x)), Seq.tail calledNumbers, nextCalledNumber)

        let info = getInfo(input)
        play(fst info, snd info, "")