namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day23Part1 () =

    [<Test>]
    member this.GetCircleOfCups() = Assert.AreEqual([|2; 4; 6; 8|], Day23Part1.getCircleOfCups("2468"))

    [<Test>]
    member this.GetDestinationPosition() = Assert.AreEqual(4, Day23Part1.getDestinationPosition([|116; 104; 132; 108; 107; 102|]))

    [<Test>]
    member this.GetDestinationPositionWrapAround() = Assert.AreEqual(5, Day23Part1.getDestinationPosition([|102; 116; 104; 132; 107; 108|]))

    [<Test>]
    member this.RotateCircle() = Assert.AreEqual([|116; 104; 132; 108; 107; 102|], Day23Part1.rotateCircle(1, [|102; 116; 104; 132; 108; 107|]))

    [<Test>]
    member this.CutAndShunt() = Assert.AreEqual([|10; 8; 1; 2; 3|], Day23Part1.cutAndShunt([|10; 1; 2; 3; 8|]))

    [<Test>]
    member this.Example1Move1() = Assert.AreEqual([|2; 8; 9; 1; 5; 4; 6; 7; 3|], Day23Part1.play(1, [|3; 8; 9; 1; 2; 5; 4; 6; 7|]))

    [<Test>]
    member this.Example1Move2() = Assert.AreEqual([|5; 4; 6; 7; 8; 9; 1; 3; 2|], Day23Part1.play(2, [|3; 8; 9; 1; 2; 5; 4; 6; 7|]))

    [<Test>]
    member this.Example1Move10() = Assert.AreEqual([|8; 3; 7; 4; 1; 9; 2; 6; 5|], Day23Part1.play(10, [|3; 8; 9; 1; 2; 5; 4; 6; 7|]))
