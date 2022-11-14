namespace AoC2017

module Day02Part1 =
    let getDifference(spreadsheetRow:string) =

        let cellValues = spreadsheetRow.Split [|'\t'; ' '|] |> Seq.map int

        ( cellValues |> Seq.max ) - ( cellValues |> Seq.min ) 

    let checkSum(sheet:seq<string>) =

        sheet |> Seq.sumBy getDifference
        