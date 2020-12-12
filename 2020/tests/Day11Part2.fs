namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day11Part2 () =

    [<Test>]
    member this.Test0() = Assert.AreEqual(8, Day11Part2.countSeats (File.ReadAllLines("../../../data/Day11/test0.txt")))

    [<Test>]
    member this.Test000() = Assert.AreEqual(8, Day11Part2.countSeats (File.ReadAllLines("../../../data/Day11/test000.txt")))

    [<Test>]
    member this.Test0000() = Assert.AreEqual(21, Day11Part2.countSeats (File.ReadAllLines("../../../data/Day11/test0000.txt")))

    [<Test>]
    member this.Example1() = Assert.AreEqual(26, Day11Part2.countSeats (File.ReadAllLines("../../../data/Day11/test1.txt")))