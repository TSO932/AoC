namespace _2024.Tests

open NUnit.Framework
open _2024

[<TestFixture>]
type Day02Part2 () =

    [<Test>]
    member _.Example1() =
        Assert.That(Day02Part2.isValid "7 6 4 2 1", Is.EqualTo(true))

    [<Test>]
    member _.Example2() =
        Assert.That(Day02Part2.isValid "1 2 7 8 9", Is.EqualTo(false))

    [<Test>]
    member _.Example3() =
        Assert.That(Day02Part2.isValid "9 7 6 2 1", Is.EqualTo(false))

    [<Test>]
    member _.Example4() =
        Assert.That(Day02Part2.isValid "1 3 2 4 5", Is.EqualTo(true))
        
    [<Test>]
    member _.Example5() =
        Assert.That(Day02Part2.isValid "8 6 4 4 1", Is.EqualTo(true))

    [<Test>]
    member _.Example6() =
        Assert.That(Day02Part2.isValid "1 3 6 7 9", Is.EqualTo(true))

    [<Test>]
    member _.Example() =
        Assert.That(Day02Part2.run [|"7 6 4 2 1"; "1 2 7 8 9"; "9 7 6 2 1"; "1 3 2 4 5"; "8 6 4 4 1"; "1 3 6 7 9"|], Is.EqualTo(4))




