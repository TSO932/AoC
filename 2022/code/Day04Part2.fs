namespace AoC2022

module Day04Part2 =

    let IsOverlap (pair:array<int>) =

        ( pair[0] <= pair[2] && pair[1] >= pair[2] ) || ( pair[2] <= pair[0] && pair[3] >= pair[0] ) 

    let GetNumberOfOverlaps (elfAssignmentPairs:seq<string>) =

       elfAssignmentPairs
            |> Seq.filter (Day04Part1.ParseInput >> IsOverlap)
            |> Seq.length
