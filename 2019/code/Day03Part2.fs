namespace AoC2019

module Day03Part2 =
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
        
    let measureLength(inputString:string, crossingPoint) =
        
        let sections = inputString.Split ','
        
        let mutable totalLength = 0
        let mutable isComplete = false
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
        
                if isComplete = false then
                    totalLength <- totalLength + 1
                    
                    if x = fst crossingPoint && y = snd crossingPoint then
                        isComplete <- true

        totalLength

    let getIntersection(wire1:string, wire2:string) =
        Set.intersect (getWire(wire1)) (getWire(wire2)) |> Set.map (fun x -> measureLength(wire1, x) + measureLength(wire2, x)) |> Set.minElement
