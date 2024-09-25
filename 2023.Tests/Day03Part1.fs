namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day03Part1 () =

    [<Test>]
    member _.GetSum() = Assert.AreEqual(4361, Day03Part1.getSum  ([|"467..114.."; "...*......"; "..35..633."; "......#..."; "617*......"; ".....+.58."; "..592....."; "......755."; "...$.*...."; ".664.598.."|]))

    [<Test>]
    member _.GetSumDigitSubstrings() = Assert.AreEqual(2356, Day03Part1.getSum  ([|"111..1.11."; "...*..*..*"; "......1111"|]))

    [<Test>]
    member _.GetNumber0() = Assert.AreEqual(0,Day03Part1.getNumber([|'.'; '.'; '1'; '2'; '3'; '.'; '.'; '.'; '.'; '.'|], 0) )

    [<Test>]
    member _.GetNumber1() = Assert.AreEqual(123,Day03Part1.getNumber([|'.'; '.'; '1'; '2'; '3'; '.'; '.'; '.'; '.'; '.'|], 1) )

    [<Test>]
    member _.GetNumber2() = Assert.AreEqual(123,Day03Part1.getNumber([|'.'; '.'; '1'; '2'; '3'; '.'; '.'; '.'; '.'; '.'|], 2) )

    [<Test>]
    member _.GetNumber3() = Assert.AreEqual(123,Day03Part1.getNumber([|'.'; '.'; '1'; '2'; '3'; '.'; '.'; '.'; '.'; '.'|], 3) )

    [<Test>]
    member _.GetNumber4() = Assert.AreEqual(123,Day03Part1.getNumber([|'.'; '.'; '1'; '2'; '3'; '.'; '.'; '.'; '.'; '.'|], 4) )

    [<Test>]
    member _.GetNumber5() = Assert.AreEqual(123,Day03Part1.getNumber([|'.'; '.'; '1'; '2'; '3'; '.'; '.'; '.'; '.'; '.'|], 5) )

    [<Test>]
    member _.GetNumber6() = Assert.AreEqual(0,Day03Part1.getNumber([|'.'; '.'; '1'; '2'; '3'; '.'; '.'; '.'; '.'; '.'|], 6) )

    [<Test>]
    member _.GetNumber9() = Assert.AreEqual(0,Day03Part1.getNumber([|'.'; '.'; '1'; '2'; '3'; '.'; '.'; '.'; '.'; '.'|], 9) )

    [<Test>]
    member _.GetNumberStart() = Assert.AreEqual(12345,Day03Part1.getNumber([|'1'; '2'; '3'; '4'; '5'; '.'; '.'; '.'; '.'; '.'|], 2) )

    [<Test>]
    member _.GetNumberEnd() = Assert.AreEqual(12345,Day03Part1.getNumber([|'.'; '.'; '.'; '.'; '.'; '1'; '2'; '3'; '4'; '5'|], 8) )

    [<Test>]
    member _.GetNumberAll() = Assert.AreEqual(12345,Day03Part1.getNumber([|'1'; '2'; '3'; '4'; '5'|], 3) )

    [<Test>]
    member _.GetNumberLeftRight() = Assert.AreEqual(4,Day03Part1.getNumber([|'1'; '.'; '3'|], 1) )

    [<Test>]
    member _.GetNumberMid() = Assert.AreEqual(123,Day03Part1.getNumber([|'1'; '2'; '3'|], 1) )

    [<Test>]
    member _.GetNumberWithOffsetAllowed617() = Assert.AreEqual(617,Day03Part1.getNumber([|'6'; '1'; '7'; '*'; '.'; '.'; '.'; '.'; '.'; '.'|], 3) )