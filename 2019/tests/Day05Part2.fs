namespace AoC2019.Tests

open NUnit.Framework
open AoC2019

[<TestFixture>] 
type Day05Part2 () =


    //Using position mode

    [<Test>]
    member this.Example1_EqualsEightIsTrue() = Assert.AreEqual(1, Day05Part2.runProgram("3,9,8,9,10,9,4,9,99,-1,8",8))

    [<Test>]
    member this.Example1_EqualsEightIsFalse() = Assert.AreEqual(0, Day05Part2.runProgram("3,9,8,9,10,9,4,9,99,-1,8",7))

    [<Test>]
    member this.Example2_LessThanEightFalse() = Assert.AreEqual(0, Day05Part2.runProgram("3,9,7,9,10,9,4,9,99,-1,8",8))

    [<Test>]
    member this.Example2_LessThanEightIsTrue() = Assert.AreEqual(1, Day05Part2.runProgram("3,9,7,9,10,9,4,9,99,-1,8",7))

    //Using immediate mode

    [<Test>]
    member this.Example3_EqualsEightIsTrue() = Assert.AreEqual(1, Day05Part2.runProgram("3,3,1108,-1,8,3,4,3,99",8))

    [<Test>]
    member this.Example3_EqualsEightIsFalse() = Assert.AreEqual(0, Day05Part2.runProgram("3,3,1108,-1,8,3,4,3,99",7))

    [<Test>]
    member this.Example4_LessThanEightFalse() = Assert.AreEqual(0, Day05Part2.runProgram("3,3,1107,-1,8,3,4,3,99",8))

    [<Test>]
    member this.Example4_LessThanEightIsTrue() = Assert.AreEqual(1, Day05Part2.runProgram("3,3,1107,-1,8,3,4,3,99",7))

    //Using position mode

    [<Test>]
    member this.Example5_NonZeroIsFalse() = Assert.AreEqual(0, Day05Part2.runProgram("3,12,6,12,15,1,13,14,13,4,13,99,-1,0,1,9",0))

    [<Test>]
    member this.Example5_NonZeroIsTrue() = Assert.AreEqual(1, Day05Part2.runProgram("3,12,6,12,15,1,13,14,13,4,13,99,-1,0,1,9",10))

    //Using immediate mode

    [<Test>]
    member this.Example6_NonZeroIsFalse() = Assert.AreEqual(0, Day05Part2.runProgram("3,3,1105,-1,9,1101,0,0,12,4,12,99,1",0))

    [<Test>]
    member this.Example6_NonZeroIsTrue() = Assert.AreEqual(1, Day05Part2.runProgram("3,3,1105,-1,9,1101,0,0,12,4,12,99,1",10))

    //Longer Example

    [<Test>]
    member this.Example7_LessThanEightReturns999() = Assert.AreEqual(999, Day05Part2.runProgram("3,21,1008,21,8,20,1005,20,22,107,8,21,20,1006,20,31,1106,0,36,98,0,0,1002,21,125,20,4,20,1105,1,46,104,999,1105,1,46,1101,1000,1,20,4,20,1105,1,46,98,99", 7))

    [<Test>]
    member this.Example7_EqualsEightReturns1000() = Assert.AreEqual(1000, Day05Part2.runProgram("3,21,1008,21,8,20,1005,20,22,107,8,21,20,1006,20,31,1106,0,36,98,0,0,1002,21,125,20,4,20,1105,1,46,104,999,1105,1,46,1101,1000,1,20,4,20,1105,1,46,98,99", 8))

    [<Test>]
    member this.Example7_MoreThanEightReturns1001() = Assert.AreEqual(1001, Day05Part2.runProgram("3,21,1008,21,8,20,1005,20,22,107,8,21,20,1006,20,31,1106,0,36,98,0,0,1002,21,125,20,4,20,1105,1,46,104,999,1105,1,46,1101,1000,1,20,4,20,1105,1,46,98,99", 9))
