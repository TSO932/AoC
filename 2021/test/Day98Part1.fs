namespace AoC2021.Tests

open NUnit.Framework
open AoC2021

[<TestFixture>] 
type Day98Part1 () =

    [<DefaultValue>] val mutable example  : seq<string>

    [<SetUp>]
    member this.SetUp() =
        this.example <-
            [| "v...>>.vv>"; 
            ".vv>>.vv..";
            ">>.>v>...v";
            ">>v>>.>.v.";
            "v>v.vv.v..";
            ">.>>..v...";
            ".vv..>.>v.";
            "v.v..>>v.v" |]

    [<Test>]
    member this.getPointAndVelocity() =

        let result = Day98Part1.getPointAndVelocity("19, 13, 30 @ -2,  1, -2")
        let expected = (19.0, 13.0, 30.0, -2.0, 1.0, -2.0)
        Assert.AreEqual(expected, result)

    [<Test>]
    member this.getLine1() =

        let result = Day98Part1.getLine(19.0, 13.0, 30.0, -2.0, 1.0, -2.0)
        let expected = (-0.5, -1.0, 22.5, 19.0, -2.0) 
        Assert.AreEqual(expected, result)

    [<Test>]
    member this.getLine2() =

        let result = Day98Part1.getLine(18.0, 19.0, 22.0, -1.0, -1.0, -2.0)
        let expected = (1.0, -1.0, 1.0, 18.0, -1.0) 
        Assert.AreEqual(expected, result)

    [<Test>]
    member this.getLine3() =
        let result = Day98Part1.getLine(20.0, 25.0, 34.0, -2.0, -2.0, -4.0)
        let expected = (1.0, -1.0, 5.0, 20.0, -2.0) 
        Assert.AreEqual(expected, result)

    [<Test>]
    member this.getIntersection12() =

        let result = Day98Part1.getIntersection((-0.5, -1.0, 22.5, 19.0, -2.0), (1.0, -1.0, 1.0, 18.0, -1.0) )
        let expected = Some (14.333333333333334, 15.333333333333334)
        Assert.AreEqual(expected, result)

    [<Test>]
    member this.getIntersection23() =

        let result = Day98Part1.getIntersection((1.0, -1.0, 1.0, 18.0, -1.0), (1.0, -1.0, 5.00, 20.0, -2.0)  )
        let expected = None
        Assert.AreEqual(expected, result)

    [<Test>]
    member this.isInRange12() =

        let result = Day98Part1.isInRange(Some (14.333333333333334, 15.333333333333334), Day98Part1.testRule)
        Assert.AreEqual(true, result)

    [<Test>]
    member this.isInRange23() =

        let result = Day98Part1.isInRange(None, Day98Part1.testRule)
        Assert.AreEqual(false, result)

    [<Test>]
    member this.isInRangeFalseOutside() =

        let result = Day98Part1.isInRange(Some (2.0, 3.0), Day98Part1.testRule)
        Assert.AreEqual(false, result)

    [<Test>]
    member this.getIntersectionInPast() =

        let lineA = Day98Part1.getLine(20.0, 25.0, 34.0, -2.0, -2.0, -4.0)
        let lineB = Day98Part1.getLine(20.0, 19.0, 15.0, 1.0, -5.0, -2.0)
        let result = Day98Part1.getIntersection(lineA, lineB)
        Assert.AreEqual(None, result)

    [<Test>]
    member this.example1() =
        let lineA = Day98Part1.getLine(Day98Part1.getPointAndVelocity("19, 13, 30 @ -2, 1, -2"))
        let lineB = Day98Part1.getLine(Day98Part1.getPointAndVelocity("18, 19, 22 @ -1, -1, -2"))
        let result = Day98Part1.isInRange(Day98Part1.getIntersection(lineA, lineB), Day98Part1.testRule)
        Assert.AreEqual(true, result)

    [<Test>]
    member this.example2() =
        let lineA = Day98Part1.getLine(Day98Part1.getPointAndVelocity("19, 13, 30 @ -2, 1, -2"))
        let lineB = Day98Part1.getLine(Day98Part1.getPointAndVelocity("20, 25, 34 @ -2, -2, -4"))
        let result = Day98Part1.isInRange(Day98Part1.getIntersection(lineA, lineB), Day98Part1.testRule)
        Assert.AreEqual(true, result)

    [<Test>]
    member this.example3() =
        let lineA = Day98Part1.getLine(Day98Part1.getPointAndVelocity("19, 13, 30 @ -2, 1, -2"))
        let lineB = Day98Part1.getLine(Day98Part1.getPointAndVelocity("12, 31, 28 @ -1, -2, -1"))
        let result = Day98Part1.isInRange(Day98Part1.getIntersection(lineA, lineB), Day98Part1.testRule)
        Assert.AreEqual(false, result)

    [<Test>]
    member this.example4() =
        let lineA = Day98Part1.getLine(Day98Part1.getPointAndVelocity("19, 13, 30 @ -2, 1, -2"))
        let lineB = Day98Part1.getLine(Day98Part1.getPointAndVelocity("20, 19, 15 @ 1, -5, -3"))
        let result = Day98Part1.isInRange(Day98Part1.getIntersection(lineA, lineB), Day98Part1.testRule)
        Assert.AreEqual(false, result)

    [<Test>]
    member this.example5() =
        let lineA = Day98Part1.getLine(Day98Part1.getPointAndVelocity("18, 19, 22 @ -1, -1, -2"))
        let lineB = Day98Part1.getLine(Day98Part1.getPointAndVelocity("20, 25, 34 @ -2, -2, -4"))
        let result = Day98Part1.isInRange(Day98Part1.getIntersection(lineA, lineB), Day98Part1.testRule)
        Assert.AreEqual(false, result)

    [<Test>]
    member this.example6() =
        let lineA = Day98Part1.getLine(Day98Part1.getPointAndVelocity("18, 19, 22 @ -1, -1, -2"))
        let lineB = Day98Part1.getLine(Day98Part1.getPointAndVelocity("12, 31, 28 @ -1, -2, -1"))
        let result = Day98Part1.isInRange(Day98Part1.getIntersection(lineA, lineB), Day98Part1.testRule)
        Assert.AreEqual(false, result)

    [<Test>]
    member this.example7() =
        let lineA = Day98Part1.getLine(Day98Part1.getPointAndVelocity("18, 19, 22 @ -1, -1, -2"))
        let lineB = Day98Part1.getLine(Day98Part1.getPointAndVelocity("20, 19, 15 @ 1, -5, -3"))
        let result = Day98Part1.isInRange(Day98Part1.getIntersection(lineA, lineB), Day98Part1.testRule)
        Assert.AreEqual(false, result)

    [<Test>]
    member this.example8() =
        let lineA = Day98Part1.getLine(Day98Part1.getPointAndVelocity("20, 25, 34 @ -2, -2, -4"))
        let lineB = Day98Part1.getLine(Day98Part1.getPointAndVelocity("12, 31, 28 @ -1, -2, -1"))
        let result = Day98Part1.isInRange(Day98Part1.getIntersection(lineA, lineB), Day98Part1.testRule)
        Assert.AreEqual(false, result)

    [<Test>]
    member this.example9() =
        let lineA = Day98Part1.getLine(Day98Part1.getPointAndVelocity("20, 25, 34 @ -2, -2, -4"))
        let lineB = Day98Part1.getLine(Day98Part1.getPointAndVelocity("20, 19, 15 @ 1, -5, -3"))
        let result = Day98Part1.isInRange(Day98Part1.getIntersection(lineA, lineB), Day98Part1.testRule)
        Assert.AreEqual(false, result)

    [<Test>]
    member this.example10() =
        let lineA = Day98Part1.getLine(Day98Part1.getPointAndVelocity("12, 31, 28 @ -1, -2, -1"))
        let lineB = Day98Part1.getLine(Day98Part1.getPointAndVelocity("20, 19, 15 @ 1, -5, -3"))
        let result = Day98Part1.isInRange(Day98Part1.getIntersection(lineA, lineB), Day98Part1.testRule)
        Assert.AreEqual(false, result)

    [<Test>]
    member this.all() =
        let input = seq {"19, 13, 30 @ -2,  1, -2"; "18, 19, 22 @ -1, -1, -2"; "20, 25, 34 @ -2, -2, -4"; "12, 31, 28 @ -1, -2, -1"; "20, 19, 15 @  1, -5, -3"}

        let result = Day98Part1.getSumInternal(input, Day98Part1.testRule)
        Assert.AreEqual(2, result)


