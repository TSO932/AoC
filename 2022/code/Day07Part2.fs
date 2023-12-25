namespace AoC2022

module Day07Part2 =
    let GetFolderTotals input =
        input
        |> Day07Part1.getAllFoldersWithSizes
        |> Day07Part1.getFolderTotals

    let runProgram input =

        let folderTotals = GetFolderTotals input

        let spaceRequired =
            folderTotals
            |> Seq.maxBy snd
            |> snd
            |> fun x -> (x - 40000000)

        folderTotals
            |> Seq.filter (fun (_, n) -> n >= spaceRequired)
            |> Seq.minBy snd
            |> snd