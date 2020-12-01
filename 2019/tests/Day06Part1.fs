namespace AoC2019.Tests

open System.IO
open NUnit.Framework
open AoC2019

[<TestFixture>] 
type Day06Part1 () =

    [<Test>]
    member this.countOrbitsD()   = Assert.AreEqual(3, Day06Part1.countOrbits ("D",   Day06Part1.mapOfTheStars (File.ReadAllLines("../../../data/Day06/test1.txt"))))

    [<Test>]
    member this.countOrbitsL()   = Assert.AreEqual(7, Day06Part1.countOrbits ("L",   Day06Part1.mapOfTheStars (File.ReadAllLines("../../../data/Day06/test1.txt"))))

    [<Test>]
    member this.countOrbitsCOM() = Assert.AreEqual(0, Day06Part1.countOrbits ("COM", Day06Part1.mapOfTheStars (File.ReadAllLines("../../../data/Day06/test1.txt"))))

    [<Test>]
    member this.getTotalOrbitCount() = Assert.AreEqual(42, Day06Part1.getTotalOrbitCount (File.ReadAllLines("../../../data/Day06/test1.txt")))