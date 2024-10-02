namespace AoC2017.Tests

open NUnit.Framework
open AoC2017

[<TestFixture>]
type Day03Part1() =

    // Ring 0

    [<Test>]
    member _.TestWalk0001() = Assert.AreEqual(0, Day03Part1.walk 1)

    // Ring 1

    [<Test>]
    member _.TestWalk0002() = Assert.AreEqual(1, Day03Part1.walk 2)

    [<Test>]
    member _.TestWalk0003() = Assert.AreEqual(2, Day03Part1.walk 3)

    [<Test>]
    member _.TestWalk0004() = Assert.AreEqual(1, Day03Part1.walk 4)

    [<Test>]
    member _.TestWalk0005() = Assert.AreEqual(2, Day03Part1.walk 5)

    [<Test>]
    member _.TestWalk0006() = Assert.AreEqual(1, Day03Part1.walk 6)

    [<Test>]
    member _.TestWalk0007() = Assert.AreEqual(2, Day03Part1.walk 7)

    [<Test>]
    member _.TestWalk0008() = Assert.AreEqual(1, Day03Part1.walk 8)

    [<Test>]
    member _.TestWalk0009() = Assert.AreEqual(2, Day03Part1.walk 9)


    // Ring 2

    [<Test>]
    member _.TestWalk0010() = Assert.AreEqual(3, Day03Part1.walk 10)

    [<Test>]
    member _.TestWalk0011() = Assert.AreEqual(2, Day03Part1.walk 11)

    [<Test>]
    member _.TestWalk0012() = Assert.AreEqual(3, Day03Part1.walk 12)

    [<Test>]
    member _.TestWalk0013() = Assert.AreEqual(4, Day03Part1.walk 13)

    [<Test>]
    member _.TestWalk0014() = Assert.AreEqual(3, Day03Part1.walk 14)

    [<Test>]
    member _.TestWalk0015() = Assert.AreEqual(2, Day03Part1.walk 15)

    [<Test>]
    member _.TestWalk0016() = Assert.AreEqual(3, Day03Part1.walk 16)

    [<Test>]
    member _.TestWalk0017() = Assert.AreEqual(4, Day03Part1.walk 17)

    [<Test>]
    member _.TestWalk0018() = Assert.AreEqual(3, Day03Part1.walk 18)

    [<Test>]
    member _.TestWalk0019() = Assert.AreEqual(2, Day03Part1.walk 19)

    [<Test>]
    member _.TestWalk0020() = Assert.AreEqual(3, Day03Part1.walk 20)

    [<Test>]
    member _.TestWalk0021() = Assert.AreEqual(4, Day03Part1.walk 21)

    [<Test>]
    member _.TestWalk0022() = Assert.AreEqual(3, Day03Part1.walk 22)

    [<Test>]
    member _.TestWalk0023() = Assert.AreEqual(2, Day03Part1.walk 23)

    // Example

    [<Test>]
    member _.TestWalk1024() = Assert.AreEqual(31, Day03Part1.walk 1024)
