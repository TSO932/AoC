namespace AoC2021.Tests

open NUnit.Framework
open AoC2021

[<TestFixture>] 
type Day01Part2 () =

    [<Test>]
    member _.Example() = Assert.AreEqual(5, Day01Part2.countDepthIncreases [|"199"; "200"; "208"; "210"; "200"; "207"; "240"; "269"; "260"; "263"|])

