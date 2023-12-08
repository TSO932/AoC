namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day08Part1 () =

    [<Test>]
    member _.Example1() =
        let input = [|"RL"; ""; "AAA = (BBB, CCC)"; "BBB = (DDD, EEE)"; "CCC = (ZZZ, GGG)"; "DDD = (DDD, DDD)"; "EEE = (EEE, EEE)"; "GGG = (GGG, GGG)"; "ZZZ = (ZZZ, ZZZ)"|]
        Assert.AreEqual(2, Day08Part1.countSteps input)

    [<Test>]
    member _.Example2() =
        let input = [|"LLR"; ""; "AAA = (BBB, BBB)"; "BBB = (AAA, ZZZ)"|]
        Assert.AreEqual(6, Day08Part1.countSteps input)