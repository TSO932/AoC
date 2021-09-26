namespace AoC2015.Tests

open System.IO
open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day03Part1 () =

    [<Test>]
    member this.NoMove() = Assert.AreEqual((7,18), Day03Part1.moveSleigh ('*', (7,18)))

    [<Test>]
    member this.North() = Assert.AreEqual((8,18), Day03Part1.moveSleigh ('^', (7,18)))

    [<Test>]
    member this.South() = Assert.AreEqual((6,18), Day03Part1.moveSleigh ('v', (7,18)))

    [<Test>]
    member this.East() = Assert.AreEqual((7,19), Day03Part1.moveSleigh ('>', (7,18)))

    [<Test>]
    member this.West() = Assert.AreEqual((7,17), Day03Part1.moveSleigh ('<', (7,18)))

    [<Test>]
    member this.Negatives() = Assert.AreEqual((-7,-19), Day03Part1.moveSleigh ('<', (-7,-18)))


    [<Test>]
    member this.MapExample1() = Assert.AreEqual(seq [(0, 0); (0, 1)], Day03Part1.mapPositions (">"))

    [<Test>]
    member this.MapExample2() = Assert.AreEqual(seq [(0, 0); (1, 0); (1, 1); (0, 1); (0, 0)], Day03Part1.mapPositions ("^>v<"))

    [<Test>]
    member this.CountExample1() = Assert.AreEqual(2, Day03Part1.countHouses (">"))

    [<Test>]
    member this.CountExample2() = Assert.AreEqual(4, Day03Part1.countHouses ("^>v<"))

    [<Test>]
    member this.CountExample3() = Assert.AreEqual(2, Day03Part1.countHouses ("^v^v^v^v^v"))

