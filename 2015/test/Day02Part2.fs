namespace AoC2015.Tests

open System.IO
open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day02Part2 () =

    [<Test>]
    member this.example1() = Assert.AreEqual(34, Day02Part2.getLengthForPresent "2x3x4")

    [<Test>]
    member this.example2() = Assert.AreEqual(14, Day02Part2.getLengthForPresent "1x1x10")

    [<Test>]
    member this.total() = Assert.AreEqual(34 + 14, Day02Part2.getTotalLength [|"1x1x10"; "2x3x4"|])
