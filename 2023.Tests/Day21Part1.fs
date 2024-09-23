namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day21Part1 () =

    [<DefaultValue>] val mutable example : char[,]
    
    [<SetUp>]
    member this.SetUp() =
        let input = [|"..........."; ".....###.#."; ".###.##..#."; "..#.#...#.."; "....#.#...."; ".##..S####."; ".##..#...#."; ".......##.."; ".##.#.####."; ".##..##.##."; "..........."|]
        this.example <- Day21Part1.getPlots(input)

    [<Test>]
    member this.findS() =
        Assert.AreEqual((5, 5), Day21Part1.findS(this.example))

    [<Test>]
    member this.move1() =
        CollectionAssert.AreEqual([|(4,5); (5,4)|], Day21Part1.moves([|(5,5)|], this.example))

    [<Test>]
    member this.moveN1() =
        CollectionAssert.AreEqual([|(4,5); (5,4)|], Day21Part1.movesN([|(5,5)|], this.example, 1))

    [<Test>]
    member this.moveN2() =
        CollectionAssert.AreEqual([|(3,5); (4,6); (5,3); (5,5)|], Day21Part1.movesN([|(5,5)|], this.example, 2))

    [<Test>]
    member this.moveN3() =
        CollectionAssert.AreEqual([|(3,4); (3,6); (4,5); (4,7); (5,4); (6,3)|], Day21Part1.movesN([|(5,5)|], this.example, 3))

    [<Test>]
    member this.moveN6() =
        let expected = [|(0,4); (1,3); (1,7); (2,4); (3,3); (3,5); (3,7); (3,9); (4,6); (5,3); (5,5); (5,7); (6,6); (7,3); (8,2); (8,4)|]
        CollectionAssert.AreEqual(expected, Day21Part1.movesN([|(5,5)|], this.example, 6))

    [<Test>]
    member this.countN6() =
        let expected = [|(0,4); (1,3); (1,7); (2,4); (3,3); (3,5); (3,7); (3,9); (4,6); (5,3); (5,5); (5,7); (6,6); (7,3); (8,2); (8,4)|]
        Assert.AreEqual(16, Day21Part1.countN([|(5,5)|], this.example, 6))