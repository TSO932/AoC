namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day07Part2 () =

    [<Test>]
    member _.RankHands() = Assert.AreEqual(5905, Day07Part2.rankHands ([|"32T3K 765"; "T55J5 684"; "KK677 28"; "KTJJT 220"; "QQQJA 483"|]))

