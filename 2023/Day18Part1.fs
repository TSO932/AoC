namespace _2023

open System

module Day18Part1 =

    let parse(input:string) =
        char input[0], int input[2] - 48, input[6..11] 

    let dig(input:seq<int*int*string>, dir:char, dist:int, colour:string) = 
       
        let (x, y) =
            input
            |> Seq.rev
            |> Seq.head
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

    let getArray(input:seq<int*int*string>) =

        let locations =
            input
            |> Seq.map (fun (x, y, _) -> (x, y) )
            |> Seq.toArray

        let xMax = locations |> Array.maxBy fst |> fst
        let xMin = locations |> Array.minBy fst |> fst
        let yMax = locations |> Array.maxBy snd |> snd
        let yMin = locations |> Array.minBy snd |> snd

        Array2D.init (1 + yMax - yMin) (1 + xMax - xMin) (fun y x -> locations |> Array.contains (x, -y))

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
