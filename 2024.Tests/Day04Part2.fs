namespace _2024.Tests

open NUnit.Framework
open _2024

[<TestFixture>] 
type Day04Part2 () =

    [<Test>]
    member _.Example() =
    
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

        Assert.That(Day04Part2.run(input), Is.EqualTo(9))


