namespace AoC2022

module Day07Part1 =
    let getDirectory (instruction, currentDirectory:string) =
        match instruction with
            | "$ cd /" -> ""
            | "$ cd .." -> currentDirectory[..currentDirectory.LastIndexOf "/" - 1]
            | instruction when instruction.StartsWith "$ cd " -> currentDirectory + (if currentDirectory.Length > 0 then "/" else "") + instruction[5..]
            | _ -> currentDirectory

    let getSize (instruction:string) =
        match System.Int32.TryParse instruction[..instruction.IndexOf " " - 1] with
            | true, num -> num
            | _ -> 0

    let rec getFolders (currentFolder, folders:list<string>) =
        match currentFolder with
            | "" -> List.append folders ["/"]
            | _ ->  getFolders (getDirectory ("$ cd ..", currentFolder), List.append folders [currentFolder])

    let getSizes (instructions:seq<string>) =
       instructions |> Seq.map getSize 

    let getDirs (instructions:seq<string>) =
       instructions |> Seq.scan (fun cur x -> getDirectory (x, cur)) "" |> Seq.tail

    let getDirsAndSizes (instructions:seq<string>) =
        Seq.zip (getDirs instructions) (getSizes instructions)
        |> Seq.filter (fun (_, n) -> n > 0)

    let getFoldersWithSize (currentFolder, size) =
        getFolders (currentFolder, []) |> Seq.map (fun folder -> (folder, size))

    let getAllFoldersWithSizes (instructions:seq<string>) =
        instructions
            |> getDirsAndSizes
            |> Seq.map getFoldersWithSize
            |> Seq.concat

    let sumOfFileSizes files =
        files |> Seq.sumBy snd
            
    let getFolderTotals input:seq<string*int> = 
        input
            |> Seq.groupBy fst
            |> Seq.map (fun (folder, files) -> folder, sumOfFileSizes (files))

    let getSumOfSmallDirectories input =
        input
            |> Seq.filter (fun (_, size) -> size <= 100000)
            |> sumOfFileSizes

    let runProgram input =
        input
            |> getAllFoldersWithSizes
            |> getFolderTotals
            |> getSumOfSmallDirectories