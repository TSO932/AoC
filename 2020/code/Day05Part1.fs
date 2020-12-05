namespace AoC2020

module Day05Part1 =

    let rec getDecimal(bin:string) =
        let len = bin.Length - 1
        if len = 0 then
            int (string bin.[0])
        else
            int (string bin.[0]) * pown 2 len + getDecimal bin.[1..len]

    let getSeatLocation(binaryCode:string) =
        (getDecimal(binaryCode.[0..6].Replace("F","0").Replace("B","1")), getDecimal(binaryCode.[7..9].Replace("L","0").Replace("R","1")))

    let getSeatId(binaryCode:string) =
        let (row, column) = getSeatLocation (binaryCode)
        8 * row + column

    let findHighestSeatId(boardingPasses:seq<string>) =
        boardingPasses |> Seq.map getSeatId |> Seq.max        
       