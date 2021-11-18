namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day19Part1 () =

    [<Test>]
    member _.GetElementsInFormula() = CollectionAssert.AreEqual([|"H";"He";"Li";"Be";"B";"C";"N";"O";"F";"Ne"|], Day19Part1.getElementsInFormula("HHeLiBeBCNOFNe"))

    [<Test>]
    member _.GetReactions() =
        let dict = Day19Part1.getReactions([|"H => HO"; "H => OH"; "O => HH"|])
        CollectionAssert.AreEqual([|"HO"; "OH"|], dict.["H"])
   