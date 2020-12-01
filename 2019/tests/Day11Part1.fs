namespace AoC2019.Tests

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


    //The  next two tests are checking the error message.  They're not actually checking that the exeption is being thrown in the first place.
    //They tests don't fail if no execption is thrown.
    
    [<Test>]
    member this.rotate_BadAngle()   = 
        try (Day11Part1.rotate(((0, 0),  45),  1) |> ignore)
        with | :? System.ArgumentException as ex -> Assert.AreEqual("135 (Parameter 'Invalid newDirection input to rotate function. Expected 0, 90, 180 or 270')", ex.Message)

    [<Test>]
    member this.rotate_BadDirection()   = 
        try (Day11Part1.rotate(((0, 0),   0),  2) |> ignore)
        with | :? System.ArgumentException as ex -> Assert.AreEqual("2 (Parameter 'Invalid turnInstruction input to rotate function. Expected 0 or 1')", ex.Message)
