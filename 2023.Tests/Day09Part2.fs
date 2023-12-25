namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day09Part2 () =

    [<Test>]
    member _.GetSum() = Assert.AreEqual(2, Day09Part2.getSum [|"0 3 6 9 12 15"; "1 3 6 10 15 21"; "10 13 16 21 30 45"|])



