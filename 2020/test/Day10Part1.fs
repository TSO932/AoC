namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day10Part1 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(35, Day10Part1.calculate (File.ReadAllLines("../../../data/Day10/test1.txt")))

    [<Test>]
    member this.Example2() = Assert.AreEqual(220, Day10Part1.calculate (File.ReadAllLines("../../../data/Day10/test2.txt")))