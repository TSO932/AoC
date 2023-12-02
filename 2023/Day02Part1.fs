namespace _2023

module Day02Part1 =

    let getCubeCount (input:string) =
        let split = (input.Trim()).Split ' '
        split[1], int split[0]

    let getGameId (input:string) =
        let split = input.Split ' '
        int split[1]

    let checkValidity (input:string*int) =
        match fst input with
        | "red" -> snd input <= 12
        | "green" -> snd input <= 13
        | "blue" -> snd input <= 14
        | _ -> false

    let getCubeCounts inputs =
        inputs |> Seq.map getCubeCount |> Seq.map checkValidity |> Seq.contains false |> not

    let gameSum (input: seq<string>) =
            input
            |> Seq.map (fun x -> x.Split [|':'; ','; ';'|])
            |> Seq.map (fun x -> (getGameId(Seq.head x), getCubeCounts(Seq.tail x)))
            |> Seq.filter snd
            |> Seq.sumBy fst