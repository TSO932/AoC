namespace AoC2017.Tests

open NUnit.Framework
open AoC2017

[<TestFixture>]
type Day05Part2() =

    [<Test>]
    member _.Example() =
        Assert.AreEqual(10, Day05Part2.escapeMaze ["0"; "3"; "0"; "1"; "-3"])

