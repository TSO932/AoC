namespace AoC2019.Tests

open System.IO
open NUnit.Framework
open AoC2019

[<TestFixture>] 
type Day14Part2 () =

    [<Test>]
    member this.Example3() = 
        Assert.LessOrEqual((Day14Part2.tcaer("FUEL", 82892753L, Day14Part2.getProductDic(File.ReadAllLines("../../../data/Day14/test3.txt")), true)), 1000000000000L)
        Assert.Greater((Day14Part2.tcaer("FUEL", 82892754L, Day14Part2.getProductDic(File.ReadAllLines("../../../data/Day14/test3.txt")), true)), 1000000000000L)

    [<Test>]
    member this.Example4() = 
        Assert.LessOrEqual((Day14Part2.tcaer("FUEL", 5586022L, Day14Part2.getProductDic(File.ReadAllLines("../../../data/Day14/test4.txt")), true)), 1000000000000L)
        Assert.Greater((Day14Part2.tcaer("FUEL", 5586023L, Day14Part2.getProductDic(File.ReadAllLines("../../../data/Day14/test4.txt")), true)), 1000000000000L)


    [<Test>]
    member this.Example5() = 
        Assert.LessOrEqual((Day14Part2.tcaer("FUEL", 460664L, Day14Part2.getProductDic(File.ReadAllLines("../../../data/Day14/test5.txt")), true)), 1000000000000L)
        Assert.Greater((Day14Part2.tcaer("FUEL", 460665L, Day14Part2.getProductDic(File.ReadAllLines("../../../data/Day14/test5.txt")), true)), 1000000000000L)