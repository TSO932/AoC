module _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day01Part1 () =

    [<Test>]
    member _.Example() = Assert.AreEqual(142, Day01Part1.findElfCarryingMostCalories [|"1abc2"; "pqr3stu8vwx"; "a1b2c3d4e5f"; "treb7uchet"|])

    [<Test>]
    member _.Example2() = Assert.AreEqual(281, Day01Part1.findElfCarryingMostCalories2 [|"two1nine"; "eightwothree"; "abcone2threexyz"; "xtwone3four"; "4nineeightseven2"; "zoneight234"; "7pqrstsixteen"|])
