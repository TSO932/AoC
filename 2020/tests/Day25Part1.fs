namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day25Part1 () =

    [<Test>]
    member this.GetLoopSizeDoor() = Assert.AreEqual(7, Day25Part1.getLoopSize(5764801L))

    [<Test>]
    member this.GetLoopSizeCard() = Assert.AreEqual(10, Day25Part1.getLoopSize(17807724L))

    [<Test>]
    member this.GetEncryptionKeyOneWay() = Assert.AreEqual(14897079, Day25Part1.getEncryptionKey(5764801L, 10))

    [<Test>]
    member this.GetEncryptionKeyTheOthweWay() = Assert.AreEqual(14897079, Day25Part1.getEncryptionKey(17807724L, 7))
  
    [<Test>]
    member this.GetCrackTheLockOneWay() = Assert.AreEqual(14897079, Day25Part1.crackTheLock(5764801L, 17807724L))

    [<Test>]
    member this.GetCrackTheLockTheOthweWay() = Assert.AreEqual(14897079, Day25Part1.crackTheLock(17807724L, 5764801L))