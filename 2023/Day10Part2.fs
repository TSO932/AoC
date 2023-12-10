namespace _2023

open System

module Day10Part2 =

    let getTiles = Day10Part1.getTiles
    let findS = Day10Part1.findS
    let findFriends = Day10Part1.findFriends

    let getPipe(input:seq<string>) =

        let tiles = getTiles input
        let start = findS tiles
        
        let rec inner(pipeSections) =

            let newPipe = 
                pipeSections
                |> Array.map (fun p -> findFriends (tiles, p)) 
                |> Array.concat
                |> Array.distinct
            
            if  Array.length pipeSections = Array.length newPipe then
                pipeSections
            else
                inner newPipe

        let pipePositions = inner [|start|]

        tiles |> Array2D.mapi(fun y x c-> if Seq.contains (x, y) pipePositions then c else ' ')

    let getArea(input:seq<string>) =
        
        let isInside(area:char[,], x, y) =
            if area[y, x] <> ' ' then
                false
            else
                area[y, ..(x - 1)]
                |> String
                |> fun s -> if s.Contains 'S' then String area[y, (x + 1)..] else s
                |> fun s -> s.Replace(" ", "").Replace("-", "").Replace("LJ", "").Replace("F7", "").Replace("L7", "|").Replace("FJ", "|").Length
                |> fun x -> (x > 0) && ((x % 2) = 1)

        let pipe = getPipe input

        pipe
        |> Array2D.mapi (fun y x _ -> isInside(pipe, x, y))
        |> Seq.cast<bool>
        |> Seq.filter id
        |> Seq.length
        
