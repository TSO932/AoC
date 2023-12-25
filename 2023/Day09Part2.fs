namespace _2023

module Day09Part2 =

    let parse = Day09Part1.parse
    let getDifferences = Day09Part1.getDifferences

    let getSequences (input:seq<int>) =
        let rec innerGet (inputs:seq<seq<int>>) =
            let latest = inputs|> Seq.head

            if latest |> Seq.filter ((<>) 0) |> Seq.isEmpty then
                inputs |> Seq.map (fun seq -> seq |> Seq.head)
            else
                innerGet (Seq.append [|getDifferences (latest)|] inputs)

        innerGet ([|input|])

    let getPrediction (input:seq<int>) =
        input |> Seq.fold (fun a x -> x - a) 0

    let getSum (input:seq<string>) =
        input |> Seq.sumBy (parse >> getSequences >> getPrediction)



    