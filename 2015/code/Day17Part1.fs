namespace AoC2015

module Day17Part1 =

    let isExtactFit(containers:seq<int>, quantity:int) =
      (0, containers) ||> Seq.fold (fun volume container -> volume + container) = quantity

    let countCombinations (sizes:seq<int>, quantity:int) =
        sizes |> List.ofSeq |> CommonFunctions.allCombinations |> List.map (fun p -> isExtactFit(p, quantity)) |> Seq.filter (fun x -> x = true) |> Seq.length

    let countCombinationsOfContainers (sizes:seq<string>) =
        countCombinations (Seq.map int sizes, 150) 

        
