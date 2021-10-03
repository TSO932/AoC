namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day07Part1 () =

    [<DefaultValue>] val mutable signalBoard : Day07Part1.SignalBoard

    [<SetUp>]
    member this.SetUp() =
        this.signalBoard <- Day07Part1.SignalBoard()

    [<Test>]
    member _.ParseExample1() = Assert.AreEqual({Day07Part1.op = "" ; Day07Part1.in1 = "123" ; Day07Part1.in2 = "" ; Day07Part1.out = "x"}, Day07Part1.parseInstruction "123 -> x")
    
    [<Test>]
    member _.ParseExample2() = Assert.AreEqual({Day07Part1.op = "AND" ; Day07Part1.in1 = "x" ; Day07Part1.in2 = "y" ; Day07Part1.out = "z"}, Day07Part1.parseInstruction "x AND y -> z")

    [<Test>]
    member _.ParseExample3() = Assert.AreEqual({Day07Part1.op = "LSHIFT" ; Day07Part1.in1 = "p" ; Day07Part1.in2 = "2" ; Day07Part1.out = "q"}, Day07Part1.parseInstruction "p LSHIFT 2 -> q")

    [<Test>]
    member _.ParseExample4() = Assert.AreEqual({Day07Part1.op = "NOT" ; Day07Part1.in1 = "e" ; Day07Part1.in2 = "" ; Day07Part1.out = "f"}, Day07Part1.parseInstruction "NOT e -> f")

    [<Test>]
    member this.ApplyExample1() =
        this.signalBoard.ApplyInstruction "99 -> x"
        this.signalBoard.ApplyInstruction "123 -> x"
        Assert.AreEqual(123, this.signalBoard.GetSignalValue "x"  )

    [<Test>]
    member this.ApplyExample2() =
        this.signalBoard.ApplyInstruction "3 -> x"
        this.signalBoard.ApplyInstruction "7 -> y"
        this.signalBoard.ApplyInstruction "x AND y -> z"
        Assert.AreEqual(3, this.signalBoard.GetSignalValue "z"  )
    
    [<Test>]
    member this.ApplyMainExample() =
        this.signalBoard.ApplyInstruction "123 -> x"
        this.signalBoard.ApplyInstruction "456 -> y"
        this.signalBoard.ApplyInstruction "x AND y -> d"
        this.signalBoard.ApplyInstruction "x OR y -> e"
        this.signalBoard.ApplyInstruction "x LSHIFT 2 -> f"
        this.signalBoard.ApplyInstruction "y RSHIFT 2 -> g"
        this.signalBoard.ApplyInstruction "NOT x -> h"
        this.signalBoard.ApplyInstruction "NOT y -> i"

        Assert.AreEqual(72,    this.signalBoard.GetSignalValue "d"  )
        Assert.AreEqual(507,   this.signalBoard.GetSignalValue "e"  )
        Assert.AreEqual(492,   this.signalBoard.GetSignalValue "f"  )
        Assert.AreEqual(114,   this.signalBoard.GetSignalValue "g"  )
        Assert.AreEqual(65412, this.signalBoard.GetSignalValue "h"  )
        Assert.AreEqual(65079, this.signalBoard.GetSignalValue "i"  )
        Assert.AreEqual(123,   this.signalBoard.GetSignalValue "x" )
        Assert.AreEqual(456,   this.signalBoard.GetSignalValue "y"  )

    [<Test>]
    member _.getSignalValueA() = Assert.AreEqual(72, Day07Part1.getSignalValueA ([|"123 -> x"; "456 -> y"; "x AND y -> a"|]))