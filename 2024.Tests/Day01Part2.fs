namespace _2024.Tests

open NUnit.Framework
open _2024

[<TestFixture>]
type Day01Part2 () =

    [<Test>]
    member _.Example() =
        Assert.That(Day01Part2.run [|"3   4"; "4   3"; "2   5"; "1   3"; "3   9"; "3   3"|], Is.EqualTo(31))




