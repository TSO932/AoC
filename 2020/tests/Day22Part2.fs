namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day22Part2 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(29100, Day22Part2.playCombat (File.ReadAllLines("../../../data/Day22/test1.txt")))

    [<Test>]
    [<Ignore("Need to change the input processor to allow hands of unequal length.")>]
    member this.Example2() = Assert.AreEqual(105, Day22Part2.playCombat (File.ReadAllLines("../../../data/Day22/test2.txt")))
