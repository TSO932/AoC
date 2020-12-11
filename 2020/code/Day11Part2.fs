namespace AoC2020

module Day11Part2 =
    let countSeats(floorPlan:seq<string>) =

        let isDebug = true
       
        let arrays = floorPlan |> Seq.map (Array.ofSeq) |> Array.ofSeq
        let maxHeight = arrays.Length
        let maxWidth = arrays.[0].Length
        let matrix = Array2D.init maxHeight maxWidth (fun i j -> arrays.[i].[j])

        let peopleCount(seating:'a [,]) =
            seating |> Seq.cast |> Seq.countBy ((=) '#') |> Seq.sumBy (fun (b, i) -> if b then i else 0)

        let rec nextRound(oldOccupancy:char [,]) =
        
            if isDebug then printfn "%A" oldOccupancy

            let flipSeats(h, v, c) =
                let countNeighbours(y, x) = 
                    
                    let getChairs(slice:array<char>) =
                        slice |> Seq.filter (fun c -> c = '#' || c = 'L') |> List.ofSeq
                        
                    let getChairsOnDiagonal(axis:int, subMatrix:char[,]) =
                        subMatrix |> Array2D.mapi (fun y x c -> if x = axis * y then c else ' ') |> Seq.cast |> Array.ofSeq |> getChairs

                    let countIfOccupied(slice:list<char>) =
                        if slice.Length > 0 && (slice |> List.head) = '#' then 1 else 0

                    let right  = oldOccupancy.[x, (y + 1)..maxHeight] |> getChairs |>             countIfOccupied
                    let left   = oldOccupancy.[x,       0..(y - 1)]   |> getChairs |> List.rev |> countIfOccupied
                    let down   = oldOccupancy.[(x + 1)..maxWidth, y]  |> getChairs |>             countIfOccupied
                    let up     = oldOccupancy.[      0..(x - 1) , y]  |> getChairs |> List.rev |> countIfOccupied

                    let d1 = oldOccupancy.[(x + 1)..maxWidth, (y + 1)..maxHeight] |> fun m -> getChairsOnDiagonal ( 1, m) |>             countIfOccupied
                    let d2 = oldOccupancy.[(x + 1)..maxWidth,       0..(y - 1)]  |> fun m -> getChairsOnDiagonal (-1, m) |>             countIfOccupied
                    let d3 = oldOccupancy.[      0..(x - 1),   (y + 1)..maxHeight] |> fun m -> getChairsOnDiagonal (-1, m) |> List.rev |> countIfOccupied
                    let d4 = oldOccupancy.[      0..(x - 1),         0..(y - 1)]  |> fun m -> getChairsOnDiagonal ( 1, m) |> List.rev |> countIfOccupied

                    if isDebug then printfn "h %i v %i c %c down %i up %i right %i left %i d1 %i d2 %i d3 %i d4 %i" h v c down up right left d1 d2 d3 d4 

                    left + right + up + down + d1 + d2 + d3 + d4

                if   c = 'L' && countNeighbours(h, v)  = 0 then '#'
                elif c = '#' && countNeighbours(h, v) >= 5 then 'L'
                else c
            
            let newOccupancy = oldOccupancy |> Array2D.mapi (fun v h c -> flipSeats(h, v, c))

            if newOccupancy = oldOccupancy then
                oldOccupancy
            else
                nextRound(newOccupancy)

        peopleCount (nextRound(matrix))