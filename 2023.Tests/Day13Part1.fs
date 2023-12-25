namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day13Part1 () =

    [<Test>]
    member _.Horizontal() =
        let input = [|"#...##..#"; "#....#..#"; "..##..###"; "#####.##."; "#####.##."; "..##..###"; "#....#..#"|]
        Assert.AreEqual(4, Day13Part1.findHoriz(input))

    [<Test>]
    member _.Vertical() =
        let input = [|"#.##..##."; "..#.##.#."; "##......#"; "##......#"; "..#.##.#."; "..##..##."; "#.#.##.#."|]
        Assert.AreEqual(5, Day13Part1.findVert(input))

    [<Test>]
    member _.GetSum() =
        let input = [|"#.##..##."; "..#.##.#."; "##......#"; "##......#"; "..#.##.#."; "..##..##."; "#.#.##.#."; ""; "#...##..#"; "#....#..#"; "..##..###"; "#####.##."; "#####.##."; "..##..###"; "#....#..#"|]
        Assert.AreEqual(405, Day13Part1.getSum(input))


    