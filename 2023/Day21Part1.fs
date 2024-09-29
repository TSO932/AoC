namespace _2023

module Day21Part1 =

    let getPlots = Day10Part1.getTiles
    let findS = Day10Part1.findS

    let move(x, y, plots:char[,]) =

        [|(x + 1, y); (x - 1, y); (x, y - 1); (x, y + 1)|]
        |> Seq.filter (fun (x, y) -> plots[y,x] <> '#')

    let moves(input:seq<int*int>, plots:char[,]) =
        input
        |> Seq.map (fun (x, y) -> move (x, y, plots))
        |> Seq.concat
        |> Seq.distinct
        |> Seq.sort

    let movesN(input:seq<int*int>, plots:char[,], count:int) =
        seq{1..count}
        |> Seq.fold (fun a _ -> moves(a, plots)) input

    let countN(input:seq<int*int>, plots:char[,], count:int) =
        movesN (input, plots, count)
        |> Seq.length

    let count(input:seq<string>) =
        let plots = getPlots input
        let start = findS plots

        countN (seq {start}, plots, 64)
        