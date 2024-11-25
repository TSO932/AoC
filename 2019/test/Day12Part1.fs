namespace AoC2019.Tests

open NUnit.Framework
open AoC2019

[<TestFixture>] 
type Day12Part1 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(179, Day12Part1.runSimulation([(-1, 0, 2); (2, -10, -7); (4, -8, 8); (3, 5, -1)], 10))

    [<Test>]
    member this.Example2() = Assert.AreEqual(1940, Day12Part1.runSimulation([(-8, -10, 0); (5, 5, 10); (2, -7, 3); (9, -8, -3)], 100))

    [<Test>]
    member this.Formater() = Assert.AreEqual([(-1,0,2);(2,-10,-7)], Day12Part1.readCoordinates(["<x=-1, y=0, z=2>"; "<x=2, y=-10, z=-7>"]))