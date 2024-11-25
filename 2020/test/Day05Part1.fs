namespace AoC2020.Tests

open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day05Part1 () =

    [<Test>]
    member this.GetDecimalZero() = Assert.AreEqual(0, Day05Part1.getDecimal("0"))

    [<Test>]
    member this.GetDecimalOne() = Assert.AreEqual(1, Day05Part1.getDecimal("1"))
    
    [<Test>]
    member this.GetDecimalTwo() = Assert.AreEqual(2, Day05Part1.getDecimal("10"))

    [<Test>]
    member this.GetDecimal128() = Assert.AreEqual(128, Day05Part1.getDecimal("10000000"))

    [<Test>]
    member this.GetDecimal255() = Assert.AreEqual(255, Day05Part1.getDecimal("11111111"))

    [<Test>]
    member this.Example1a() = Assert.AreEqual((70, 7), Day05Part1.getSeatLocation("BFFFBBFRRR"))

    [<Test>]
    member this.Example2a() = Assert.AreEqual((14, 7), Day05Part1.getSeatLocation("FFFBBBFRRR"))

    [<Test>]
    member this.Example3a() = Assert.AreEqual((102, 4), Day05Part1.getSeatLocation("BBFFBBFRLL"))

    [<Test>]
    member this.Example1b() = Assert.AreEqual(567, Day05Part1.getSeatId("BFFFBBFRRR"))

    [<Test>]
    member this.Example2b() = Assert.AreEqual(119, Day05Part1.getSeatId("FFFBBBFRRR"))

    [<Test>]
    member this.Example3b() = Assert.AreEqual(820, Day05Part1.getSeatId("BBFFBBFRLL"))

    [<Test>]
    member this.Examples() = Assert.AreEqual(820, Day05Part1.findHighestSeatId(["BFFFBBFRRR"; "BBFFBBFRLL"; "FFFBBBFRRR"]))


