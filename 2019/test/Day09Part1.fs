namespace AoC2019.Tests

open NUnit.Framework
open AoC2019

[<TestFixture>] 
type Day09Part1 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(99, Day09Part1.runProgram("109,1,204,-1,1001,100,1,100,1008,100,16,101,1006,101,0,99", [|0L|]))

    [<Test>]
    member this.Example2() =
        Assert.GreaterOrEqual(Day09Part1.runProgram("1102,34915192,34915192,7,4,7,99,0",  [|0L|]),  1000000000000000L)
        Assert.Less(          Day09Part1.runProgram("1102,34915192,34915192,7,4,7,99,0",  [|0L|]), 10000000000000000L)
                                            
    [<Test>]
    member this.Example3() = Assert.AreEqual(1125899906842624L, Day09Part1.runProgram("104,1125899906842624,99", [|0L|]))