namespace AoC2017.Tests

open NUnit.Framework
open AoC2017

[<TestFixture>] 
type Day02Part1 () =

    [<Test>]
    member _.ExampleRow1() = Assert.AreEqual(8, Day02Part1.getDifference "5 1 9 5")

    [<Test>]
    member _.ExampleRow2() = Assert.AreEqual(4, Day02Part1.getDifference "7 5 3")

    [<Test>]
    member _.ExampleRow3() = Assert.AreEqual(6, Day02Part1.getDifference "2 4 6 8")

    [<Test>]
    member _.Tabbed() = Assert.AreEqual(5, Day02Part1.getDifference "7\t2")

    [<Test>]
    member _.Example() = Assert.AreEqual(18, Day02Part1.checkSum [|"5 1 9 5"; "7 5 3"; "2 4 6 8"|])
