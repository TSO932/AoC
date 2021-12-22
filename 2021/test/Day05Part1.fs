namespace AoC2021.Tests

open NUnit.Framework
open AoC2021

[<TestFixture>] 
type Day05Part1 () =

    [<Test>]
    member _.countPointsWithNOrMore() = Assert.AreEqual(3, Day05Part1.countPointsWithNOrMore(array2D [[0; 1; 9];
                                                                                                      [4; 1; 0];
                                                                                                      [1; 2; 0]]))

    [<Test>]
    member _.applyVerticalLine() = CollectionAssert.AreEqual(array2D [[0; 1; 10]; [4; 1; 1]; [1; 2; 0]],
                                                                Day05Part1.applyLine(array2D [[0; 1; 9]; [4; 1; 0]; [1; 2; 0]], 2, 0, 2, 1, false))

    [<Test>]
    member _.applyVerticalLineReverse() = CollectionAssert.AreEqual(array2D [[0; 1; 9]; [4; 2; 0]; [1; 3; 0]],
                                                                Day05Part1.applyLine(array2D [[0; 1; 9]; [4; 1; 0]; [1; 2; 0]], 1, 2, 1, 1, false))

    [<Test>]
    member _.applyHorizontalLine() = CollectionAssert.AreEqual(array2D [[1; 1; 9]; [5; 1; 0]; [2; 2; 0]],
                                                                Day05Part1.applyLine(array2D [[0; 1; 9]; [4; 1; 0]; [1; 2; 0]], 0, 0, 0, 2, false))

    [<Test>]
    member _.applyHorizontalLineReverse() = CollectionAssert.AreEqual(array2D [[0; 1; 9]; [4; 2; 0]; [1; 3; 0]],
                                                                Day05Part1.applyLine(array2D [[0; 1; 9]; [4; 1; 0]; [1; 2; 0]], 1, 2, 1, 1, false))

    [<Test>]
    member _.applyDot() = CollectionAssert.AreEqual(array2D [[0; 1; 9]; [4; 2; 0]; [1; 2; 0]],
                                                                Day05Part1.applyLine(array2D [[0; 1; 9]; [4; 1; 0]; [1; 2; 0]], 1, 1, 1, 1, false))

    [<Test>]
    member _.IgnoreDiagonalA() = CollectionAssert.AreEqual(array2D [[0; 1; 9]; [4; 1; 0]; [1; 2; 0]],
                                                                Day05Part1.applyLine(array2D [[0; 1; 9]; [4; 1; 0]; [1; 2; 0]], 0, 0, 2, 2, false))

    [<Test>]
    member _.IgnoreDiagonalB() = CollectionAssert.AreEqual(array2D [[0; 1; 9]; [4; 1; 0]; [1; 2; 0]],
                                                                Day05Part1.applyLine(array2D [[0; 1; 9]; [4; 1; 0]; [1; 2; 0]], 2, 2, 1, 1, false))

    [<Test>]
    member _.IgnoreDiagonalC() = CollectionAssert.AreEqual(array2D [[0; 1; 9]; [4; 1; 0]; [1; 2; 0]],
                                                                Day05Part1.applyLine(array2D [[0; 1; 9]; [4; 1; 0]; [1; 2; 0]], 0, 2, 2, 0, false))

    [<Test>]
    member _.IgnoreDiagonalD() = CollectionAssert.AreEqual(array2D [[0; 1; 9]; [4; 1; 0]; [1; 2; 0]],
                                                                Day05Part1.applyLine(array2D [[0; 1; 9]; [4; 1; 0]; [1; 2; 0]], 1, 0, 0, 1, false))

    [<Test>]
    member _.ApplyDiagonalA() = CollectionAssert.AreEqual(array2D [[1; 1; 9]; [4; 2; 0]; [1; 2; 1]],
                                                                Day05Part1.applyLine(array2D [[0; 1; 9]; [4; 1; 0]; [1; 2; 0]], 0, 0, 2, 2, true))

    [<Test>]
    member _.ApplyDiagonalB() = CollectionAssert.AreEqual(array2D [[0; 1; 9]; [4; 2; 0]; [1; 2; 1]],
                                                                Day05Part1.applyLine(array2D [[0; 1; 9]; [4; 1; 0]; [1; 2; 0]], 2, 2, 1, 1, true))

    [<Test>]
    member _.ApplyDiagonalC() = CollectionAssert.AreEqual(array2D [[0; 1; 10]; [4; 2; 0]; [2; 2; 0]],
                                                                Day05Part1.applyLine(array2D [[0; 1; 9]; [4; 1; 0]; [1; 2; 0]], 0, 2, 2, 0, true))

    [<Test>]
    member _.ApplyDiagonalD() = CollectionAssert.AreEqual(array2D [[0; 2; 9]; [5; 1; 0]; [1; 2; 0]],
                                                                Day05Part1.applyLine(array2D [[0; 1; 9]; [4; 1; 0]; [1; 2; 0]], 1, 0, 0, 1, true))

    [<Test>]
    member _.Line() =
        let line = Day05Part1.Line("3,8 -> 5,9")
        Assert.AreEqual(3, line.X1)
        Assert.AreEqual(5, line.X2)
        Assert.AreEqual(8, line.Y1)
        Assert.AreEqual(9, line.Y2)

    [<Test>]
    member _.Example() =
        let input = ["0,9 -> 5,9"; "8,0 -> 0,8"; "9,4 -> 3,4"; "2,2 -> 2,1"; "7,0 -> 7,4"; "6,4 -> 2,0"; "0,9 -> 2,9"; "3,4 -> 1,4"; "0,0 -> 8,8"; "5,5 -> 8,2"]
        Assert.AreEqual(5, Day05Part1.findCrossings(input))
