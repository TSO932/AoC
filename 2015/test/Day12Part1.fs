namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day12Part1 () =

    [<Test>]
    member _.Example1A() = Assert.AreEqual(6, Day12Part1.sumNumbers ("[1,2,3]"))

    [<Test>]
    member _.Example1B() = Assert.AreEqual(6, Day12Part1.sumNumbers ("{\"a\":2,\"b\":4}"))

    [<Test>]
    member _.Example2A() = Assert.AreEqual(3, Day12Part1.sumNumbers ("[[[3]]]"))

    [<Test>]
    member _.Example2B() = Assert.AreEqual(3, Day12Part1.sumNumbers ("{\"a\":{\"b\":4},\"c\":-1}"))
    
    [<Test>]
    member _.Example3A() = Assert.AreEqual(0, Day12Part1.sumNumbers ("{\"a\":[-1,1]}"))
    
    [<Test>]
    member _.Example3B() = Assert.AreEqual(0, Day12Part1.sumNumbers ("[-1,{\"a\":1}]"))

    [<Test>]
    member _.Example4A() = Assert.AreEqual(0, Day12Part1.sumNumbers ("[]"))
    
    [<Test>]
    member _.Example4B() = Assert.AreEqual(0, Day12Part1.sumNumbers ("{}"))