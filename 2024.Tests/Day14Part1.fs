namespace _2024.Tests

open NUnit.Framework
open _2024

[<TestFixture>] 
type Day14Part1 () =

    [<Test>]
    member _.ParseLine() = Assert.That(Day14Part1.parseLine("p=0,4 v=3,-3"), Is.EqualTo([|0; 4; 3; -3|]))

    [<Test>]
    member _.Move1() = Assert.That(Day14Part1.move([|2; 4; 2; -3|]), Is.EqualTo([|4; 1; 2; -3|]))

    [<Test>]
    member _.Move2() = Assert.That(Day14Part1.move([|4; 1; 2; -3|]), Is.EqualTo([|6; 5; 2; -3|]))

    [<Test>]
    member _.Move3() = Assert.That(Day14Part1.move([|6; 5; 2; -3|]), Is.EqualTo([|8; 2; 2; -3|]))

    [<Test>]
    member _.Move4() = Assert.That(Day14Part1.move([|8; 2; 2; -3|]), Is.EqualTo([|10; 6; 2; -3|]))

    [<Test>]
    member _.Move5() = Assert.That(Day14Part1.move([|10; 6; 2; -3|]), Is.EqualTo([|1; 3; 2; -3|]))

    [<Test>]
    member _.RepeatsAt() = Assert.That(Day14Part1.repeatsAt([|2; 4; 1; 1|]), Is.EqualTo(77))

    [<Test>]
    member _.MoveToEnd() = Assert.That(Day14Part1.moveToEnd([|2; 4; 1; 1|]), Is.EqualTo([|3; 6; 1; 1|]))

    [<Test>]
    member _.AssignQuadrantXV() = Assert.That(Day14Part1.assignQuadrant([|1; 3; 1; 1|]), Is.EqualTo("X"))

    [<Test>]
    member _.AssignQuadrantXH() = Assert.That(Day14Part1.assignQuadrant([|5; 1; 1; 1|]), Is.EqualTo("X"))

    [<Test>]
    member _.AssignQuadrantXVH() = Assert.That(Day14Part1.assignQuadrant([|5; 3; 1; 1|]), Is.EqualTo("X"))

    [<Test>]
    member _.AssignQuadrantUL() = Assert.That(Day14Part1.assignQuadrant([|4; 2; 1; 1|]), Is.EqualTo("UL"))

    [<Test>]
    member _.AssignQuadrantUR() = Assert.That(Day14Part1.assignQuadrant([|6; 2; 1; 1|]), Is.EqualTo("UR"))

    [<Test>]
    member _.AssignQuadrantLL() = Assert.That(Day14Part1.assignQuadrant([|4; 4; 1; 1|]), Is.EqualTo("LL"))

    [<Test>]
    member _.AssignQuadrantLR() = Assert.That(Day14Part1.assignQuadrant([|6; 4; 1; 1|]), Is.EqualTo("LR"))

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