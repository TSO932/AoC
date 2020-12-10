namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day10Part2 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(8, Day10Part2.calculate (File.ReadAllLines("../../../data/Day10/test1.txt")))

    [<Test>]
    member this.Example2() = Assert.AreEqual(19208, Day10Part2.calculate (File.ReadAllLines("../../../data/Day10/test2.txt")))