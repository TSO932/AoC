namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day06Part2 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(6, Day06Part2.countYeses (File.ReadAllLines("../../../data/Day06/test1.txt")))
