namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day21Part1 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(5, Day21Part1.countSafeIngredients (File.ReadAllLines("../../../data/Day21/test1.txt")))