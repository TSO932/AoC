namespace AoC2020.Tests

open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day18Part2 () =

    [<Test>]
    member this.MutipleDigits() = Assert.AreEqual(132, Day18Part2.evaluateExpression ("11 * 12"))

    [<Test>]
    member this.Example1() = Assert.AreEqual(231, Day18Part2.evaluateExpression ("1 + 2 * 3 + 4 * 5 + 6"))

    [<Test>]
    member this.Example2() = Assert.AreEqual(51, Day18Part2.evaluateExpression ("1 + (2 * 3) + (4 * (5 + 6))"))

    [<Test>]
    member this.Example3() = Assert.AreEqual(46, Day18Part2.evaluateExpression ("2 * 3 + (4 * 5)"))

    [<Test>]
    member this.Example4() = Assert.AreEqual(1445, Day18Part2.evaluateExpression ("5 + (8 * 3 + 9 + 3 * 4 * 3)"))

    [<Test>]
    member this.Example5() = Assert.AreEqual(669060, Day18Part2.evaluateExpression ("5 * 9 * (7 * 3 * 3 + 9 * 3 + (8 + 6 * 4))"))

    [<Test>]
    member this.Example6() = Assert.AreEqual(23340, Day18Part2.evaluateExpression ("((2 + 4 * 9) * (6 + 9 * 8 + 6) + 6) + 2 + 4 * 2"))

    [<Test>]
    member this.SumValues() = Assert.AreEqual(20, Day18Part2.sumValues ( seq {"7"; "13"} ))

    [<Test>]
    member this.LargeValue() = Assert.AreEqual(9223372036854775807L, Day18Part2.sumValues ( seq {"9223372036854775807"} ))
