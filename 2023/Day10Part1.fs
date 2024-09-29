namespace _2023

module Day10Part1 =

    let getTiles(input:seq<string>) =      
        input |> array2D

    let findS(tiles:char[,]) =

        let arrayWidth = tiles.GetLength 1
        let arrayHeight = tiles.GetLength 0

        let rec go x y =
            if   y >= arrayHeight then
                (-1, -1)
            elif x >= arrayWidth then
                go 0 (y + 1)
            elif tiles[y, x] = 'S' then 
                (x, y)
            else go (x + 1) y

        go 0 0

    let findFriends(tiles:char[,], (x:int, y:int)) =

        let arrayWidth = tiles.GetLength 1
        let arrayHeight = tiles.GetLength 0

        let centre = [|(x, y)|]
            
        let south =
            if y < arrayHeight - 1 && "S7|F".Contains(string tiles[y, x]) then
                match tiles[y + 1, x] with
                | '|' | 'L' | 'J' -> [|(x, y + 1)|]
                | _ -> Array.empty
            else
                Array.empty 

        let north =
            if y > 0  && "SJ|L".Contains(string tiles[y, x]) then
                match tiles[y - 1, x] with
                | '|' | '7' | 'F' -> [|(x, y - 1)|]
                | _ -> Array.empty
            else
                Array.empty 

        let west =
            if x > 0 && "SJ-7".Contains(string tiles[y, x]) then
                match tiles[y, x - 1] with
                | '-' | 'L' | 'F' -> [|(x - 1, y)|]
                | _ -> Array.empty 
            else
                Array.empty

        let east =
            if x < arrayWidth  - 1 && "SL-F".Contains(string tiles[y, x]) then
                match tiles[y, x + 1] with
                | '-' | 'J' | '7' -> [|(x + 1, y)|]
                | _ -> Array.empty 
            else
                Array.empty

        Array.concat [|centre; north; south; west; east|]

    let getPipeLength(input:seq<string>) =

        let tiles = getTiles input
        let start = findS tiles

        let rec inner(pipeSections) =

            let newPipe = 
                pipeSections
                |> Array.map (fun p -> findFriends (tiles, p)) 
                |> Array.concat
                |> Array.distinct
            
            if  Array.length pipeSections = Array.length newPipe then
                Array.length pipeSections
            else
                inner newPipe

        inner [|start|] / 2
