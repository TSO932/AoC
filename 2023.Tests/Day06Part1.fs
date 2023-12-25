namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day06Part1 () =


    [<Test>]
    member _.Example1() = Assert.AreEqual(4L, Day06Part1.countWinners (7L, 9L))


    [<Test>]
    member _.Example2() = Assert.AreEqual(8L, Day06Part1.countWinners (15L, 40L))

    
    [<Test>]
    member _.Example3() = Assert.AreEqual(9L, Day06Part1.countWinners (30L, 200L))

    
    [<Test>]
    member _.Part2() = Assert.AreEqual(39570185L, Day06Part1.countWinners (53837288L, 333163512891532L))