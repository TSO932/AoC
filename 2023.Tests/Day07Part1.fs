namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day07Part1 () =

    [<Test>]
    member _.GetTypeFiveOfAKind() = Assert.AreEqual(3226944, Day07Part1.getType ("AAAAA"))

    [<Test>]
    member _.GetTypeFourOfAKind() = Assert.AreEqual(2689120, Day07Part1.getType ("AAVAA"))

    [<Test>]
    member _.GetTypeFullHouse1() = Assert.AreEqual(2151296, Day07Part1.getType ("AAVAV"))
    
    [<Test>]
    member _.GetTypeFullHouse2() = Assert.AreEqual(2151296, Day07Part1.getType ("XXBBX"))

    [<Test>]
    member _.GetTypeThreeOfAKind() = Assert.AreEqual(1613472, Day07Part1.getType ("AAVXA"))

    [<Test>]
    member _.GetTypeTwoPair() = Assert.AreEqual(1075648, Day07Part1.getType ("ABCAB"))

    [<Test>]
    member _.GetTypeOnePair() = Assert.AreEqual(537824, Day07Part1.getType ("ABCDB"))

    [<Test>]
    member _.GetTypeHighCard() = Assert.AreEqual(0, Day07Part1.getType ("ABCDE"))

    [<Test>]
    member _.GetLabelScore() = Assert.AreEqual(4, Day07Part1.getLabelScore ('5'))

    [<Test>]
    member _.GetLabelScoresForHand() = Assert.AreEqual(502847, Day07Part1.getLabelScoresForHand ("A248T"))

    [<Test>]
    member _.GetPreScore() = Assert.AreEqual(3764767, Day07Part1.getPreScore ("AAAAA"))

    [<Test>]
    member _.RankHands() = Assert.AreEqual(6440, Day07Part1.rankHands ([|"32T3K 765"; "T55J5 684"; "KK677 28"; "KTJJT 220"; "QQQJA 483"|]))

