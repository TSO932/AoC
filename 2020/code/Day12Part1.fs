namespace AoC2020

module Day12Part1 =
    let navigate (instructions:seq<string>) =

        let isDebug = false
        
        let move(instruction:string, (x:int, y:int, dir:char)) =

            if isDebug then printfn "x %i y %i dir %c inst %s" x y dir instruction

            let value  = int instruction.[1..(instruction.Length - 1)]

            let rec rotateLeft(dir:char, value:int) =
                let newDir = match dir with
                                | 'N' -> 'W'
                                | 'E' -> 'N'
                                | 'S' -> 'E'
                                | 'W' -> 'S'
                                |  _  -> invalidArg "Invalid move. Never Eat Shredded Wheat." (string instruction)
                
                if value <= 90 then
                    newDir
                else
                    rotateLeft(newDir, value - 90)

            let rec rotateRight(dir:char, value:int) =
                let newDir = match dir with
                                | 'N' -> 'E'
                                | 'E' -> 'S'
                                | 'S' -> 'W'
                                | 'W' -> 'N'
                                |  _  -> invalidArg "Invalid move. Expected N, E, S or W." (string instruction)
                
                if value <= 90 then
                    newDir
                else
                    rotateRight(newDir, value - 90)

            match (if instruction.[0] = 'F' then dir else instruction.[0]) with
                | 'N' -> (x        , y + value, dir)
                | 'S' -> (x        , y - value, dir)
                | 'E' -> (x + value, y        , dir)
                | 'W' -> (x - value, y        , dir)
                | 'L' -> (x        , y        , rotateLeft  (dir, value))
                | 'R' -> (x        , y        , rotateRight (dir, value))
                |  _  -> invalidArg "Invalid move. Expected N, S, E, W, L, R or F." (string instruction)

        instructions |> Seq.fold (fun pos inst -> move(inst, pos)) (0, 0, 'E') |> fun (x, y, _) -> abs x + abs y