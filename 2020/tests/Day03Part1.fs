namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day03Part1 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(7, Day03Part1.countTrees (File.ReadAllLines("../../../data/Day03/test1.txt")))