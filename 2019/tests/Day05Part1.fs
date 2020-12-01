namespace AoC2019.Tests

open NUnit.Framework
open AoC2019

[<TestFixture>] 
type Day05Part1 () =

    [<Test>]
    member this.Example1_ProgramReturnsInputValueAsOutput() =
        Assert.AreEqual(7, Day05Part1.runProgram("3,0,4,0,99", 7))
        Assert.AreEqual(6, Day05Part1.runProgram("3,0,4,0,99", 6))

    [<Test>]
    member this.Example2_ProgramGeneratesItsOwnStopCode() = Assert.AreEqual(0, Day05Part1.runProgram("1002,4,3,4,33", 0))

    [<Test>]
    member this.Example3_NegativeNumbersAreValid() = Assert.AreEqual(0, Day05Part1.runProgram("1101,100,-1,4,0", 0))

    [<Test>]
    member this.ThreeDigitOptcode() = Assert.AreEqual(0, Day05Part1.runProgram("101,2,1,0,99", 0))

    [<Test>]
    member this.FiveDigitIntcode() = Assert.AreEqual(0, Day05Part1.runProgram("11101,2,1,0,99", 0))

