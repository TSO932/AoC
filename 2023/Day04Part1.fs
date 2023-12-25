namespace _2023

module Day04Part1 =

    let getScore (input:string) =

        let score n =
            match n with
            | 0 -> 0
            | 1 -> 1
            | 2 -> 2
            | 3 -> 4
            | 4 -> 8
            | 5 -> 16
            | 6 -> 32
            | 7 -> 64
            | 8 -> 128
            | 9 -> 256
            | _ -> 512

        let numbers =
            input[10..].Split '|'
            |> Seq.map (fun s -> s.Split ' ')
            |> Seq.map (fun q -> Seq.filter ((<>) "") q)
            |> Seq.toArray

        numbers[0]
        |> Seq.filter (fun n1 -> numbers[1] |> Seq.exists (fun n2 -> n1 = n2))
        |> Seq.length
        |> score

    let getSum (input:seq<string>) =
        input |> Seq.sumBy getScore