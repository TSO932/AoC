namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day09Part2 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(62, Day09Part2.findWeakness (File.ReadAllLines("../../../data/Day09/test1.txt"), 127L))