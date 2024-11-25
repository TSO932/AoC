namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day20Part1 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(20899048083289L, Day20Part1.findCorners (File.ReadAllLines("../../../data/Day20/test1.txt")))