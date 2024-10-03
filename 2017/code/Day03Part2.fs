namespace AoC2017

module Day03Part2 =
    let getVal(targetValue) =

        let grid = Array2D.create 101 101 0
        Array2D.set grid 50 50 1

        let sumSurroundingValues (x, y) =
            List.sum [ grid[x - 1, y - 1]; grid[x, y - 1]; grid[x + 1, y - 1]; grid[x - 1, y]; grid[x + 1, y]; grid[x - 1, y + 1]; grid[x, y + 1]; grid[x + 1, y + 1] ]

        let rec walk(n, x, y, dir) =

            let nextValue = sumSurroundingValues(x, y)

            if nextValue > targetValue then
                nextValue
            else
                Array2D.set grid x y nextValue

                let nextDir = 
                    match dir with
                        | (1, 0) -> (0, 1)
                        | (0, 1) -> (-1, 0)
                        | (-1, 0) -> (0, -1)
                        | _ -> (1, 0)
                let nextX = x + fst nextDir
                let nextY = y + snd nextDir

                let nextInstruction =
                    if grid[nextX, nextY] = 0 then
                        (n + 1, nextX, nextY, nextDir)
                    else
                        (n + 1, x + fst dir, y + snd dir, dir)
            
                walk nextInstruction

        walk (2, 51, 50, (1,0))

    let getValue (input: seq<string>) = input |> Seq.head |> int |> getVal