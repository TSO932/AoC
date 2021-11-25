namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day20Part1 () =

    [<Test>]
    member _.GetScoreHouseNumber1Gets10Presents() = Assert.AreEqual(10, Day20Part1.getScore(1))

    [<Test>]
    member _.GetScoreHouseNumber2Gets30Presents() = Assert.AreEqual(30, Day20Part1.getScore(2))

    [<Test>]
    member _.GetScoreHouseNumber3Gets40Presents() = Assert.AreEqual(40, Day20Part1.getScore(3))

    [<Test>]
    member _.GetScoreHouseNumber4Gets70Presents() = Assert.AreEqual(70, Day20Part1.getScore(4))

    [<Test>]
    member _.GetScoreHouseNumber5Gets60Presents() = Assert.AreEqual(60, Day20Part1.getScore(5))

    [<Test>]
    member _.GetScoreHouseNumber6Gets120Presents() = Assert.AreEqual(120, Day20Part1.getScore(6))

    [<Test>]
    member _.GetScoreHouseNumber7Gets80Presents() = Assert.AreEqual(80, Day20Part1.getScore(7))

    [<Test>]
    member _.GetScoreHouseNumber8Gets150Presents() = Assert.AreEqual(150, Day20Part1.getScore(8))

    [<Test>]
    member _.GetScoreHouseNumber9Gets130Presents() = Assert.AreEqual(130, Day20Part1.getScore(9))

    [<Test>]
    member _.GetFirstHouseWithTargetScoreOrMore() = Assert.AreEqual(6, Day20Part1.getFirstHouseWithTargetScoreOrMore(120))

    [<Test>]
    member _.GetFirstHouseWithTargetScoreOrMoreExactMatch() = Assert.AreEqual(6, Day20Part1.getFirstHouseWithTargetScoreOrMore(120))

    [<Test>]
    member _.GetFirstHouseWithTargetScoreOrMoreNotExactMatch() = Assert.AreEqual(8, Day20Part1.getFirstHouseWithTargetScoreOrMore(125))

    [<Test>]
    member _.Get() = Assert.AreEqual(0, Day20Part1.getFirstHouseWithTargetScoreOrMore(33100000)) 