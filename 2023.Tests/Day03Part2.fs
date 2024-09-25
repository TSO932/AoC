namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day03Part2 () =

    [<Test>]
    member _.GetSum() = Assert.AreEqual(467835, Day03Part2.getSum  ([|"467..114.."; "...*......"; "..35..633."; "......#..."; "617*......"; ".....+.58."; "..592....."; "......755."; "...$.*...."; ".664.598.."|]))
