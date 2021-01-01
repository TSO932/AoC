namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day19Part1 () =

    [<DefaultValue>] val mutable example1 : string
    [<DefaultValue>] val mutable example2 : string

    [<SetUp>]
    member this.SetUp() =
        this.example1 <- "^a(ab|ba)$"
        this.example2 <- "^a((aa|bb)(ab|ba)|(ab|ba)(aa|bb))b$"

    [<Test>]
    member this.IsMatchExample1a() = Assert.AreEqual(true, Day19Part1.isMatch ("aba", this.example1))

    [<Test>]
    member this.IsMatchExample1b() = Assert.AreEqual(true, Day19Part1.isMatch ("aab", this.example1))

    [<Test>]
    member this.IsMatchExample1c() = Assert.AreEqual(false, Day19Part1.isMatch ("baa", this.example1))

    [<Test>]
    member this.IsMatchExample2a() = Assert.AreEqual(true, Day19Part1.isMatch ("aaaabb", this.example2))

    [<Test>]
    member this.IsMatchExample2b() = Assert.AreEqual(true, Day19Part1.isMatch ("aaabab", this.example2))

    [<Test>]
    member this.IsMatchExample2c() = Assert.AreEqual(true, Day19Part1.isMatch ("abbabb", this.example2))

    [<Test>]
    member this.IsMatchExample2d() = Assert.AreEqual(true, Day19Part1.isMatch ("abbbab", this.example2))

    [<Test>]
    member this.IsMatchExample2e() = Assert.AreEqual(true, Day19Part1.isMatch ("aabaab", this.example2))

    [<Test>]
    member this.IsMatchExample2f() = Assert.AreEqual(true, Day19Part1.isMatch ("aabbbb", this.example2))

    [<Test>]
    member this.IsMatchExample2g() = Assert.AreEqual(true, Day19Part1.isMatch ("abaaab", this.example2))

    [<Test>]
    member this.IsMatchExample2h() = Assert.AreEqual(true, Day19Part1.isMatch ("ababbb", this.example2))

    [<Test>]
    member this.IsMatchExample2i() = Assert.AreEqual(false, Day19Part1.isMatch ("bababa", this.example2))

    [<Test>]
    member this.IsMatchExample2j() = Assert.AreEqual(false, Day19Part1.isMatch ("aaabbb", this.example2))

    [<Test>]
    member this.IsMatchExample2k() = Assert.AreEqual(false, Day19Part1.isMatch ("aaaabbb", this.example2))

    [<Test>]
    member this.GetPatternExample1() = Assert.AreEqual(this.example1, Day19Part1.getPattern (File.ReadAllLines("../../../data/Day19/test1.txt")))

    [<Test>]
    member this.GetPatternExample2() = Assert.AreEqual(this.example2, Day19Part1.getPattern (File.ReadAllLines("../../../data/Day19/test2.txt")))

    [<Test>]
    member this.CountValidMessages() = Assert.AreEqual(2, Day19Part1.countValidMessages (File.ReadAllLines("../../../data/Day19/test2full.txt")))
