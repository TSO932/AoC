namespace AoC2019

module Day03Part1 =
    let getWire(inputString:string) =
    
        let sections = inputString.Split ','
        
        let mutable wire = Set.empty
        let mutable x = 0
        let mutable y = 0

        for section in sections do
            let direction = section.[0]
            let length = section.[1..(section.Length) - 1] |> System.Int32.Parse

            for steps = 1 to length do
                if direction = 'R' then
                    x <- x + 1
                elif direction = 'L' then
                    x <- x - 1
                elif direction = 'U' then
                    y <- y + 1
                elif direction = 'D' then
                    y <- y - 1
        
                wire <- wire.Add (x, y)

        wire

    let getIntersection(wire1:string, wire2:string) =
        let crossingPoints = Set.intersect (getWire(wire1)) (getWire(wire2))
        let manhattanDistance = crossingPoints |> Set.map (fun x -> abs (fst x) + abs(snd x)) |> Set.minElement
        manhattanDistance