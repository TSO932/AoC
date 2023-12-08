namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day08Part2 () =

    [<Test>]
    member _.Example() =
        let input = [|"LR"; ""; "11A = (11B, XXX)"; "11B = (XXX, 11Z)"; "11Z = (11B, XXX)"; "22A = (22B, XXX)"; "22B = (22C, 22C)"; "22C = (22Z, 22Z)"; "22Z = (22B, 22B)"; "XXX = (XXX, XXX)"|]
        Assert.AreEqual(6L, Day08Part2.countSteps input)
