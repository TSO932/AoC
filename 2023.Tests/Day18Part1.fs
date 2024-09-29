namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day18Part1 () =

    [<Test>]
    member _.MoveRight() = 
        let expected = [|(1, 1); (4, 1)|]
        Assert.AreEqual(expected, Day18Part1.move([|(1, 1)|], 'R', 3))

    [<Test>]
    member _.MoveUp() = 
        let input = [|(3, 1); (4, 1)|]
        let expected = [|(3, 1); (4, 1); (4, 3)|]
        Assert.AreEqual(expected, Day18Part1.move(input, 'U', 2))

    [<Test>]
    member _.Parse() = 
        Assert.AreEqual(('R', 6), Day18Part1.parse("R 6 (#70c710)"))

    [<Test>]
    member _.GetCoords() =
        let input = seq { "R 6 (#70c710)"; "D 5 (#0dc571)"; "L 2 (#5713f0)"; "D 2 (#d2c081)"; "R 2 (#59c680)"; "D 2 (#411b91)"; "L 5 (#8ceee2)"; "U 2 (#caa173)"; "L 1 (#1b58a2)"; "U 2 (#caa171)"; "R 2 (#7807d2)"; "U 3 (#a77fa3)"; "L 2 (#015232)"; "U 2 (#7a21e3)"}
        let actual = Day18Part1.getCoords(input)
        Assert.AreEqual(15, Seq.length actual, "count")
        Assert.AreEqual((0, 0), Seq.head actual, "first")
        Assert.AreEqual((0, 0), Seq.last actual, "last")

        Assert.AreEqual(6, actual |> Seq.map fst |> Seq.max, "x max")
        Assert.AreEqual(0, actual |> Seq.map fst |> Seq.min, "x min")
        Assert.AreEqual(0, actual |> Seq.map snd |> Seq.max, "y max")
        Assert.AreEqual(-9, actual |> Seq.map snd |> Seq.min, "y min")

    [<Test>]
    member _.GetArea() =
        let input = seq { "R 6 (#70c710)"; "D 5 (#0dc571)"; "L 2 (#5713f0)"; "D 2 (#d2c081)"; "R 2 (#59c680)"; "D 2 (#411b91)"; "L 5 (#8ceee2)"; "U 2 (#caa173)"; "L 1 (#1b58a2)"; "U 2 (#caa171)"; "R 2 (#7807d2)"; "U 3 (#a77fa3)"; "L 2 (#015232)"; "U 2 (#7a21e3)"}
        Assert.AreEqual(62, Day18Part1.getArea(input))

    [<Test>]
    member _.GetArea3By3() =
        let input = seq {"D 2 a"; "R 2 a"; "U 2 a"; "L 2 a"}
        Assert.AreEqual(9, Day18Part1.getArea(input))


    [<Test>]
    member _.GetArea4By4() =
        let input = seq {"R 3 a"; "D 3 a"; "L 3 a"; "U 3 a"}
        Assert.AreEqual(16, Day18Part1.getArea(input))

    [<Test>]
    member _.GetArea1By3() =
        let input = seq {"R 2 a"; "L 2 a"}
        Assert.AreEqual(3, Day18Part1.getArea(input))

    [<Test>]
    member _.GetArea77() =
        let input = seq {"R 6 _"; "U 5 _"; "R 2 _"; "D 10 _"; "L 10 _"; "U 3 _"; "R 2 _"; "U 2 _"}
        Assert.AreEqual(77, Day18Part1.getArea(input))

    [<Test>]
    member _.GetArea20() =
        let input = seq {"R 2 _"; "D 1 _"; "R 2 _"; "U 1 _"; "R 2 _"; "D 2 _"; "L 6 _"; "U 2 _"}
        Assert.AreEqual(20, Day18Part1.getArea(input))


