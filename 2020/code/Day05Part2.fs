namespace AoC2020

module Day05Part2 =

        let findMySeat(boardingPasses:seq<string>) =
            
            let SeatIds = boardingPasses |> Seq.map Day05Part1.getSeatId

            seq {0..Day05Part1.findHighestSeatId(boardingPasses)} 
                |> Seq.filter (fun x ->     (SeatIds |> Seq.contains (x - 1)))
                |> Seq.filter (fun x -> not (SeatIds |> Seq.contains  x     ))
                |> Seq.filter (fun x ->     (SeatIds |> Seq.contains (x + 1)))
           