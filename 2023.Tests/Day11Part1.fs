namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day11Part1 () =

    [<Test>]
    member _.Expand() =
        let expected = array2D [|[|'.'; '.'; 'C'; 'A'|]; [|'.'; '.'; '.'; '.'|]; [|'.'; '.'; '.'; '.'|]; [|'.'; '.'; 'D'; 'B'|]; |]
        CollectionAssert.AreEqual(expected, Day11Part1.expand ([|"A.B"; "C.D"; "..."|]))

    [<Test>]
    member _.FindGalaxies() =
        let input = array2D [|[|'.'; '.'; '#'; '#'|]; [|'.'; '.'; '.'; '.'|]; [|'.'; '.'; '.'; '.'|]; [|'.'; '.'; '#'; '#'|]; |]
        CollectionAssert.AreEqual([|(3, 3); (2, 3); (3, 0); (2, 0)|], Day11Part1.findGalaxies (input))

    [<Test>]
    member _.GetSum() =
        let input = [|"...#......"; ".......#.."; "#........."; ".........."; "......#..."; ".#........"; ".........#"; ".........."; ".......#.."; "#...#....."|]
        Assert.AreEqual(374, Day11Part1.getSum (input))


    