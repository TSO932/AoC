namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day04Part2 () =

    [<Test>]
    member _.Example1() = Assert.AreEqual((1, seq {2..5}), Day04Part2.getNewCards "Card   1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53")
    [<Test>]
    member _.Example2() = Assert.AreEqual((2, seq {3..4}), Day04Part2.getNewCards "Card   2: 13 32 20 16 61 | 61 30 68 82 17 32 24 19")
    [<Test>]
    member _.Example3() = Assert.AreEqual((3,  seq {4..5}), Day04Part2.getNewCards "Card   3:  1 21 53 59 44 | 69 82 63 72 16 21 14  1")
    [<Test>]
    member _.Example4() = Assert.AreEqual((4, [|5|]), Day04Part2.getNewCards "Card   4: 41 92 73 84 69 | 59 84 76 51 58  5 54 83")
    [<Test>]
    member _.Example5() = Assert.AreEqual((5, Seq.empty), Day04Part2.getNewCards "Card   5: 87 83 26 28 32 | 88 30 70 12 93 22 82 36")
    [<Test>]
    member _.Example6() = Assert.AreEqual((6, Seq.empty), Day04Part2.getNewCards "Card   6: 31 18 13 56 72 | 74 77 10 23 35 67 36 11")

    