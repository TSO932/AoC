namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020
open System

[<TestFixture>] 
type Day14Part2 () =

    [<Test>]
    member this.ConvertMask() = Assert.AreEqual([|"XX01XX10"; "XX01XX11"; "XX11XX10"; "XX11XX11"|], Day14Part2.convertMask("00X1001X"))

    [<Test>]
    member this.ConvertMaskError() = Assert.Throws<ArgumentException> (fun() -> Day14Part2.convertMask("00X10012") |> ignore) |> ignore

    [<Test>]
    member this.GetBinaryFromDecimal() = Assert.AreEqual("101001000100001000001000000100000001", Day14Part2.getBinaryFromDecimal (44092653825L))

    [<Test>]
    member this.InitializeFerryDockingProgram() = Assert.AreEqual(208, Day14Part2.initializeFerryDockingProgram(File.ReadAllLines("../../../data/Day14/test2.txt")))