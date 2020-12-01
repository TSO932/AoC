namespace AoC2019.Tests

open System.IO
open NUnit.Framework
open AoC2019

[<TestFixture>] 
type Day06Part2 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(4, Day06Part2.getShortestTransfer (File.ReadAllLines("../../../data/Day06/test2.txt")))