namespace AoC2022.Tests

open System.IO
open NUnit.Framework
open AoC2022

[<TestFixture>] 
type Day07Part2 () =

    [<Test>]
    member _.example() = Assert.AreEqual(24933642, Day07Part2.runProgram (File.ReadAllLines("../../../../input/Day07/test.txt")))