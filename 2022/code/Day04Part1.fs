namespace AoC2022

module Day04Part1 =

    let ParseInput (input:string) =

        input.Split [|','; '-'|] |> Seq.map int |> Array.ofSeq

    let IsOneFullyContainedWithinTheOther (pair:array<int>) =

        ( pair[0] <= pair[2] && pair[1] >= pair[3] ) || ( pair[0] >= pair[2] && pair[1] <= pair[3] )

    let GetNumberOfPairsWhereOneRangeFullyContainsTheOther (elfAssignmentPairs:seq<string>) =

       elfAssignmentPairs
            |> Seq.filter (ParseInput >> IsOneFullyContainedWithinTheOther)
            |> Seq.length
