namespace _2024

module Day14Part2 =

    let move(robot) = Day14Part1.move(Day14Part1.Board(Day14Part1.BoardType.Live), robot)

    let isOverlap(robots:array<array<int>>) =

        robots
        |> Array.map (fun a -> (a[0], a[1]))
        |> Array.countBy id
        |> Array.map snd
        |> Array.exists ((<>) 1)

    let run(input:seq<string>) =

        let rec countUp(robots, counter) =

            if counter = 100000 then
                -1
            else
                if isOverlap robots then
                    countUp(Array.map move robots, counter + 1)
                else
                    counter
       
        countUp (input |> Seq.map Day14Part1.parseLine |> Seq.toArray, 0)


    
 