namespace AoC2017.Tests

open NUnit.Framework
open AoC2017

[<TestFixture>] 
type Day01Part2 () =

    [<Test>]
    member _.Example1() = Assert.AreEqual(6, Day01Part2.solveCaptha "1212")

    [<Test>]
    member _.Example2() = Assert.AreEqual(0, Day01Part2.solveCaptha "1221")

    [<Test>]
    member _.Example3() = Assert.AreEqual(4, Day01Part2.solveCaptha "123425")

    [<Test>]
    member _.Example4() = Assert.AreEqual(12, Day01Part2.solveCaptha "123123")

    [<Test>]
    member _.Example5() = Assert.AreEqual(4, Day01Part2.solveCaptha "12131415")
