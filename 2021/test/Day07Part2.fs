namespace AoC2021.Tests

open NUnit.Framework
open AoC2021

[<TestFixture>] 
type Day07Part2 () =

    [<Test>]
    member _.example() = Assert.AreEqual(168, Day07Part2.findMinimum([16;1;2;0;4;2;7;1;2;14]))

