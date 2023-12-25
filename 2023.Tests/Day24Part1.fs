namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>] 
type Day24Part1 () =

    [<Test>]
    member _.getPointAndVelocity() =

        let result = Day24Part1.getPointAndVelocity("19, 13, 30 @ -2,  1, -2")
        let expected = (19.0, 13.0, 30.0, -2.0, 1.0, -2.0)
        Assert.AreEqual(expected, result)

    [<Test>]
    member _.getLine1() =

        let result = Day24Part1.getLine(19.0, 13.0, 30.0, -2.0, 1.0, -2.0)
        let expected = (-0.5, -1.0, 22.5, 19.0, -2.0) 
        Assert.AreEqual(expected, result)

    [<Test>]
    member _.getLine2() =

        let result = Day24Part1.getLine(18.0, 19.0, 22.0, -1.0, -1.0, -2.0)
        let expected = (1.0, -1.0, 1.0, 18.0, -1.0) 
        Assert.AreEqual(expected, result)

    [<Test>]
    member _.getLine3() =
        let result = Day24Part1.getLine(20.0, 25.0, 34.0, -2.0, -2.0, -4.0)
        let expected = (1.0, -1.0, 5.0, 20.0, -2.0) 
        Assert.AreEqual(expected, result)

    [<Test>]
    member _.getIntersection12() =

        let result = Day24Part1.getIntersection((-0.5, -1.0, 22.5, 19.0, -2.0), (1.0, -1.0, 1.0, 18.0, -1.0) )
        let expected = Some (14.333333333333334, 15.333333333333334)
        Assert.AreEqual(expected, result)

    [<Test>]
    member _.getIntersection23() =

        let result = Day24Part1.getIntersection((1.0, -1.0, 1.0, 18.0, -1.0), (1.0, -1.0, 5.00, 20.0, -2.0)  )
        let expected = None
        Assert.AreEqual(expected, result)

    [<Test>]
    member _.isInRange12() =

        let result = Day24Part1.isInRange(Some (14.333333333333334, 15.333333333333334), Day24Part1.testRule)
        Assert.AreEqual(true, result)

    [<Test>]
    member _.isInRange23() =

        let result = Day24Part1.isInRange(None, Day24Part1.testRule)
        Assert.AreEqual(false, result)

    [<Test>]
    member _.isInRangeFalseOutside() =

        let result = Day24Part1.isInRange(Some (2.0, 3.0), Day24Part1.testRule)
        Assert.AreEqual(false, result)

    [<Test>]
    member _.getIntersectionInPast() =

        let lineA = Day24Part1.getLine(20.0, 25.0, 34.0, -2.0, -2.0, -4.0)
        let lineB = Day24Part1.getLine(20.0, 19.0, 15.0, 1.0, -5.0, -2.0)
        let result = Day24Part1.getIntersection(lineA, lineB)
        Assert.AreEqual(None, result)

    [<Test>]
    member _.example1() =
        let lineA = Day24Part1.getLine(Day24Part1.getPointAndVelocity("19, 13, 30 @ -2, 1, -2"))
        let lineB = Day24Part1.getLine(Day24Part1.getPointAndVelocity("18, 19, 22 @ -1, -1, -2"))
        let result = Day24Part1.isInRange(Day24Part1.getIntersection(lineA, lineB), Day24Part1.testRule)
        Assert.AreEqual(true, result)

    [<Test>]
    member _.example2() =
        let lineA = Day24Part1.getLine(Day24Part1.getPointAndVelocity("19, 13, 30 @ -2, 1, -2"))
        let lineB = Day24Part1.getLine(Day24Part1.getPointAndVelocity("20, 25, 34 @ -2, -2, -4"))
        let result = Day24Part1.isInRange(Day24Part1.getIntersection(lineA, lineB), Day24Part1.testRule)
        Assert.AreEqual(true, result)

    [<Test>]
    member _.example3() =
        let lineA = Day24Part1.getLine(Day24Part1.getPointAndVelocity("19, 13, 30 @ -2, 1, -2"))
        let lineB = Day24Part1.getLine(Day24Part1.getPointAndVelocity("12, 31, 28 @ -1, -2, -1"))
        let result = Day24Part1.isInRange(Day24Part1.getIntersection(lineA, lineB), Day24Part1.testRule)
        Assert.AreEqual(false, result)

    [<Test>]
    member _.example4() =
        let lineA = Day24Part1.getLine(Day24Part1.getPointAndVelocity("19, 13, 30 @ -2, 1, -2"))
        let lineB = Day24Part1.getLine(Day24Part1.getPointAndVelocity("20, 19, 15 @ 1, -5, -3"))
        let result = Day24Part1.isInRange(Day24Part1.getIntersection(lineA, lineB), Day24Part1.testRule)
        Assert.AreEqual(false, result)

    [<Test>]
    member _.example5() =
        let lineA = Day24Part1.getLine(Day24Part1.getPointAndVelocity("18, 19, 22 @ -1, -1, -2"))
        let lineB = Day24Part1.getLine(Day24Part1.getPointAndVelocity("20, 25, 34 @ -2, -2, -4"))
        let result = Day24Part1.isInRange(Day24Part1.getIntersection(lineA, lineB), Day24Part1.testRule)
        Assert.AreEqual(false, result)

    [<Test>]
    member _.example6() =
        let lineA = Day24Part1.getLine(Day24Part1.getPointAndVelocity("18, 19, 22 @ -1, -1, -2"))
        let lineB = Day24Part1.getLine(Day24Part1.getPointAndVelocity("12, 31, 28 @ -1, -2, -1"))
        let result = Day24Part1.isInRange(Day24Part1.getIntersection(lineA, lineB), Day24Part1.testRule)
        Assert.AreEqual(false, result)

    [<Test>]
    member _.example7() =
        let lineA = Day24Part1.getLine(Day24Part1.getPointAndVelocity("18, 19, 22 @ -1, -1, -2"))
        let lineB = Day24Part1.getLine(Day24Part1.getPointAndVelocity("20, 19, 15 @ 1, -5, -3"))
        let result = Day24Part1.isInRange(Day24Part1.getIntersection(lineA, lineB), Day24Part1.testRule)
        Assert.AreEqual(false, result)

    [<Test>]
    member _.example8() =
        let lineA = Day24Part1.getLine(Day24Part1.getPointAndVelocity("20, 25, 34 @ -2, -2, -4"))
        let lineB = Day24Part1.getLine(Day24Part1.getPointAndVelocity("12, 31, 28 @ -1, -2, -1"))
        let result = Day24Part1.isInRange(Day24Part1.getIntersection(lineA, lineB), Day24Part1.testRule)
        Assert.AreEqual(false, result)

    [<Test>]
    member _.example9() =
        let lineA = Day24Part1.getLine(Day24Part1.getPointAndVelocity("20, 25, 34 @ -2, -2, -4"))
        let lineB = Day24Part1.getLine(Day24Part1.getPointAndVelocity("20, 19, 15 @ 1, -5, -3"))
        let result = Day24Part1.isInRange(Day24Part1.getIntersection(lineA, lineB), Day24Part1.testRule)
        Assert.AreEqual(false, result)

    [<Test>]
    member _.example10() =
        let lineA = Day24Part1.getLine(Day24Part1.getPointAndVelocity("12, 31, 28 @ -1, -2, -1"))
        let lineB = Day24Part1.getLine(Day24Part1.getPointAndVelocity("20, 19, 15 @ 1, -5, -3"))
        let result = Day24Part1.isInRange(Day24Part1.getIntersection(lineA, lineB), Day24Part1.testRule)
        Assert.AreEqual(false, result)

    [<Test>]
    member _.all() =
        let input = seq {"19, 13, 30 @ -2,  1, -2"; "18, 19, 22 @ -1, -1, -2"; "20, 25, 34 @ -2, -2, -4"; "12, 31, 28 @ -1, -2, -1"; "20, 19, 15 @  1, -5, -3"}

        let result = Day24Part1.getSumInternal(input, Day24Part1.testRule)
        Assert.AreEqual(2, result)


