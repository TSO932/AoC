namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day14Part2 () =
    
    [<Test>]
    member _.GetSum() =
        let input    = [|"O....#...."; "O.OO#....#"; ".....##..."; "OO.#O....O"; ".O.....O#."; "O.#..O.#.#"; "..O..#O..O"; ".......O.."; "#....###.."; "#OO..#...."|]
        Assert.AreEqual(136, Day14Part2.getSum(input))

