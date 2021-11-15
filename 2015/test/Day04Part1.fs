namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day04Part1 () =

    [<Test>]
    member _.GetHash() = Assert.AreEqual("000001dbbfa3a5c83a2d506429c7b00e", Day04Part1.getHash ("abcdef609043"))

    
    [<Test>]
    member _.IsValidTrue() = Assert.AreEqual(true, Day04Part1.isValid ("00000QWERTY"))

    [<Test>]
    member _.IsValidFalse() = Assert.AreEqual(false, Day04Part1.isValid ("00001QWERTY"))

    [<Test>]
    member _.Example1() = Assert.AreEqual(609043, Day04Part1.getAdventCoin ([|"abcdef"|]))
    
    [<Test>]
    member _.Example2() = Assert.AreEqual(1048970, Day04Part1.getAdventCoin ([|"pqrstuv"|]))


   