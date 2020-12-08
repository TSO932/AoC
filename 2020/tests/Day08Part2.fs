namespace AoC2020.Tests

open System
open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day08Part2 () =

    [<Test>]
    member this.Example1() = Assert.Throws<ArgumentException> (fun() -> Day08Part2.fixAndRun (File.ReadAllLines("../../../data/Day08/test2.txt")) |> ignore) |> ignore
    [<Test>]
    member this.Example2() = Assert.AreEqual(8, Day08Part2.fixAndRun (File.ReadAllLines("../../../data/Day08/test3.txt")))