namespace AoC2019.Tests

open System.IO
open NUnit.Framework
open AoC2019

[<TestFixture>] 
type Day14Part1 () =

    [<Test>]
    member this.A() = Assert.AreEqual(9, (Day14Part1.tcaer("A", 1, Day14Part1.getProductDic(File.ReadAllLines("../../../data/Day14/test2.txt")), true)))
    
    //Two As can be gotten from a single batch.
    [<Test>]
    member this.AA() = Assert.AreEqual(9, (Day14Part1.tcaer("A", 2, Day14Part1.getProductDic(File.ReadAllLines("../../../data/Day14/test2.txt")), true)))

    [<Test>]
    member this.B() = Assert.AreEqual(8, (Day14Part1.tcaer("B", 1, Day14Part1.getProductDic(File.ReadAllLines("../../../data/Day14/test2.txt")), true)))

    [<Test>]
    member this.C() = Assert.AreEqual(7, (Day14Part1.tcaer("C", 1, Day14Part1.getProductDic(File.ReadAllLines("../../../data/Day14/test2.txt")), true)))

    // sum of ((no of batches needed) * (units needed for batch)) =>  2 * 9 + 2 * 8 = 34
    [<Test>]
    member this.AB() = Assert.AreEqual(34, (Day14Part1.tcaer("AB", 1, Day14Part1.getProductDic(File.ReadAllLines("../../../data/Day14/test2.txt")), true)))

    // 2 * 8 + 2 * 7 = 30
    [<Test>]
    member this.BC() = Assert.AreEqual(30, (Day14Part1.tcaer("BC", 1, Day14Part1.getProductDic(File.ReadAllLines("../../../data/Day14/test2.txt")), true)))

    // 1 * 7 + 1 * 9 = 16
    [<Test>]
    member this.CA() = Assert.AreEqual(16, (Day14Part1.tcaer("CA", 1, Day14Part1.getProductDic(File.ReadAllLines("../../../data/Day14/test2.txt")), true)))


    [<Test>]
    member this.Example1() = Assert.AreEqual(31, (Day14Part1.tcaer("FUEL", 1, Day14Part1.getProductDic(File.ReadAllLines("../../../data/Day14/test1.txt")), true)))

    [<Test>]
    member this.Example2() = Assert.AreEqual(165, (Day14Part1.tcaer("FUEL", 1, Day14Part1.getProductDic(File.ReadAllLines("../../../data/Day14/test2.txt")), true)))

    [<Test>]
    member this.Example3() = Assert.AreEqual(13312, (Day14Part1.tcaer("FUEL", 1, Day14Part1.getProductDic(File.ReadAllLines("../../../data/Day14/test3.txt")), true)))

    [<Test>]
    member this.Example4() = Assert.AreEqual(180697, (Day14Part1.tcaer("FUEL", 1, Day14Part1.getProductDic(File.ReadAllLines("../../../data/Day14/test4.txt")), true)))

    [<Test>]
    member this.Example5() = Assert.AreEqual(2210736, (Day14Part1.tcaer("FUEL", 1, Day14Part1.getProductDic(File.ReadAllLines("../../../data/Day14/test5.txt")), true)))
