namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day21Part1 () =

    [<Test>]
    member _.GetOptions() = Assert.AreEqual(1680, Seq.length (Day21Part1.getOptions()))

    [<Test>]
    member _.Fight() = Assert.AreEqual(true, Day21Part1.fight(Day21Part1.Stats(0, 5, 5, 8), Day21Part1.Stats(0, 7, 2, 12)))

    [<Test>]
    member _.Find() = Assert.AreEqual(111, Day21Part1.findCheapestWinningOption())
