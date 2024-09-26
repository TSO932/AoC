namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day13Part2 () =

    [<Test>]
    member _.Horizontal() =
        let input = [|"#...##..#"; "#....#..#"; "..##..###"; "#####.##."; "#####.##."; "..##..###"; "#....#..#"|]
        CollectionAssert.AreEqual([|4|], Day13Part2.findHoriz(input))

    [<Test>]
    member _.Vertical() =
        let input = [|"#.##..##."; "..#.##.#."; "##......#"; "##......#"; "..#.##.#."; "..##..##."; "#.#.##.#."|]
        CollectionAssert.AreEqual([|5|], Day13Part2.findVert(input))

    member _.Hundred() =
        let input = [|"#...##..#"; "#....#..#"; "..##..###"; "#####.##."; "#####.##."; "..##..###"; "#....#..#"|]
        CollectionAssert.AreEqual([|400|], Day13Part2.findHoriz100s(input))

    [<Test>]
    member _.GetSum() =
        let input = [|"#.##..##."; "..#.##.#."; "##......#"; "##......#"; "..#.##.#."; "..##..##."; "#.#.##.#."; ""; "#...##..#"; "#....#..#"; "..##..###"; "#####.##."; "#####.##."; "..##..###"; "#....#..#"|]
        Assert.AreEqual(400, Day13Part2.getSum(input))

    [<Test>]
    member _.RemoveMatchNoResult() =
        let input = [|0; 7; 0; 0; 0; 0|]
        Assert.AreEqual(0, Day13Part2.removeMatch(7, input))

    [<Test>]
    member _.RemoveMatchResult() =
        let input = [|0; 7; 0; 12; 0; 0|]
        Assert.AreEqual(12, Day13Part2.removeMatch(7, input))

    [<Test>]
    member _.RemoveMatchNoOrginal() =
        let input = [|0; 0; 0; 12; 0; 0|]
        Assert.AreEqual(12, Day13Part2.removeMatch(7, input))
    
    [<Test>]
    member _.GetVarients() =
        let input = [|"#."; ".#"|]
        let expected = [|[|".."; ".#"|]; [|"##"; ".#"|]; [|"#."; "##"|]; [|"#."; ".."|]|]
        Assert.AreEqual(expected, Day13Part2.getVarients(input))

    [<Test>]
    member _.GetVarientsUneven() =
        let input = [|"#.A"|]
        let expected = [|[|"..A"|]; [|"##A"|]; [|"#.#"|]|]
        Assert.AreEqual(expected, Day13Part2.getVarients(input))