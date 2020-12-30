namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day14Part1 () =

    [<Test>]
    member this.GetBinaryFromDecimal7() = Assert.AreEqual("111", Day14Part1.getBinaryFromDecimal (7))

    [<Test>]
    member this.GetBinaryFromDecimal8() = Assert.AreEqual("1000", Day14Part1.getBinaryFromDecimal (8))

    [<Test>]
    member this.GetBinaryFromDecimal0() = Assert.AreEqual("0", Day14Part1.getBinaryFromDecimal (0))

    [<Test>]
    member this.GetDecimalFromBinary7() = Assert.AreEqual(7, Day14Part1.getDecimalFromBinary ("111"))

    [<Test>]
    member this.GetDecimalFromBinary8() = Assert.AreEqual(8, Day14Part1.getDecimalFromBinary ("1000"))

    [<Test>]
    member this.GetDecimalFromBinary0() = Assert.AreEqual(0, Day14Part1.getDecimalFromBinary ("0"))

    [<Test>]
    member this.ApplyBitmaskExample1() = Assert.AreEqual("00001001001", Day14Part1.applyBitmask("00000001011", "XXXX1XXXX0X"))

    [<Test>]
    member this.ApplyBitmaskExample2() = Assert.AreEqual("00001100101", Day14Part1.applyBitmask("00001100101", "XXXX1XXXX0X"))

    [<Test>]
    member this.ApplyBitmaskExample3() = Assert.AreEqual("00001000000", Day14Part1.applyBitmask("00000000000", "XXXX1XXXX0X")) 

    [<Test>]
    member this.ParseMemoryPairExample1() = Assert.AreEqual((8, 11), Day14Part1.parseMemoryPair("mem[8] = 11"))

    [<Test>]
    member this.ParseMemoryPairExample2() = Assert.AreEqual((7, 101), Day14Part1.parseMemoryPair("mem[7] = 101"))

    [<Test>]
    member this.ParseMemoryPairExample3() = Assert.AreEqual((8, 0), Day14Part1.parseMemoryPair("mem[8] = 0")) 

    [<Test>]
    member this.InitializeFerryDockingProgram() = Assert.AreEqual(165, Day14Part1.initializeFerryDockingProgram(File.ReadAllLines("../../../data/Day14/test1.txt")))