namespace AoC2017.Tests

open NUnit.Framework
open AoC2017

[<TestFixture>]
type Day03Part2() =

    [<Test>]
    member _.TestGetVal01() = Assert.AreEqual(2, Day03Part2.getVal 1)

    [<Test>]
    member _.TestGetVal02() = Assert.AreEqual(4, Day03Part2.getVal 2)

    [<Test>]
    member _.TestGetVal03() = Assert.AreEqual(4, Day03Part2.getVal 3)

    [<Test>]
    member _.TestGetVal04() = Assert.AreEqual(5, Day03Part2.getVal 4)

    [<Test>]
    member _.TestGetVal05() = Assert.AreEqual(10, Day03Part2.getVal 5)

    [<Test>]
    member _.TestGetVal09() = Assert.AreEqual(10, Day03Part2.getVal 9)

    [<Test>]
    member _.TestGetVal10() = Assert.AreEqual(11, Day03Part2.getVal 10)

    [<Test>]
    member _.TestGetVal11() = Assert.AreEqual(23, Day03Part2.getVal 11)

    [<Test>]
    member _.TestGetVal22() = Assert.AreEqual(23, Day03Part2.getVal 22)

    [<Test>]
    member _.TestGetVal23() = Assert.AreEqual(25, Day03Part2.getVal 23)

    [<Test>]
    member _.TestGetVal24() = Assert.AreEqual(25, Day03Part2.getVal 24)

    [<Test>]
    member _.TestGetVal25() = Assert.AreEqual(26, Day03Part2.getVal 25)
    
    [<Test>]
    member _.TestGetVal26() = Assert.AreEqual(54, Day03Part2.getVal 26)

    [<Test>]
    member _.TestGetVal53() = Assert.AreEqual(54, Day03Part2.getVal 53)

    [<Test>]
    member _.TestGetVal54() = Assert.AreEqual(57, Day03Part2.getVal 54)
    
    [<Test>]
    member _.TestGetVal56() = Assert.AreEqual(57, Day03Part2.getVal 56)

    [<Test>]
    member _.TestGetVal57() = Assert.AreEqual(59, Day03Part2.getVal 57)
