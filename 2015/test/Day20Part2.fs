namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day20Part2 () =

    [<Test>]
    member _.GetScoreOneIsMaxedOut() = Assert.AreEqual(11*(3+17+51), Day20Part2.getScore(51))

    [<Test>]
    member _.GetScoreOneAndTwoAreMaxedOut() = Assert.AreEqual(11*(3+6+17+34+51+102), Day20Part2.getScore(102))
