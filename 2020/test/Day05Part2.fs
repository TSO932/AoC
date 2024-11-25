namespace AoC2020.Tests

open System
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day05Part2() =

    [<Test>]
    member this.Nothing() = Assert.Throws<ArgumentException> (fun() -> Day05Part2.findMySeat(["BFFFBBFRRR"; "BBFFBBFRLL"; "FFFBBBFRRR"]) |> ignore) |> ignore

    [<Test>]
    member this.Two() = Assert.AreEqual(2, Day05Part2.findMySeat(["FFFFFFFLLL"; "FFFFFFFLLR"; "FFFFFFFLRR"]))

