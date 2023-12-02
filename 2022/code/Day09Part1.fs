namespace AoC2022

module Day09Part1 = 

    //let moveHead (path:seq<(x, y)>, move) =


    let getSingles (instruction:string) =
        let split = instruction.Split ' '
        split[0]|> Seq.replicate (int split[1])

    let getMoveCoords (direction:string) =
        match direction with
            | "R" -> (1, 0)
            | "L" -> (-1, 0)
            | "U" -> (0, 1)
            | _ -> (0, -1)

    let move ((x:int,y:int), (delX:int, delY:int)) =
        (x + delX, y + delY)

    let getDeltas (instructions:seq<string>) =
        instructions
        |> Seq.collect getSingles
        |> Seq.map getMoveCoords

    let getPathOfHead (instructions:seq<string>) =     
        instructions
        |> getDeltas
        |> Seq.scan (fun delta current -> move(current, delta)) (0, 0)