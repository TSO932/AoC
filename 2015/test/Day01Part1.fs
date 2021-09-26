namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day01Part1 () =

    [<Test>]
    member _.OneUp() = Assert.AreEqual(1, Day01Part1.getFloor [|"("|])

    [<Test>]
    member _.OneDown() = Assert.AreEqual(-1, Day01Part1.getFloor [|")"|])

    [<Test>]
    member _.IgnoreOtherChars() = Assert.AreEqual(0, Day01Part1.getFloor [|"^"|])

    [<Test>]
    member _.IgnoreOtherLines() = Assert.AreEqual(0, Day01Part1.getFloor ([|""; ")"|]))

    [<Test>]
    member _.Example1a() = Assert.AreEqual(0, Day01Part1.getFloor ([|"(())"|]))

    [<Test>]
    member _.Example1b() = Assert.AreEqual(0, Day01Part1.getFloor ([|"()()"|]))

    [<Test>]
    member _.Example2a() = Assert.AreEqual(3, Day01Part1.getFloor ([|"((( "|]))

    [<Test>]
    member _.Example2b() = Assert.AreEqual(3, Day01Part1.getFloor ([|"(()(()("|]))

    [<Test>]
    member _.Example3() = Assert.AreEqual(3, Day01Part1.getFloor ([|"))((((("|]))

    [<Test>]
    member _.Example4a() = Assert.AreEqual(-1, Day01Part1.getFloor ([|"())"|]))

    [<Test>]
    member _.Example4b() = Assert.AreEqual(-1, Day01Part1.getFloor ([|"))("|]))

    [<Test>]
    member _.Example5a() = Assert.AreEqual(-3, Day01Part1.getFloor ([|")))"|]))

    [<Test>]
    member _.Example5b() = Assert.AreEqual(-3, Day01Part1.getFloor ([|")())())"|]))