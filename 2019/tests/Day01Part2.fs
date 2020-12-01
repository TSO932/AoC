namespace AoC2019.Tests

open NUnit.Framework
open AoC2019

[<TestFixture>] 
type Day01Part2 () =

    [<Test>]
    member this.AvoidNegativeFuel() = Assert.AreEqual(0, Day01Part2.fuelCalc(1))

    [<Test>]
    member this.LargestAmountOfFuelWithRequiresNoMore() = Assert.AreEqual(0, Day01Part2.fuelCalc(8))

    [<Test>]
    member this.SmallestAmountOfFuelWhichRequiresExtra() = Assert.AreEqual(1, Day01Part2.fuelCalc(9))

    [<Test>]
    member this.Example1() = Assert.AreEqual(2, Day01Part2.fuelCalc(14))

    [<Test>]
    member this.Example2() = Assert.AreEqual(966, Day01Part2.fuelCalc(1969))

    [<Test>]
    member this.Example3() = Assert.AreEqual(50346, Day01Part2.fuelCalc(100756))