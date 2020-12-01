namespace AoC2019.Tests

open NUnit.Framework
open AoC2019

[<TestFixture>] 
type Day01Part1 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(2, Day01Part1.fuelCalc(12))

    [<Test>]
    member this.Example2() = Assert.AreEqual(2, Day01Part1.fuelCalc(14))

    [<Test>]
    member this.Example3() = Assert.AreEqual(654, Day01Part1.fuelCalc(1969))

    [<Test>]
    member this.Example4() = Assert.AreEqual(33583, Day01Part1.fuelCalc(100756))