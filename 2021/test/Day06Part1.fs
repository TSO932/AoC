namespace AoC2021.Tests

open NUnit.Framework
open AoC2021

[<TestFixture>] 
type Day06Part1 () =

    [<Test>]
    member _.example1() = Assert.AreEqual(26, Day06Part1.countFish("3,4,3,1,2", 18))

    [<Test>]
    member _.example2() = Assert.AreEqual(5934, Day06Part1.countFish("3,4,3,1,2", 80))
