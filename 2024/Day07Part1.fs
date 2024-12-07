namespace _2024

open System

module Day07Part1 =

    let getValidValue(inputLine:string) =

        let values =
            inputLine.Split([|" "; ":"|], StringSplitOptions.RemoveEmptyEntries)
            |> Seq.map Int64.Parse

        let validValue = Seq.head values
        let inputValues = Seq.tail values

        (seq {Seq.head inputValues}, Seq.tail inputValues)
        ||> Seq.fold (fun acc value -> acc |> Seq.map (fun a -> [a + value; a * value]) |> Seq.concat)
        |> Seq.contains validValue
        |> fun b -> if b then validValue else 0L

    let run(input:seq<String>) = Seq.sumBy getValidValue input

