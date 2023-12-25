namespace AoC2022.Tests

open NUnit.Framework
open AoC2022

[<TestFixture>] 
type Day01Part2 () =

    [<Test>]
    member _.Example() = Assert.AreEqual(45000, Day01Part2.FindElvesCarryingMostCalories [|"1000"; "2000"; "3000"; ""; "4000"; ""; "5000"; "6000"; ""; "7000"; "8000"; "9000"; ""; "10000"|])


