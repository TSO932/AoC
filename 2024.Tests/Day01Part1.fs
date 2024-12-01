namespace _2024.Tests

open NUnit.Framework
open NUnit.Framework.Legacy
open _2024

[<TestFixture>]
type Day01Part1 () =

    [<Test>]
    member _.ClassicExample() = ClassicAssert.AreEqual(142, Day01Part1.calibrate [|"1abc2"; "pqr3stu8vwx"; "a1b2c3d4e5f"; "treb7uchet"|])

    [<Test>]
    member _.Example() = Assert.That(Day01Part1.calibrate [|"1abc2"; "pqr3stu8vwx"; "a1b2c3d4e5f"; "treb7uchet"|], Is.EqualTo(142))
