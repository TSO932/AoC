namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day19Part1 () =

    [<Test>]
    member _.Parse() = 
        Assert.AreEqual((787, 2655, 1222, 2876), Day19Part1.parse("{x=787,m=2655,a=1222,s=2876}"))

    [<Test>]
    member _.Count() = 
        Assert.AreEqual(19114, Day19Part1.countAccepted([|"{x=787,m=2655,a=1222,s=2876}"; "{x=1679,m=44,a=2067,s=496}"; "{x=2036,m=264,a=79,s=2244}"; "{x=2461,m=1339,a=466,s=291}"; "{x=2127,m=1623,a=2188,s=1013}"|], Day19Part1.in1))
