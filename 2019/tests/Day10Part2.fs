namespace AoC2019.Tests

open System.IO
open NUnit.Framework
open AoC2019

[<TestFixture>] 
type Day10Part2 () =

    [<Test>]
    member this.Simple2by2() = Assert.AreEqual(1, Day10Part2.vaporise ((File.ReadAllLines("../../../data/Day10/test6.txt"), (1,0))))

    [<Test>]
    member this.Example1() = Assert.AreEqual(1403, Day10Part2.vaporise ((File.ReadAllLines("../../../data/Day10/test7.txt"), (8,3))))

    [<Test>]
    member this.Example2() = Assert.AreEqual(802, Day10Part2.vaporise ((File.ReadAllLines("../../../data/Day10/test5.txt"), (11,13))))