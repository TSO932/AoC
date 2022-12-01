namespace AoC2022.Tests

open NUnit.Framework
open AoC2022

[<TestFixture>] 
type Day02Part1 () =

    [<Test>]
    member _.Example() = Assert.AreEqual(24000, Day01Part1.FindElfCarryingMostCalories [|"1000"; "2000"; "3000"; ""; "4000"; ""; "5000"; "6000"; ""; "7000"; "8000"; "9000"; ""; "10000"|])


