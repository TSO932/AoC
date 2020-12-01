namespace AoC2019.Tests

open System.IO
open NUnit.Framework
open AoC2019

[<TestFixture>] 
type Day10Part1 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(((3, 4), 8), Day10Part1.findBestAsteroid (File.ReadAllLines("../../../data/Day10/test1.txt")))

    [<Test>]
    member this.Example2() = Assert.AreEqual(((5, 8), 33), Day10Part1.findBestAsteroid (File.ReadAllLines("../../../data/Day10/test2.txt")))

    [<Test>]
    member this.Example3() = Assert.AreEqual(((1, 2), 35), Day10Part1.findBestAsteroid (File.ReadAllLines("../../../data/Day10/test3.txt")))

    [<Test>]
    member this.Example4() = Assert.AreEqual(((6, 3), 41), Day10Part1.findBestAsteroid (File.ReadAllLines("../../../data/Day10/test4.txt")))

    [<Test>]
    member this.Example5() = Assert.AreEqual(((11, 13), 210), Day10Part1.findBestAsteroid (File.ReadAllLines("../../../data/Day10/test5.txt")))
