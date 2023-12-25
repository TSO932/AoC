namespace AoC2017.Tests

open NUnit.Framework
open AoC2017

[<TestFixture>] 
type Day02Part2 () =

    [<Test>]
    member _.ExampleRow1() = Assert.AreEqual(4, Day02Part2.getDivisions "5 9 2 8")

    [<Test>]
    member _.ExampleRow2() = Assert.AreEqual(3, Day02Part2.getDivisions "9 4 7 3")

    [<Test>]
    member _.ExampleRow3() = Assert.AreEqual(2, Day02Part2.getDivisions "3 8 6 5")

    [<Test>]
    member _.Example() = Assert.AreEqual(9, Day02Part2.getSum [|"5 9 2 8"; "9 4 7 3"; "3 8 6 5"|])
