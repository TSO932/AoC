namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day21Part2 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual("mxmxvkd,sqjhc,fvjkl", Day21Part2.listDangerousIngredients (File.ReadAllLines("../../../data/Day21/test1.txt")))