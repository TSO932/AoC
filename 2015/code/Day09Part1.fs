namespace AoC2015

module Day09Part1 =

    let parseDistance(distance:string) =
        let splits = distance.Split [|' '|]
        splits.[0], splits.[2], int splits.[4]

    let getSequenceOfCities(distances:seq<string>) =
        distances |> Seq.map parseDistance |> Seq.map (fun (a, b, _) -> [ a ; b ]) |> Seq.concat |> Seq.distinct

    let getDictionaryOfDistances(distances:seq<string>) =
        distances |> Seq.map parseDistance |> Seq.map (fun (a, b, _) -> [ a ; b ]) |> Seq.concat |> Seq.distinct