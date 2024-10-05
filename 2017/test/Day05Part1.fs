namespace AoC2017.Tests

open NUnit.Framework
open AoC2017

[<TestFixture>]
type Day05Part1() =

    [<Test>]
    member _.Example() =
        Assert.AreEqual(5, Day05Part1.escapeMaze ["0"; "3"; "0"; "1"; "-3"])

