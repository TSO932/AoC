namespace _2023

module Day09Part1 =

    let parse (input:string) =
        input.Split ' '
        |> Seq.map int
    
    let getDifferences (input:seq<int>) =
        input
        |> Seq.pairwise
        |> Seq.map (fun (a, b) -> b - a)

    let getSequences (input:seq<int>) =
        let rec innerGet (inputs:seq<seq<int>>) =
            let latest = inputs|> Seq.head

            if latest |> Seq.filter ((<>) 0) |> Seq.isEmpty then
                inputs |> Seq.map (fun seq -> seq |> Seq.rev |> Seq.head)
            else
                innerGet (Seq.append [|getDifferences (latest)|] inputs)

        innerGet ([|input|])

    let getPrediction (input:seq<int>) =
        input |> Seq.fold (fun a x -> x + a) 0

    let getSum (input:seq<string>) =
        input |> Seq.sumBy (parse >> getSequences >> getPrediction)



    