namespace AoC2019

module Day11Part1 =
    let rotate(((x0, y0), currentDirection), turnInstruction) =
    
        let resetCircle(angle) =
            if   angle <  0   then angle + 360 * (1 + abs angle/360)
            elif angle >= 360 then angle - 360 * (angle/360)
            else angle
        
        let newDirection = 
            match turnInstruction with
            | 0 -> resetCircle(currentDirection - 90)
            | 1 -> resetCircle(currentDirection + 90)
            | _ -> invalidArg "Invalid turnInstruction input to rotate function. Expected 0 or 1" (string turnInstruction)
           
        let (x1, y1) =
            match newDirection with
            |   0 -> (x0, y0 - 1)
            |  90 -> (x0 + 1, y0)
            | 180 -> (x0, y0 + 1)
            | 270 -> (x0 - 1, y0)
            |   _ -> invalidArg "Invalid newDirection input to rotate function. Expected 0, 90, 180 or 270" (string newDirection)
            
        ((x1, y1), newDirection)
    
    let printOutput(locationsPainted) =
        let locationsToPlot = locationsPainted |> Map.toSeq |> Seq.map fst
        let minX = locationsToPlot |> Seq.minBy fst |> fst
        let maxX = locationsToPlot |> Seq.maxBy fst |> fst
        let minY = locationsToPlot |> Seq.minBy snd |> snd
        let maxY = locationsToPlot |> Seq.maxBy snd |> snd
        for j = minY to maxY do
            for i = minX to maxX do
                let colour = match locationsPainted.TryFind ((i, j)) with
                                | Some x -> if x = 1L then "#" else " "
                                | None -> " "
                printf "%s"colour
            
            printfn ""

        printfn  "all %i white %i" locationsPainted.Count (locationsPainted |> Map.filter (fun _ v -> v = 1L) |> Map.count)

    let runTestProgram =
        let instructions = [(1L,1) ; (0L,0) ; (0L,0) ; (1L,1) ; (1L,1) ; (0L,0) ; (0L,0) ; (1L,1) ; (1L,1) ; (0L,1) ; (1L,0) ; (0L,1) ; (1L,0) ; (0L,1) ; (1L,0) ; (0L,0) ; (1L,1) ; (0L,0) ; (1L,1) ; (0L,0) ; (1L,1)  ; (0L,1) ; (0L,1) ; (1L,0) ; (1L,1) ; (0L,0) ; (0L,0) ; (1L,1) ; (1L,0) ; (0L,1) ; (0L,0); (0L,0); (1L,1) ; (0L,0); (0L,0); (1L,1); (1L,1); (0L,0); (0L,0); (1L,1); (1L,1); (0L,1) ; (1L,0); (0L,1) ; (1L,0); (0L,1) ; (1L,0); (0L,1) ; (1L,0); (0L,0); (0L,0);(1L,1);(1L,1);(0L,0); (0L,0);(1L,1);(1L,1)]
        let mutable currentLocation = ((0, 0), 0)
        let mutable locationsPainted = Map.empty

        for instruction in instructions do
            locationsPainted <- locationsPainted |> Map.add (fst currentLocation) (fst instruction)
            currentLocation <- rotate(currentLocation, snd instruction)

        printOutput(locationsPainted)
