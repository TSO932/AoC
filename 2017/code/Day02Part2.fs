namespace AoC2017

module Day02Part2 =
    let getDivisions(spreadsheetRow:string) =

        let cellValues = spreadsheetRow.Split [|'\t'; ' '|] |> Seq.map float

        ( cellValues
            |> Seq.map (fun v -> cellValues |> Seq.map (fun w -> v/w))
            |> Seq.concat
            |> Seq.filter (fun c -> c = float (int c))
            |> Seq.sumBy int ) - Seq.length cellValues

    let getSum(sheet:seq<string>) =

        sheet |> Seq.sumBy getDivisions
        