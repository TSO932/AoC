namespace AoC2020

module Day11Part1 =
    let countSeats(floorPlan:seq<string>) =

        let isDebug = false
        
        let arrays = floorPlan |> Seq.map (Array.ofSeq) |> Array.ofSeq
        let maxHeight = arrays.Length
        let maxWidth = arrays.[0].Length
        let matrix = Array2D.init maxHeight maxWidth (fun i j -> arrays.[i].[j])

        let peopleCount(seating:'a [,]) =
            seating |> Seq.cast |> Seq.countBy ((=) '#') |> Seq.sumBy (fun (b, i) -> if b then i else 0)

        let rec nextRound(oldOccupancy:char [,]) =

            if isDebug then printfn "%A" oldOccupancy
            if isDebug then printfn "%A" (oldOccupancy |> Array2D.mapi (fun y x c -> peopleCount oldOccupancy.[y..y,x..x]))
            if isDebug then printfn "%A" (oldOccupancy |> Array2D.mapi (fun y x c -> peopleCount oldOccupancy.[(max 0 (y - 1))..(min maxHeight (y + 1)),(max 0 (x - 1))..(min maxWidth (x + 1))]))

            let flipSeats(v, h, c) =
                let countNeighbours(x, y) = 
                    oldOccupancy.[(max 0 (y - 1))..(min maxHeight (y + 1)),(max 0 (x - 1))..(min maxWidth (x + 1))]
                        |> peopleCount
 
                if   c = 'L' && countNeighbours(v, h)  = 0 then '#'
                elif c = '#' && countNeighbours(v, h) >= 5 then 'L'
                else c
            
            let newOccupancy = oldOccupancy |> Array2D.mapi (fun h v c -> flipSeats(v, h, c))

            if newOccupancy = oldOccupancy then
                oldOccupancy
            else
                nextRound(newOccupancy)

        peopleCount (nextRound(matrix))