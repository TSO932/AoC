namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day21Part2 () =

    [<Test>]
    member _.Find() = Assert.AreEqual(188, Day21Part2.findDearestLosingOption())
    