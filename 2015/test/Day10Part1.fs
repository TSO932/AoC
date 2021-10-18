namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day10Part1 () =

    [<Test>]
    member _.Example1() = CollectionAssert.AreEqual([1y;1y], Day10Part1.lookAndSay ([1y]))

    [<Test>]
    member _.Example2() = CollectionAssert.AreEqual([2y;1y], Day10Part1.lookAndSay ([1y;1y]))

    [<Test>]
    member _.Example3() = CollectionAssert.AreEqual([1y;2y;1y;1y], Day10Part1.lookAndSay ([2y;1y]))

    [<Test>]
    member _.Example4() = CollectionAssert.AreEqual([1y;1y;1y;2y;2y;1y], Day10Part1.lookAndSay ([1y;2y;1y;1y]))

    [<Test>]
    member _.Example5() = CollectionAssert.AreEqual([3y;1y;2y;2y;1y;1y], Day10Part1.lookAndSay ([1y;1y;1y;2y;2y;1y]))

    [<Test>]
    member _.Example() = Assert.AreEqual(6, Day10Part1.lookAndSayRepeat (5, "1"))