namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day01Part2 () =

    [<Test>]
    member _.Example() = Assert.AreEqual(281, Day01Part2.calibrate [|"two1nine"; "eightwothree"; "abcone2threexyz"; "xtwone3four"; "4nineeightseven2"; "zoneight234"; "7pqrstsixteen"|])
