namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day12Part1 () =

    [<Test>]
    member this.Example1Step1() = Assert.AreEqual(10, Day12Part1.navigate (seq {"F10"}))

    [<Test>]
    member this.Example1Step2() = Assert.AreEqual(13, Day12Part1.navigate (seq {"F10"; "N3"}))
    
    [<Test>]
    member this.Example1Step3() = Assert.AreEqual(20, Day12Part1.navigate (seq {"F10"; "N3"; "F7"}))
    
    [<Test>]
    member this.Example1Step4() = Assert.AreEqual(20, Day12Part1.navigate (seq {"F10"; "N3"; "F7"; "R90"}))
    
    [<Test>]
    member this.Example1Step5() = Assert.AreEqual(25, Day12Part1.navigate (seq {"F10"; "N3"; "F7"; "R90"; "F11"}))
    
    [<Test>]
    member this.Example1() = Assert.AreEqual(25, Day12Part1.navigate (File.ReadAllLines("../../../data/Day12/test1.txt")))