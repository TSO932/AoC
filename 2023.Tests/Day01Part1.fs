namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day01Part1 () =

    [<Test>]
    member _.Example() = Assert.AreEqual(142, Day01Part1.calibrate [|"1abc2"; "pqr3stu8vwx"; "a1b2c3d4e5f"; "treb7uchet"|])
