namespace AoC2017.Tests

open NUnit.Framework
open AoC2017

[<TestFixture>] 
type Day01Part1 () =

    [<Test>]
    member _.Example1() = Assert.AreEqual(3, Day01Part1.solveCaptha "1122")

    [<Test>]
    member _.Example2() = Assert.AreEqual(4, Day01Part1.solveCaptha "1111")

    [<Test>]
    member _.Example3() = Assert.AreEqual(0, Day01Part1.solveCaptha "1234")

    [<Test>]
    member _.Example4() = Assert.AreEqual(9, Day01Part1.solveCaptha "91212129")
