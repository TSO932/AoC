namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day17Part2 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(848, Day17Part2.countActiveCells (File.ReadAllLines("../../../data/Day17/test1.txt")))