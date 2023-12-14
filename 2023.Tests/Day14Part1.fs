namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day14Part1 () =

    [<Test>]
    member _.Tilt1() =
        let input    = [|'O'; 'O'; '.'; 'O'; '.'; 'O'; '.'; '.'; '#'; '#'|]
        let expected = [|'O'; 'O'; 'O'; 'O'; '.'; '.'; '.'; '.'; '#'; '#'|]
        CollectionAssert.AreEqual(expected, Day14Part1.tilt(input))

    [<Test>]
    member _.Tilt2() =
        let input    = [|'.'; '.'; '.'; 'O'; 'O'; 'O'; '.'; '.'; '.'; '.'|]
        let expected = [|'O'; 'O'; 'O'; '.'; '.'; '.'; '.'; '.'; '.'; '.'|]
        CollectionAssert.AreEqual(expected, Day14Part1.tilt(input))

    [<Test>]
    member _.Tilt3() =
        let input    = [|'.'; 'O'; '.'; '#'; '.'; 'O'; '.'; '.'; '.'; 'O'|]
        let expected = [|'O'; '.'; '.'; '#'; 'O'; 'O'; '.'; '.'; '.'; '.'|]
        CollectionAssert.AreEqual(expected, Day14Part1.tilt(input))

    
    [<Test>]
    member _.GetSum() =
        let input = [|"O....#...."; "O.OO#....#"; ".....##..."; "OO.#O....O"; ".O.....O#."; "O.#..O.#.#"; "..O..#O..O"; ".......O.."; "#....###.."; "#OO..#...."|]
        Assert.AreEqual(136, Day14Part1.getSum(input))

