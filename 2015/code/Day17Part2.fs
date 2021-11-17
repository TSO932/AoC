namespace AoC2015

module Day17Part2 =

    let isExtactFit(containers:seq<int>, quantity:int) =
      ((0, containers) ||> Seq.fold (fun volume container -> volume + container) = quantity), Seq.length containers

    let countCombinations (sizes:seq<int>, quantity:int) =
        let exactFits =  sizes |> List.ofSeq |> CommonFunctions.allCombinations |> List.map (fun p -> isExtactFit(p, quantity)) |> Seq.filter (fun (x, _) -> x = true) |> Seq.map snd

        let minNumberOfContainers = exactFits |> Seq.min 
        exactFits |> Seq.filter (fun i -> i = minNumberOfContainers) |> Seq.length


    let countCombinationsOfContainers (sizes:seq<string>) =
        countCombinations (Seq.map int sizes, 150) 


        
