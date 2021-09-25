namespace AoC2015.Tests

open System.IO
open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day01Part1 () =

    [<Test>]
    member this.oneUp() = Assert.AreEqual(1, Day01Part1.getFloor [|"("|])

    [<Test>]
    member this.oneDown() = Assert.AreEqual(-1, Day01Part1.getFloor [|")"|])

    [<Test>]
    member this.ignoreOtherChars() = Assert.AreEqual(0, Day01Part1.getFloor [|"^"|])

    [<Test>]
    member this.ignoreOtherLines() = Assert.AreEqual(0, Day01Part1.getFloor ([|""; ")"|]))

    [<Test>]
    member this.example1a() = Assert.AreEqual(0, Day01Part1.getFloor ([|"(())"|]))

    [<Test>]
    member this.example1b() = Assert.AreEqual(0, Day01Part1.getFloor ([|"()()"|]))

    [<Test>]
    member this.example2a() = Assert.AreEqual(3, Day01Part1.getFloor ([|"((( "|]))

    [<Test>]
    member this.example2b() = Assert.AreEqual(3, Day01Part1.getFloor ([|"(()(()("|]))

    [<Test>]
    member this.example3() = Assert.AreEqual(3, Day01Part1.getFloor ([|"))((((("|]))

    [<Test>]
    member this.example4a() = Assert.AreEqual(-1, Day01Part1.getFloor ([|"())"|]))

    [<Test>]
    member this.example4b() = Assert.AreEqual(-1, Day01Part1.getFloor ([|"))("|]))

    [<Test>]
    member this.example5a() = Assert.AreEqual(-3, Day01Part1.getFloor ([|")))"|]))

    [<Test>]
    member this.example5b() = Assert.AreEqual(-3, Day01Part1.getFloor ([|")())())"|]))