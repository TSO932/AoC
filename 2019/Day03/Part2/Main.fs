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
    printfn "%i" (Set.intersect (getWire(wire1)) (getWire(wire2)) |> Set.map (fun x -> measureLength(wire1, x) + measureLength(wire2, x)) |> Set.minElement)
        
getIntersection("R8,U5,L5,D3", "U7,R6,D4,L4") //example 1

getIntersection("R75,D30,R83,U83,L12,D49,R71,U7,L72", "U62,R66,U55,R34,D71,R55,D58,R83") //example 2

getIntersection("R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51", "U98,R91,D20,R16,D67,R40,U7,R15,U6,R7") //example 3

let wire1 = "R8,U5,L5,D3" // paste input values over the dummy values in the string
let wire2 = "U7,R6,D4,L4" // paste input values over the dummy values in the string

getIntersection(wire1, wire2)



