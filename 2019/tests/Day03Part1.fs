namespace AoC2019.Tests

open NUnit.Framework
open AoC2019

[<TestFixture>] 
type Day03Part1 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(6, Day03Part1.getIntersection("R8,U5,L5,D3", "U7,R6,D4,L4"))
    
    [<Test>]
    member this.Example2() = Assert.AreEqual(159, Day03Part1.getIntersection("R75,D30,R83,U83,L12,D49,R71,U7,L72", "U62,R66,U55,R34,D71,R55,D58,R83"))
    
    [<Test>]
    member this.Example3() = Assert.AreEqual(135, Day03Part1.getIntersection("R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51", "U98,R91,D20,R16,D67,R40,U7,R15,U6,R7"))
