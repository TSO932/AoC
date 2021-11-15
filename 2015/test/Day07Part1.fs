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
    member _.ParseExample1() = Assert.AreEqual({Day07Part1.Op = "" ; Day07Part1.In1 = "123" ; Day07Part1.In2 = "" ; Day07Part1.Out = "x"}, Day07Part1.parseInstruction "123 -> x")
    
    [<Test>]
    member _.ParseExample2() = Assert.AreEqual({Day07Part1.Op = "AND" ; Day07Part1.In1 = "x" ; Day07Part1.In2 = "y" ; Day07Part1.Out = "z"}, Day07Part1.parseInstruction "x AND y -> z")

    [<Test>]
    member _.ParseExample3() = Assert.AreEqual({Day07Part1.Op = "LSHIFT" ; Day07Part1.In1 = "p" ; Day07Part1.In2 = "2" ; Day07Part1.Out = "q"}, Day07Part1.parseInstruction "p LSHIFT 2 -> q")

    [<Test>]
    member _.ParseExample4() = Assert.AreEqual({Day07Part1.Op = "NOT" ; Day07Part1.In1 = "e" ; Day07Part1.In2 = "" ; Day07Part1.Out = "f"}, Day07Part1.parseInstruction "NOT e -> f")

    [<Test>]
    member this.ApplyExample1() =
        this.signalBoard.ApplyInstruction (Day07Part1.parseInstruction "99 -> x")
        this.signalBoard.ApplyInstruction (Day07Part1.parseInstruction "123 -> x")
        Assert.AreEqual(123, this.signalBoard.GetSignalValue "x"  )

    [<Test>]
    member this.ApplyExample2() =
        this.signalBoard.ApplyInstruction (Day07Part1.parseInstruction "3 -> x")
        this.signalBoard.ApplyInstruction (Day07Part1.parseInstruction "7 -> y")
        this.signalBoard.ApplyInstruction (Day07Part1.parseInstruction "x AND y -> z")
        Assert.AreEqual(3, this.signalBoard.GetSignalValue "z"  )
    
    [<Test>]
    member this.ApplyMainExample() =
        this.signalBoard.ApplyInstruction (Day07Part1.parseInstruction "123 -> x")
        this.signalBoard.ApplyInstruction (Day07Part1.parseInstruction "456 -> y")
        this.signalBoard.ApplyInstruction (Day07Part1.parseInstruction "x AND y -> d")
        this.signalBoard.ApplyInstruction (Day07Part1.parseInstruction "x OR y -> e")
        this.signalBoard.ApplyInstruction (Day07Part1.parseInstruction "x LSHIFT 2 -> f")
        this.signalBoard.ApplyInstruction (Day07Part1.parseInstruction "y RSHIFT 2 -> g")
        this.signalBoard.ApplyInstruction (Day07Part1.parseInstruction "NOT x -> h")
        this.signalBoard.ApplyInstruction (Day07Part1.parseInstruction "NOT y -> i")

        Assert.AreEqual(72,    this.signalBoard.GetSignalValue "d"  )
        Assert.AreEqual(507,   this.signalBoard.GetSignalValue "e"  )
        Assert.AreEqual(492,   this.signalBoard.GetSignalValue "f"  )
        Assert.AreEqual(114,   this.signalBoard.GetSignalValue "g"  )
        Assert.AreEqual(65412, this.signalBoard.GetSignalValue "h"  )
        Assert.AreEqual(65079, this.signalBoard.GetSignalValue "i"  )
        Assert.AreEqual(123,   this.signalBoard.GetSignalValue "x" )
        Assert.AreEqual(456,   this.signalBoard.GetSignalValue "y"  )

    [<Test>]
    member this.NonSequential() =
        this.signalBoard.ApplyInstructions ([|Day07Part1.parseInstruction "x OR y -> p"
                                            ; Day07Part1.parseInstruction "9 -> x"
                                            ; Day07Part1.parseInstruction "6 -> y" |])

        Assert.AreEqual(15, this.signalBoard.GetSignalValue "p"  )

    [<Test>]
    member _.GetSignalValueA() = Assert.AreEqual(72, Day07Part1.getSignalValueA ([|"123 -> x"; "456 -> y"; "x AND y -> a"|]))