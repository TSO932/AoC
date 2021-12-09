namespace AoC2021.Tests

open NUnit.Framework
open AoC2021

[<TestFixture>] 
type Day09Part2 () =

    [<Test>]
    member _.Example() = Assert.AreEqual(1134, Day09Part2.productOfBiggestBasins [|"2199943210"; "3987894921"; "9856789892"; "8767896789"; "9899965678"|])
