namespace AoC2019.Tests

open NUnit.Framework
open AoC2019

[<TestFixture>] 
type Day02Part1 () =

    [<Test>]
    member this.Example1() = CollectionAssert.AreEqual([3500;9;10;70;2;3;11;0;99;30;40;50], Day02Part1.runProgram("1,9,10,3,2,3,11,0,99,30,40,50"))
    
    [<Test>]
    member this.Example2() = CollectionAssert.AreEqual([2;0;0;0;99], Day02Part1.runProgram("1,0,0,0,99"))
    
    [<Test>]
    member this.Example3() = CollectionAssert.AreEqual([2;3;0;6;99], Day02Part1.runProgram("2,3,0,3,99"))
    
    [<Test>]
    member this.Example4() = CollectionAssert.AreEqual([2;4;4;5;99;9801], Day02Part1.runProgram("2,4,4,5,99,0"))
    
    [<Test>]
    member this.Example5() = CollectionAssert.AreEqual([30;1;1;4;2;5;6;0;99], Day02Part1.runProgram("1,1,1,4,99,5,6,0,99"))

    [<Test>]
    member this.TestGetFirstIntCode() = Assert.AreEqual(99, Day02Part1.getFirstIntCode("99,1,2,3"))