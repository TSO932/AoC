namespace AoC2017.Tests

open NUnit.Framework
open AoC2017

[<TestFixture>]
type Day06Part2() =

    [<Test>]
    member _.Example() =
        Assert.AreEqual(4, Day06Part2.findRepeat [| 0; 2; 7; 0 |])
