namespace _2024.Tests

open NUnit.Framework
open _2024

[<TestFixture>] 
type Day04Part1 () =

    [<Test>]
    member _.Example1() =
    
        let input = [
            "..X...";
            ".SAMX.";
            ".A..A.";
            "XMAS.S";
            ".X...."
            ]

        Assert.That(Day04Part1.run(input), Is.EqualTo(4))

    [<Test>]
    member _.Example2() =
    
        let input = [
            "MMMSXXMASM";
            "MSAMXMSMSA";
            "AMXSXMAAMM";
            "MSAMASMSMX";
            "XMASAMXAMM";
            "XXAMMXXAMA";
            "SMSMSASXSS";
            "SAXAMASAAA";
            "MAMMMXMMMM";
            "MXMXAXMASX"
            ]

        Assert.That(Day04Part1.run(input), Is.EqualTo(18))


