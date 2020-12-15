namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day15Part1 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(436,  Day15Part1.playMemoryGame (seq {0; 3; 6}))
    member this.Example2() = Assert.AreEqual(1,    Day15Part1.playMemoryGame (seq {1; 3; 2}))
    member this.Example3() = Assert.AreEqual(10,   Day15Part1.playMemoryGame (seq {2; 1; 3}))
    member this.Example4() = Assert.AreEqual(27,   Day15Part1.playMemoryGame (seq {1; 2; 3}))
    member this.Example5() = Assert.AreEqual(78,   Day15Part1.playMemoryGame (seq {2; 3; 1}))
    member this.Example6() = Assert.AreEqual(438 , Day15Part1.playMemoryGame (seq {3; 2; 1}))
    member this.Example7() = Assert.AreEqual(1836, Day15Part1.playMemoryGame (seq {3; 1; 2}))

