namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day07Part2 () =

    [<Test>]
    member this.findInnerBags0() = Assert.AreEqual(-1, Day07Part2.countInnerBags ("other bag", File.ReadAllLines("../../../data/Day07/test1.txt")))

    [<Test>]
    member this.findInnerBags1() = Assert.AreEqual(0, Day07Part2.countInnerBags ("faded blue bag", File.ReadAllLines("../../../data/Day07/test1.txt")))

    [<Test>]
    member this.findInnerBags3() = Assert.AreEqual(0, Day07Part2.countInnerBags ("dotted black bag", File.ReadAllLines("../../../data/Day07/test1.txt")))
    
    [<Test>]
    member this.findInnerBags4() = Assert.AreEqual(11, Day07Part2.countInnerBags ("vibrant plum bag", File.ReadAllLines("../../../data/Day07/test1.txt")))

    [<Test>]
    member this.findInnerBags5() = Assert.AreEqual(7, Day07Part2.countInnerBags ("dark olive bag", File.ReadAllLines("../../../data/Day07/test1.txt")))

    [<Test>]
    member this.myPrecious1() = Assert.AreEqual(32, Day07Part2.myPrecious (File.ReadAllLines("../../../data/Day07/test1.txt")))

    [<Test>]
    member this.myPrecious2() = Assert.AreEqual(126, Day07Part2.myPrecious (File.ReadAllLines("../../../data/Day07/test2.txt")))
