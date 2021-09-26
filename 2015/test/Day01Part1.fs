namespace AoC2015.Tests

open System.IO
open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day01Part1 () =

    [<Test>]
    member this.OneUp() = Assert.AreEqual(1, Day01Part1.getFloor [|"("|])

    [<Test>]
    member this.OneDown() = Assert.AreEqual(-1, Day01Part1.getFloor [|")"|])

    [<Test>]
    member this.IgnoreOtherChars() = Assert.AreEqual(0, Day01Part1.getFloor [|"^"|])

    [<Test>]
    member this.IgnoreOtherLines() = Assert.AreEqual(0, Day01Part1.getFloor ([|""; ")"|]))

    [<Test>]
    member this.Example1a() = Assert.AreEqual(0, Day01Part1.getFloor ([|"(())"|]))

    [<Test>]
    member this.Example1b() = Assert.AreEqual(0, Day01Part1.getFloor ([|"()()"|]))

    [<Test>]
    member this.Example2a() = Assert.AreEqual(3, Day01Part1.getFloor ([|"((( "|]))

    [<Test>]
    member this.Example2b() = Assert.AreEqual(3, Day01Part1.getFloor ([|"(()(()("|]))

    [<Test>]
    member this.Example3() = Assert.AreEqual(3, Day01Part1.getFloor ([|"))((((("|]))

    [<Test>]
    member this.Example4a() = Assert.AreEqual(-1, Day01Part1.getFloor ([|"())"|]))

    [<Test>]
    member this.Example4b() = Assert.AreEqual(-1, Day01Part1.getFloor ([|"))("|]))

    [<Test>]
    member this.Example5a() = Assert.AreEqual(-3, Day01Part1.getFloor ([|")))"|]))

    [<Test>]
    member this.Example5b() = Assert.AreEqual(-3, Day01Part1.getFloor ([|")())())"|]))