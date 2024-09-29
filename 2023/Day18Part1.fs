namespace _2023

module Day18Part1 =
    let parse(input:string) =
        input.Split ' '
        |> fun a -> (char a[0], int a[1])

    let move(coords:seq<int*int>, dir:char, dist:int) = 

        let (x, y) =
            coords
            |> Seq.last

        let (dx, dy) =
            match dir with
            | 'U' -> (0, 1)
            | 'D' -> (0, -1)
            | 'R' -> (1, 0)
            | _ -> (-1, 0)

        [(x + dx * dist, y + dy * dist)]
        |> Seq.append coords

    let getCoords(input:seq<string>) =
        input
        |> Seq.map parse
        |> Seq.fold (fun a (dir, dist) -> move (a, dir, dist)) [|(0, 0)|]

    let getArea(input:seq<string>) =
        
        let moves =
            input
            |> Seq.map parse

        let perimeterLength =
            moves
            |> Seq.sumBy snd

        let coords = 
            input
            |> getCoords
            |> Seq.toArray

        let points =
            coords
            |> Array.tail // first and last points are both (0, 0)
            
        let len = Seq.length points

        let prev(i) =
            if i = 0 then
                len - 1
            else
                i - 1

        let next(i) = (i + 1) % len

        let area =
            seq {0 .. len - 1}
            |> Seq.sumBy (fun i -> fst (points[i]) * (snd (points[prev i]) - snd (points[next i])))
            |> abs
            |> fun x -> x / 2

        area + 1 + perimeterLength / 2
