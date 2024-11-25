namespace AoC2019.Tests

open System
open NUnit.Framework
open AoC2019

[<TestFixture>] 
type Day11Part1 () =

    [<Test>]
    member this.rotate_Up___Left()  = Assert.AreEqual(((-1,  0), 270), Day11Part1.rotate(((0, 0),   0),  0))
    
    [<Test>]
    member this.rotate_Left_Left()  = Assert.AreEqual((( 0,  1), 180), Day11Part1.rotate(((0, 0), 270),  0))
    
    [<Test>]
    member this.rotate_Down_Left()  = Assert.AreEqual((( 1,  0),  90), Day11Part1.rotate(((0, 0), 180),  0))
    
    [<Test>]
    member this.rotate_RightLeft()  = Assert.AreEqual((( 0, -1),   0), Day11Part1.rotate(((0, 0),  90),  0))
    
    [<Test>]
    member this.rotate_Up___Right() = Assert.AreEqual((( 1,  0),  90), Day11Part1.rotate(((0, 0),   0),  1))
    
    [<Test>]
    member this.rotate_Left_Right() = Assert.AreEqual((( 0, -1),   0), Day11Part1.rotate(((0, 0), 270),  1))
    
    [<Test>]
    member this.rotate_Down_Right() = Assert.AreEqual(((-1,  0), 270), Day11Part1.rotate(((0, 0), 180),  1))
    
    [<Test>]
    member this.rotate_RightRight() = Assert.AreEqual((( 0,  1), 180), Day11Part1.rotate(((0, 0),  90),  1))
    
    [<Test>]
    member this.rotate_WayOver()    = Assert.AreEqual((( 0,  1), 180), Day11Part1.rotate(((0, 0), 810),  1))
    
    [<Test>]
    member this.rotate_WayUnder()   = Assert.AreEqual(((-1,  0), 270), Day11Part1.rotate(((0, 0),-540),  1))

    [<Test>]
    member this.rotate_BadAngle() = Assert.Throws<ArgumentException> (fun() -> Day11Part1.rotate(((0, 0),  45),  1) |> ignore) |> ignore

    [<Test>]
    member this.rotate_BadDirection() = Assert.Throws<ArgumentException> (fun() -> Day11Part1.rotate(((0, 0),   0),  2) |> ignore) |> ignore
