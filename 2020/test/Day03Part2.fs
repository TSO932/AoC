namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day03Part2 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(336, Day03Part2.countTrees (File.ReadAllLines("../../../data/Day03/test1.txt")))