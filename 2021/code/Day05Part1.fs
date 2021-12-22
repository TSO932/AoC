namespace AoC2021

module Day05Part1 =

    let countPointsWithNOrMore (input:int[,]) = input |> Seq.cast<int> |> Seq.sumBy (fun n -> if n > 1 then 1 else 0)

    let applyLine (grid:int[,], x1:int, y1:int, x2:int, y2:int, includeDiagonals:bool) =

        let xA = if x1 <= x2 then x1 else x2
        let xB = if x1 <= x2 then x2 else x1
        let yA = if y1 <= y2 then y1 else y2
        let yB = if y1 <= y2 then y2 else y1

        grid |> Array2D.mapi (fun y x v -> if x >= xA && x <= xB && y >= yA && y <= yB && (yA = yB || xA = xB
                                                || (includeDiagonals && ( (x1 < x2 && y1 < y2) || (x1 > x2 && y1 > y2) ) && x - x1 = y - y1)
                                                || (includeDiagonals && ( (x1 < x2 && y1 > y2) || (x1 > x2 && y1 < y2) ) && x - x1 = y1 - y)) then v + 1 else v)

    type Line(box:string) = 

        let coordinates = box.Split [|' '; ','|]

        let x1 = int coordinates[0]
        let y1 = int coordinates[1]
        let x2 = int coordinates[3]
        let y2 = int coordinates[4]

        member _.X1 = x1
        member _.X2 = x2
        member _.Y1 = y1
        member _.Y2 = y2

    let findCrossings(input:seq<string>) =
        input |> Seq.map Line |> Seq.fold (fun grid line -> applyLine(grid, line.X1, line.Y1, line.X2, line.Y2, false)) (Array2D.zeroCreate 1000 1000) |> countPointsWithNOrMore