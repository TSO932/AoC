namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day14Part2 () =

    [<Test>]
    member _.Example() =
        let comet = { Day14Part1.Speed = 14; Day14Part1.Duration = 10; Day14Part1.Rest = 127 }
        let dancer = { Day14Part1.Speed = 16; Day14Part1.Duration = 11; Day14Part1.Rest = 162 }
        Assert.AreEqual(689, Day14Part2.getWinningPointScore ([|comet; dancer|], 1000))
