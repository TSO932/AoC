namespace _2024.Tests

open NUnit.Framework
open _2024

[<TestFixture>] 
type Day14Part1 () =


    [<DefaultValue>]
    val mutable b: Day14Part1.Board

    [<SetUp>]
    member this.SetUp() =
        this.b <- Day14Part1.Board(Day14Part1.BoardType.Test)

    [<Test>]
    member _.ParseLine() = Assert.That(Day14Part1.parseLine("p=0,4 v=3,-3"), Is.EqualTo([|0; 4; 3; -3|]))

    [<Test>]
    member this.Move1() = Assert.That(Day14Part1.move(this.b, [|2; 4; 2; -3|]), Is.EqualTo([|4; 1; 2; -3|]))

    [<Test>]
    member this.Move2() = Assert.That(Day14Part1.move(this.b, [|4; 1; 2; -3|]), Is.EqualTo([|6; 5; 2; -3|]))

    [<Test>]
    member this.Move3() = Assert.That(Day14Part1.move(this.b, [|6; 5; 2; -3|]), Is.EqualTo([|8; 2; 2; -3|]))

    [<Test>]
    member this.Move4() = Assert.That(Day14Part1.move(this.b, [|8; 2; 2; -3|]), Is.EqualTo([|10; 6; 2; -3|]))

    [<Test>]
    member this.Move5() = Assert.That(Day14Part1.move(this.b, [|10; 6; 2; -3|]), Is.EqualTo([|1; 3; 2; -3|]))

    [<Test>]
    member this.AssignQuadrantXV() = Assert.That(Day14Part1.assignQuadrant(this.b, [|1; 3; 1; 1|]), Is.EqualTo("X"))

    [<Test>]
    member this.AssignQuadrantXH() = Assert.That(Day14Part1.assignQuadrant(this.b, [|5; 1; 1; 1|]), Is.EqualTo("X"))

    [<Test>]
    member this.AssignQuadrantXVH() = Assert.That(Day14Part1.assignQuadrant(this.b, [|5; 3; 1; 1|]), Is.EqualTo("X"))

    [<Test>]
    member this.AssignQuadrantUL() = Assert.That(Day14Part1.assignQuadrant(this.b, [|4; 2; 1; 1|]), Is.EqualTo("UL"))

    [<Test>]
    member this.AssignQuadrantUR() = Assert.That(Day14Part1.assignQuadrant(this.b, [|6; 2; 1; 1|]), Is.EqualTo("UR"))

    [<Test>]
    member this.AssignQuadrantLL() = Assert.That(Day14Part1.assignQuadrant(this.b, [|4; 4; 1; 1|]), Is.EqualTo("LL"))

    [<Test>]
    member this.AssignQuadrantLR() = Assert.That(Day14Part1.assignQuadrant(this.b, [|6; 4; 1; 1|]), Is.EqualTo("LR"))

    [<Test>]
    member _.Example() =

        let input = seq {
            "p=0,4 v=3,-3";
            "p=6,3 v=-1,-3";
            "p=10,3 v=-1,2";
            "p=2,0 v=2,-1";
            "p=0,0 v=1,3";
            "p=3,0 v=-2,-2";
            "p=7,6 v=-1,-3";
            "p=3,0 v=-1,-2";
            "p=9,3 v=2,3";
            "p=7,3 v=-1,2";
            "p=2,4 v=2,-3";
            "p=9,5 v=-3,-3" }
    
        Assert.That(Day14Part1.runTest(input), Is.EqualTo(12))


        //1208340 too low
        //42768000 too low
        //224430336 too high
        //221655456
        //221655456
