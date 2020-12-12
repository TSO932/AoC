namespace AoC2020

module Day12Part2 =
    let navigate (instructions:seq<string>) =

        let isDebug = false
        
        let move(instruction:string, (shipX:int, shipY:int, wayPointX:int, wayPointY:int)) =

            if isDebug then printfn "SHIP x %i y %i WAYPOINT x %i y %i inst %s" shipX shipY wayPointX wayPointY instruction

            let value  = int instruction.[1..(instruction.Length - 1)]

            let rec rotateLeft(x:int, y:int, value:int) =
                let newWaypointLocation = (-y, x, value - 90)
                
                if value <= 90 then
                    newWaypointLocation
                else
                    rotateLeft(newWaypointLocation)

            let rec rotateRight(x:int, y:int, value:int) =
                let newWaypointLocation = (y, -x, value - 90)
                
                if value <= 90 then
                    newWaypointLocation
                else
                    rotateRight(newWaypointLocation)

            match instruction.[0] with
                | 'F' -> (shipX + value * wayPointX, shipY + value * wayPointY, wayPointX, wayPointY)
                | 'N' -> (shipX, shipY, wayPointX        , wayPointY + value)
                | 'S' -> (shipX, shipY, wayPointX        , wayPointY - value)
                | 'E' -> (shipX, shipY, wayPointX + value, wayPointY        )
                | 'W' -> (shipX, shipY, wayPointX - value, wayPointY        )
                | 'L' -> let (newX, newY, _) = rotateLeft(wayPointX, wayPointY, value)
                         (shipX, shipY, newX, newY)
                | 'R' -> let (newX, newY, _) = rotateRight(wayPointX, wayPointY, value)
                         (shipX, shipY, newX, newY)
                |  _  -> invalidArg "Invalid move. Expected N, S, E, W, L, R or F." (string instruction)

        instructions |> Seq.fold (fun pos inst -> move(inst, pos)) (0, 0, 10, 1) |> fun (x, y, _, _) -> abs x + abs y