namespace AoC2020.Tests

open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day05Part2() =

    [<Test>]
    member this.Nothing() = Assert.AreEqual(Seq.empty, Day05Part2.findMySeat(["BFFFBBFRRR"; "BBFFBBFRLL"; "FFFBBBFRRR"]))
    member this.Two() = Assert.AreEqual(seq {2}, Day05Part2.findMySeat(["FFFFFFFLLL"; "FFFFFFFLLR"; "FFFFFFFLRR"]))

