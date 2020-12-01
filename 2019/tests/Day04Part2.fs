namespace AoC2019.Tests

open NUnit.Framework
open AoC2019

[<TestFixture>] 
type Day04Part2 () =

    [<Test>]
    member this.isNotDecreasing_DigitsAreEqual() = Assert.AreEqual(true, Day04Part1.isNotDecreasing(11))

    [<Test>]
    member this.isNotDecreasing_IncreasingDigits() = Assert.AreEqual(true, Day04Part2.isNotDecreasing(12))

    [<Test>]
    member this.isNotDecreasing_DecreasingDigits() = Assert.AreEqual(false, Day04Part2.isNotDecreasing(10))

    [<Test>]
    member this.isNotDecreasing_FinalPairIsFalse() = Assert.AreEqual(false, Day04Part2.isNotDecreasing(111110))

    [<Test>]
    member this.isWinningAtSnap_Snap() = Assert.AreEqual(true, Day04Part2.isWinningAtSnap(11))

    [<Test>]
    member this.isWinningAtSnap_NotSnap() = Assert.AreEqual(false, Day04Part2.isWinningAtSnap(12))

    [<Test>]
    member this.isWinningAtSnap_FinalPairMatches() = Assert.AreEqual(true, Day04Part2.isWinningAtSnap(123455))

    [<Test>]
    member this.isWinningAtSnap_Example1() = Assert.AreEqual(true, Day04Part2.isWinningAtSnap(112233))

    [<Test>]
    member this.isWinningAtSnap_Example2() = Assert.AreEqual(false, Day04Part2.isWinningAtSnap(123444))

    [<Test>]
    member this.isWinningAtSnap_Example3() = Assert.AreEqual(true, Day04Part2.isWinningAtSnap(111122))
