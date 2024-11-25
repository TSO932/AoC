namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day01Part2 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(241861950, Day01Part2.fixExpenses (File.ReadAllLines("../../../data/Day01/test1.txt")))