namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day14Part1 () =

    [<Test>]
    member _.Parse() = Assert.AreEqual({Day14Part1.Speed = 14 ; Day14Part1.Duration = 10 ; Day14Part1.Rest = 127}, Day14Part1.parseReindeerPerformanceStats ("Comet can fly 14 km/s for 10 seconds, but then must rest for 127 seconds."))

    [<Test>]
    member _.GetDistanceComet() = Assert.AreEqual(1120, Day14Part1.getDistance ({ Day14Part1.Speed = 14; Day14Part1.Duration = 10; Day14Part1.Rest = 127 }, 1000))

    [<Test>]
    member _.GetDistanceDancer() = Assert.AreEqual(1056, Day14Part1.getDistance ({ Day14Part1.Speed = 16; Day14Part1.Duration = 11; Day14Part1.Rest = 162 }, 1000))


