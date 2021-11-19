namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day19Part1 () =

    [<Test>]
    member _.GetElementsInFormula() = CollectionAssert.AreEqual([|"H";"He";"Li";"Be";"B";"C";"N";"O";"F";"Ne"|], Day19Part1.getElementsInFormula("HHeLiBeBCNOFNe"))

    [<Test>]
    member _.GetReactions() =
        let dict = Day19Part1.getReactions([|"H => HeOs"; "H => OH"; "O => HH"|])
        CollectionAssert.AreEqual([| [|"He"; "Os"|] ; [|"O"; "H"|] |], dict.["H"])

    [<Test>]
    member _.GetReactionsAtSingleSiteWhereNone() =
        let dict = Day19Part1.getReactions([|"H => HO"|])
        let molecule = [|"U"|]
        
        CollectionAssert.AreEqual([], Day19Part1.getReactionsAtSingleSite(molecule, dict, 0))

    [<Test>]
    member _.GetDistinctProductsHOHOHO() =
        let dict = Day19Part1.getReactions([|"H => HO"; "H => OH"; "O => HH"|])
        let molecule = [|"H";"O";"H";"O";"H";"O"|]
        
        Assert.AreEqual(7, Day19Part1.getDistinctProducts(molecule, dict))

    [<Test>]
    member _.GetDistinctProductsHOH() =
        let dict = Day19Part1.getReactions([|"H => HO"; "H => OH"; "O => HH"|])
        let molecule = [|"H";"O";"H"|]
        
        Assert.AreEqual(4, Day19Part1.getDistinctProducts(molecule, dict))

    [<Test>]
    member _.Example1() = Assert.AreEqual(4, Day19Part1.countDistinctMolecules([|"H => HO"; "H => OH"; "O => HH"; ""; "HOH"; ""|]))

    [<Test>]
    member _.Example2() = Assert.AreEqual(7, Day19Part1.countDistinctMolecules([|"H => HO"; "H => OH"; "O => HH"; ""; "HOHOHO"; ""|]))

   