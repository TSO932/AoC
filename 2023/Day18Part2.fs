namespace _2023

open System
open System.Globalization

module Day18Part2 =

    let parse(input:string) =
        input.Split ' '
        |> fun a -> (char (a[2][7]), Int64.Parse(a[2][2..6], NumberStyles.HexNumber))

    let move(coords:seq<int64*int64>, dir:char, dist:int64) = 

        let (x, y) =
            coords
            |> Seq.last

        let (dx, dy) =
            match dir with
            | '3' -> (0L, 1L)
            | '1' -> (0L, -1)
            | '0' -> (1L, 0L)
            | _ -> (-1L, 0L)

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
            |> fun x -> x / 2L

        area + 1L + perimeterLength / 2L
