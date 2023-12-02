namespace _2023

module Day02Part2 =

    let getCubeCount = Day02Part1.getCubeCount

    let getMaxByColour (colour:string, input:seq<string*int>) =
        input
        |> Seq.filter (fun x ->  fst x = colour)
        |> Seq.maxBy snd
        |> snd

    let cubePowers (input: seq<string>) =
            input
            |> Seq.map (fun x -> x.Split [|':'; ','; ';'|])
            |> Seq.map (fun x -> Seq.map getCubeCount (Seq.tail x))
            |> Seq.sumBy (fun x -> getMaxByColour ("blue", x) * getMaxByColour ("red", x) * getMaxByColour ("green", x))