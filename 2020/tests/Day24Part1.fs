namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day24Part1 () =
    
    [<Test>]
    member this.West() =       Assert.AreEqual(( 9, 101, -10), Day24Part1.goWest      ((10, 100, -10)))

    [<Test>]
    member this.East() =       Assert.AreEqual((11,  99, -10), Day24Part1.goEast      ((10, 100, -10)))

    [<Test>]
    member this.NorthWest() =  Assert.AreEqual((10, 101, -11), Day24Part1.goNorthWest ((10, 100, -10)))

    [<Test>]
    member this.SouthWest() =  Assert.AreEqual(( 9, 100,  -9), Day24Part1.goSouthWest ((10, 100, -10)))

    [<Test>]
    member this.NorthEast() =  Assert.AreEqual((11, 100, -11), Day24Part1.goNorthEast ((10, 100, -10)))

    [<Test>]
    member this.SouthEast() =  Assert.AreEqual((10,  99,  -9), Day24Part1.goSouthEast ((10, 100, -10)))

    [<Test>]
    member this.ESEW()    = Assert.AreEqual((0,  -1,  1), Day24Part1.getCubeCoord ("esew", (0, 0, 0)))

    [<Test>]
    member this.NWWSWEE() = Assert.AreEqual((0,   0,  0), Day24Part1.getCubeCoord ("nwwswee", (0, 0, 0)))


    [<Test>]
    member this.Example3() = Assert.AreEqual(10, Day24Part1.countTiles (File.ReadAllLines("../../../data/Day24/test3.txt")))