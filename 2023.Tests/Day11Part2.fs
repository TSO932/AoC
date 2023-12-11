namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day11Part2 () =

    [<Test>]
    member _.findEmptyRows() =
        let input = array2D [|[|'.'; '.'; '#'; '#'|]; [|'.'; '.'; '.'; '.'|]; [|'.'; '.'; '.'; '.'|]; [|'.'; '.'; '#'; '#'|]|]
        CollectionAssert.AreEqual([|1; 2|], Day11Part2.findEmptyRows (input))

    [<Test>]
    member _.findEmptyColumns() =
        let input = array2D [|[|'.'; '.'; '#'; '#'|]; [|'.'; '.'; '.'; '.'|]; [|'.'; '.'; '.'; '.'|]; [|'.'; '.'; '#'; '#'|]|]
        CollectionAssert.AreEqual([|0; 1|], Day11Part2.findEmptyColumns (input))
    
    [<Test>]
    member _.GetSum2() =
        let input = [|"...#......"; ".......#.."; "#........."; ".........."; "......#..."; ".#........"; ".........#"; ".........."; ".......#.."; "#...#....."|]
        Assert.AreEqual(374L, Day11Part2.getSumX (2L, input))

    [<Test>]
    member _.GetSum10() =
        let input = [|"...#......"; ".......#.."; "#........."; ".........."; "......#..."; ".#........"; ".........#"; ".........."; ".......#.."; "#...#....."|]
        Assert.AreEqual(1030L, Day11Part2.getSumX (10L, input))

    [<Test>]
    member _.GetSum100() =
        let input = [|"...#......"; ".......#.."; "#........."; ".........."; "......#..."; ".#........"; ".........#"; ".........."; ".......#.."; "#...#....."|]
        Assert.AreEqual(8410L, Day11Part2.getSumX (100L, input))