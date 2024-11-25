namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day07Part1 () =

    [<Test>]
    member this.findOuterBags1() = Assert.AreEqual(0, Day07Part1.countOuterBags (["dark orange bag"; "light red bag"; "dark orange bag"], File.ReadAllLines("../../../data/Day07/test1.txt")))

    [<Test>]
    member this.findOuterBags2() = Assert.AreEqual(2, Day07Part1.countOuterBags (["bright white bag"; "muted yellow bag"], File.ReadAllLines("../../../data/Day07/test1.txt")))
    
    [<Test>]
    member this.findOuterBags3() = Assert.AreEqual(4, Day07Part1.countOuterBags (["shiny gold bag"], File.ReadAllLines("../../../data/Day07/test1.txt")))

    [<Test>]
    member this.myPrecious() = Assert.AreEqual(4, Day07Part1.myPrecious (File.ReadAllLines("../../../data/Day07/test1.txt")))
