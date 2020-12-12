namespace AoC2020

module Day11Part2 =
    let countSeats(floorPlan:seq<string>) =

        let isDebug = false
       
        let arrays = floorPlan |> Seq.map (Array.ofSeq) |> Array.ofSeq
        let maxHeight = arrays.Length
        let maxWidth = arrays.[0].Length
        let matrix = Array2D.init maxHeight maxWidth (fun i j -> arrays.[i].[j])

        let peopleCount(seating:'a [,]) =
            seating |> Seq.cast |> Seq.countBy ((=) '#') |> Seq.sumBy (fun (b, i) -> if b then i else 0)

        let rec nextRound(oldOccupancy:char [,]) =

            if isDebug then printfn "%s %i" (System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.ffff")) (peopleCount(oldOccupancy))

            if isDebug then printfn "%A" oldOccupancy

            let flipSeats(h, v, c) =
                
                let countNeighbours(col, row) = 
                    
                    let getChairs(slice:array<char>) =
                        slice |> Seq.filter (fun c -> c = '#' || c = 'L') |> List.ofSeq
                        
                    let getChairsOnDiagonal(isPrimary:bool, subMatrix:char[,]) =
                        subMatrix |> Array2D.mapi (fun y x c -> if (isPrimary && x = y) || (not isPrimary && x = (subMatrix |> Array2D.length1) - 1 - y) then c else ' ') |> Seq.cast |> Array.ofSeq |> getChairs

                    let countIfOccupied(slice:list<char>) =
                        if slice.Length > 0 && (slice |> List.head) = '#' then 1 else 0

                    let right  = oldOccupancy.[row, (col + 1)..(maxWidth - 1)]   |> getChairs |>             countIfOccupied
                    let left   = oldOccupancy.[row,         0..(col - 1)]        |> getChairs |> List.rev |> countIfOccupied
                    let down   = oldOccupancy.[(row + 1)..(maxHeight - 1), col]  |> getChairs |>             countIfOccupied
                    let up     = oldOccupancy.[        0..(row - 1),       col]  |> getChairs |> List.rev |> countIfOccupied

                    let d1 =
                        let count = (min (maxHeight - row) (maxWidth - col)) - 1
                        oldOccupancy.[(row + 1)..(row + count), (col + 1)..(col + count)] |> fun m -> getChairsOnDiagonal (true, m) |>  countIfOccupied
                    
                    let d2 =
                        let count = min (maxHeight - row - 1) col
                        oldOccupancy.[(row + 1)..(row + count), (col - count)..(col - 1)] |> fun m -> getChairsOnDiagonal (false, m) |> countIfOccupied
                    
                    let d3 =
                        let count = min row (maxWidth - col - 1)
                        oldOccupancy.[(row - count)..(row - 1), (col + 1)..(col + count)] |> fun m -> getChairsOnDiagonal (false, m) |> List.rev |> countIfOccupied
                    
                    let d4 =
                        let count = min row col
                        oldOccupancy.[(row - count)..(row - 1), (col - count)..(col - 1)] |> fun m -> getChairsOnDiagonal (true, m) |> List.rev |> countIfOccupied

                    if isDebug then printfn "col %i row %i c %c down %i up %i right %i left %i d1 %i d2 %i d3 %i d4 %i" h v c down up right left d1 d2 d3 d4 

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