namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day19Part2 () =

    [<Test>]
    member this.CountValidMessagesPart1() = Assert.AreEqual(3, Day19Part1.countValidMessages (File.ReadAllLines("../../../data/Day19/test3.txt")))

    [<Test>]
    member this.CountValidMessagesPart2() = Assert.AreEqual(12, Day19Part2.countValidMessages (File.ReadAllLines("../../../data/Day19/test3.txt")))
