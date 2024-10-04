namespace AoC2017.Tests

open NUnit.Framework
open AoC2017

[<TestFixture>]
type Day04Part2() =

    [<Test>]
    member _.Example1() =
        Assert.AreEqual(true, Day04Part2.isValid "abcde fghij")

    [<Test>]
    member _.Example2() =
        Assert.AreEqual(false, Day04Part2.isValid "abcde xyz ecdab")

    [<Test>]
    member _.Example3() =
        Assert.AreEqual(true, Day04Part2.isValid "a ab abc abd abf abj")

    [<Test>]
    member _.Example4() =
        Assert.AreEqual(true, Day04Part2.isValid "iiii oiii ooii oooi oooo")

    [<Test>]
    member _.Example5() =
        Assert.AreEqual(false, Day04Part2.isValid "oiii ioii iioi iiio")
