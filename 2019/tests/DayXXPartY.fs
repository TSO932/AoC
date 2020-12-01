namespace AoC2019.Tests

open NUnit.Framework
open AoC2019

[<TestFixture>] 
type DayXXPartY () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(0, DayXXPartY.runProgram("The quick brown fox jumped over the lazy dog."))