namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day02Part1 () =

    [<Test>]
    member _.Example1() = Assert.AreEqual(58, Day02Part1.getAreaForPresent "2x3x4")

    [<Test>]
    member _.Example2() = Assert.AreEqual(43, Day02Part1.getAreaForPresent "1x1x10")

    [<Test>]
    member _.Total() = Assert.AreEqual(58 + 43, Day02Part1.getTotalArea [|"1x1x10"; "2x3x4"|])
