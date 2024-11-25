namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day08Part1 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(5, Day08Part1.runProgram (File.ReadAllLines("../../../data/Day08/test1.txt")))