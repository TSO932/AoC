namespace _2023

open System

module Day18Part1 =

    let parse(input:string) =
        input.Split ' '
        |> fun a -> (char a[0], int a[1], a[2][2..7])

    let dig(input:seq<int*int*string>, dir:char, dist:int, colour:string) = 

        let (x, y) =
            input
            |> Seq.last
            |> fun (x, y, _) -> (x, y)

        let (dx, dy) =
            match dir with
            | 'U' -> (0, 1)
            | 'D' -> (0, -1)
            | 'R' -> (1, 0)
            | _ -> (-1, 0)

        seq {1..dist}
        |> Seq.map (fun d -> (x + dx * d, y + dy * d, colour))
        |> Seq.append input

    let getPath(input:seq<string>) =
        input
        |> Seq.map parse
        |> Seq.fold (fun a (dir, dist, colour) -> dig (a, dir, dist, colour)) [|(0, 0, String.Empty)|]


    let getArea(input:seq<string>) =
        
        let permimeter = 
            input
            |> getPath

        let points =
            permimeter
            |> Seq.tail // first and last points are both (0, 0)
            |> Seq.toArray
            
        let len = Seq.length points

        let x(input) = input |> fun (x, _, _) -> x
        let y(input) = input |> fun (_, y, _) -> y

        let prev(i) =
            if i = 0 then
                len - 1
            else
                i - 1

        let next(i) = (i + 1) % len

        let area =
            seq {0 .. len - 1}
            |> Seq.sumBy (fun i -> x(points[i]) * (y(points[prev i]) - y(points[next i])))
            |> abs
            |> fun x -> x / 2

        area + 1 + len / 2
