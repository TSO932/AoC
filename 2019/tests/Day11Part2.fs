namespace AoC2019.Tests

open NUnit.Framework
open AoC2019

[<TestFixture>] 
type Day11Part2 () =

    //Running these in the test framework doesn't actually display the output anywhere
    
    [<Test>]
    member this.Example() =
        Day11Part2.runExampleProgram

    [<Test>]
    member this.MN() =
        Day11Part2.runTestProgram