namespace AoC2017

module Day05Part1 =

    let escapeMaze (offsets: seq<string>) =

        let maze = offsets |> Seq.map int |> Seq.toArray

        let rec move (turn, position) =

            if position >= Array.length maze then
                turn
            else
                let newTurn = turn + 1
                let newPosition = position + maze[position]
                Array.set maze position (maze[position] + 1)
                move (newTurn, newPosition)

        move (0, 0)
