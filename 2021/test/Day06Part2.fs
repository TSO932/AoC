namespace AoC2021.Tests

open NUnit.Framework
open AoC2021

[<TestFixture>] 
type Day06Part2 () =

    [<Test>]
    member _.example() = Assert.AreEqual(26984457539L, Day06Part2.countFish("3,4,3,1,2", 80))
