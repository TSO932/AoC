namespace AoC2017.Tests

open NUnit.Framework
open AoC2017

[<TestFixture>]
type Day06Part1() =

    [<Test>]
    member _.Example1() =
        CollectionAssert.AreEqual([| 2; 4; 1; 2 |], Day06Part1.distibuteBlocks [| 0; 2; 7; 0 |])

    [<Test>]
    member _.Example2() =
        CollectionAssert.AreEqual([| 3; 1; 2; 3 |], Day06Part1.distibuteBlocks [| 2; 4; 1; 2 |])

    [<Test>]
    member _.Example3() =
        CollectionAssert.AreEqual([| 0; 2; 3; 4 |], Day06Part1.distibuteBlocks [| 3; 1; 2; 3 |])

    [<Test>]
    member _.Example4() =
        CollectionAssert.AreEqual([| 1; 3; 4; 1 |], Day06Part1.distibuteBlocks [| 0; 2; 3; 4 |])

    [<Test>]
    member _.Example5() =
        CollectionAssert.AreEqual([| 2; 4; 1; 2 |], Day06Part1.distibuteBlocks [| 1; 3; 4; 1 |])

    [<Test>]
    member _.Example() =
        Assert.AreEqual(5, Day06Part1.findRepeat [| 0; 2; 7; 0 |])
