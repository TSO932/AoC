namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day03Part2 () =

    [<Test>]
    member _.CountExample1() = Assert.AreEqual(3, Day03Part2.countHouses ("^>"))

    [<Test>]
    member _.CountExample2() = Assert.AreEqual(3, Day03Part2.countHouses ("^>v<"))

    [<Test>]
    member _.CountExample3() = Assert.AreEqual(11, Day03Part2.countHouses ("^v^v^v^v^v"))

