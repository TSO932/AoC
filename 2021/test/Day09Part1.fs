namespace AoC2021.Tests

open NUnit.Framework
open AoC2021

[<TestFixture>] 
type Day09Part1 () =

    [<Test>]
    member _.Example() = Assert.AreEqual(15, Day09Part1.sumOfLocalMinima [|"2199943210"; "3987894921"; "9856789892"; "8767896789"; "9899965678"|])

