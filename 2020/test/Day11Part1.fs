namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day11Part1 () =

    [<Test>]
    member this.Test0() = Assert.AreEqual(8, Day11Part1.countSeats (File.ReadAllLines("../../../data/Day11/test0.txt")))

    [<Test>]
    member this.Test00() = Assert.AreEqual(8, Day11Part1.countSeats (File.ReadAllLines("../../../data/Day11/test00.txt")))

    [<Test>]
    member this.Example1() = Assert.AreEqual(37, Day11Part1.countSeats (File.ReadAllLines("../../../data/Day11/test1.txt")))