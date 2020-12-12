namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day12Part2 () =

    [<Test>]
    member this.Example1Step1() = Assert.AreEqual(110, Day12Part2.navigate (seq {"F10"}))

    [<Test>]
    member this.Example1Step2() = Assert.AreEqual(110, Day12Part2.navigate (seq {"F10"; "N3"}))
    
    [<Test>]
    member this.Example1Step3() = Assert.AreEqual(208, Day12Part2.navigate (seq {"F10"; "N3"; "F7"}))
    
    [<Test>]
    member this.Example1Step4() = Assert.AreEqual(208, Day12Part2.navigate (seq {"F10"; "N3"; "F7"; "R90"}))
    
    [<Test>]
    member this.Example1Step5() = Assert.AreEqual(286, Day12Part2.navigate (seq {"F10"; "N3"; "F7"; "R90"; "F11"; "N0"}))
    
    [<Test>]
    member this.Example1() = Assert.AreEqual(286, Day12Part2.navigate (File.ReadAllLines("../../../data/Day12/test1.txt")))

    [<Test>]
    member this.MyInputStep1() = Assert.AreEqual(0, Day12Part2.navigate (seq {"W5"}))  // ship (0, 0)  waypoint (10, 1) -> (5, 1)

    [<Test>]
    member this.MyInputStep2() = Assert.AreEqual(396, Day12Part2.navigate (seq {"W5"; "F66"}))  // ship (0, 0) -> (-330, 66)  waypoint (5, 1)

    [<Test>]
    member this.MyInputStep3() = Assert.AreEqual(396, Day12Part2.navigate (seq {"W5"; "F66"; "S4"}))  // ship (-330, 66)  waypoint (5, 1) -> (5, -3)

