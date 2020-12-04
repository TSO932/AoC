namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type DayXXPartY () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(0, DayXXPartY.runProgram (File.ReadAllLines("../../../data/DayXX/test1.txt")))