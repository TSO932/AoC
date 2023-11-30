namespace AoC2022

module Day08Part1 =

    let isVisible (lineOfSight, treeHeight) =
        lineOfSight |> Array.filter ((<=) treeHeight) |> Array.isEmpty

    let countVisibleTrees (input) =

        let treeHeights = input |> Seq.map (Array.ofSeq) |> Array.ofSeq |> array2D

        let isVisibleFromLeft (y, x, h) =
            isVisible (treeHeights[y, .. (x - 1)], h)

        let isVisibleFromRight (y, x, h) =
            isVisible (treeHeights[y, (x + 1) ..], h)

        let isVisibleFromTop (y, x, h) =
            isVisible (treeHeights[.. (y - 1), x], h)

        let isVisibleFromBottom (y, x, h) =
            isVisible (treeHeights[(y + 1) .., x], h)

        let isVisibleFromAnySide (y, x, h) =
            isVisibleFromLeft (y, x, h)
            || isVisibleFromRight (y, x, h)
            || isVisibleFromTop (y, x, h)
            || isVisibleFromBottom (y, x, h)

        let treeVisibilty =
            treeHeights |> Array2D.mapi (fun y x h -> isVisibleFromAnySide (y, x, h))

        treeVisibilty |> Seq.cast |> Seq.filter id |> Seq.length
