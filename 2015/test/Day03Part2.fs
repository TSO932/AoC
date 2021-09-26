namespace AoC2015.Tests

open System.IO
open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day03Part2 () =

    [<Test>]
    member this.CountExample1() = Assert.AreEqual(3, Day03Part2.countHouses ("^>"))

    [<Test>]
    member this.CountExample2() = Assert.AreEqual(3, Day03Part2.countHouses ("^>v<"))

    [<Test>]
    member this.CountExample3() = Assert.AreEqual(11, Day03Part2.countHouses ("^v^v^v^v^v"))

