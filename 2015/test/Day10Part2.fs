namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day10Part2 () =

    [<Test>]
    member _.Helium22() = CollectionAssert.AreEqual(["H"], Day10Part2.lookAndSay (["22"]))

    [<Test>]
    member _.HeliumH() = CollectionAssert.AreEqual(["H"], Day10Part2.lookAndSay (["H"]))

    [<Test>]
    member _.Uranium3() = CollectionAssert.AreEqual(["Pa"], Day10Part2.lookAndSay (["3"]))

    [<Test>]
    member _.UraniumU() = CollectionAssert.AreEqual(["Pa"], Day10Part2.lookAndSay (["U"]))

    [<Test>]
    member _.Scandium() = CollectionAssert.AreEqual(["Ho";"Pa";"H";"Ca";"Co"], Day10Part2.lookAndSay (["Sc"]))

    [<Test>]
    member _.SevenRounds() = Assert.AreEqual(14, Day10Part2.lookAndSayRepeat (7, "3"))