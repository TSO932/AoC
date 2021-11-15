namespace AoC2015.Tests

open System.IO
open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day13Part1 () =

    [<Test>]
    member _.Happy() = Assert.AreEqual(("Jay-z", "Bob", 99), Day13Part1.parsePeoplePairing ("Jay-z would gain 99 problems but his misogyny ain't one Bob."))

    [<Test>]
    member _.Unhappy() = Assert.AreEqual(("I", "more", -500), Day13Part1.parsePeoplePairing ("I would walk 500 miles and I would walk 500 more."))

    [<Test>]
    member _.GetListOfPeople() = CollectionAssert.AreEqual(["Huey"; "Dewey"; "Louie"], Day13Part1.getListOfPeople ([|("Huey", "Dewey", 1); ("Dewey", "Huey", -1); ("Louie", "Dewey", 2); ("Dewey", "Louie", -2)|]))

    [<Test>]
    member _.Happieness() =
        let happinesses = Day13Part1.PeoplePairingDictionary()
        happinesses.Populate([|("A", "B", -1); ("B", "A", 7); ("B", "C", -12); ("C", "B", -17)|])
        Assert.AreEqual(6, happinesses.Get("A", "B"))

    [<Test>]
    member _.Example() = Assert.AreEqual(330, Day13Part1.findHappiestSeatingPlan (File.ReadAllLines("../../../data/Day13/test1.txt")))




    
