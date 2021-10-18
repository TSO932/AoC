namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day10Part1 () =

    [<Test>]
    member _.Example1() = Assert.AreEqual("11", Day10Part1.lookAndSay ("1"))

    [<Test>]
    member _.Example2() = Assert.AreEqual("21", Day10Part1.lookAndSay ("11"))

    [<Test>]
    member _.Example3() = Assert.AreEqual("1211", Day10Part1.lookAndSay ("21"))

    [<Test>]
    member _.Example4() = Assert.AreEqual("111221", Day10Part1.lookAndSay ("1211"))

    [<Test>]
    member _.Example5() = Assert.AreEqual("312211", Day10Part1.lookAndSay ("111221"))

    [<Test>]
    member _.Example() = Assert.AreEqual(6, Day10Part1.lookAndSayRepeat (5, "1"))