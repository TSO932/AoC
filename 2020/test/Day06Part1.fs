namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day06Part1 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(11, Day06Part1.countYeses (File.ReadAllLines("../../../data/Day06/test1.txt")))
