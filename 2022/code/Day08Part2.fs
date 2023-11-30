namespace AoC2022

module Day08Part2 =

    let countTreesYouCanSee (lineOfSight, treeHeight, isLookingBack) =
        
        let lineOfTrees = 
            match isLookingBack with
            | true -> lineOfSight |> Array.rev
            | _ -> lineOfSight

        if Array.isEmpty lineOfSight then
            0
        else

        let lineOfTrees = 
            match isLookingBack with
            | true -> lineOfSight |> Array.rev
            | _ -> lineOfSight

        let nearestTallTree = lineOfTrees |> Array.tryFindIndex ((<=) treeHeight)

        match nearestTallTree with
        | Some n -> 1 + n
        | _ -> Array.length lineOfTrees

    let getMostScenicScore (input) =

        let treeHeights = input |> Seq.map (Array.ofSeq) |> Array.ofSeq |> array2D
    
        let countTreesToLeft (y, x, h) = countTreesYouCanSee(treeHeights[y, ..(x - 1)], h, true)
        let countTreesToRight (y, x, h) = countTreesYouCanSee(treeHeights[y, (x + 1)..], h, false)
        let countTreesUp (y, x, h) = countTreesYouCanSee(treeHeights[..(y - 1), x], h, true)
        let countTreesDown (y, x, h) = countTreesYouCanSee(treeHeights[(y + 1).., x], h, false)

        let getScenicScore (y, x, h) = countTreesToLeft (y, x, h) * countTreesToRight (y, x, h) * countTreesUp (y, x, h) * countTreesDown (y, x, h)

        let scenicScores = treeHeights |> Array2D.mapi (fun y x h -> getScenicScore (y, x, h) )

        scenicScores |> Seq.cast |> Seq.max