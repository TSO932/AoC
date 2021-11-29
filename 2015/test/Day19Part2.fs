namespace AoC2015.Tests

open NUnit.Framework
open AoC2015
open System.Collections.Generic

[<TestFixture>] 
type Day19Part2 () =

    [<DefaultValue>] val mutable reactions : Dictionary<string, seq<seq<string>>>

    [<SetUp>]
    member this.SetUp() =
        this.reactions <- Day19Part1.getReactions([|"e => H"; "e => O"; "H => HO"; "H => OH"; "O => HH"|])

    [<Test>]
    member _.GetDistinctProductsE() =
        let reactions = Day19Part1.getReactions([|"e => H"; "e => O"; "H => HO"; "H => OH"; "O => HH"|])

        Assert.AreEqual([[|"H"|]; [|"O"|]], Day19Part2.getDistinctProducts([|"e"|], reactions))

    [<Test>]
    member this.GetDistinctProductsOH() =
        Assert.AreEqual([[|"H"; "H"; "H"|]; [|"O"; "H"; "O"|]; [|"O"; "O"; "H"|]], Day19Part2.getDistinctProducts([|"O"; "H"|], this.reactions))

    [<Test>]
    member this.GetDistinctProductsHH() =
        Assert.AreEqual([[|"H"; "O"; "H"|]; [|"O"; "H"; "H"|]; [|"H"; "H"; "O"|]], Day19Part2.getDistinctProducts([|"H"; "H"|], this.reactions))

    [<Test>]
    member this.GetDistinctProductsHO() =
        Assert.AreEqual([[|"H"; "O"; "O"|]; [|"O"; "H"; "O"|]; [|"H"; "H"; "H"|]], Day19Part2.getDistinctProducts([|"H"; "O"|], this.reactions))

    [<Test>]
    member this.GetDistinctProductsForMultipleReactants() =
        Assert.AreEqual([[|"H"; "O"; "H"|]; [|"O"; "H"; "H"|]; [|"H"; "H"; "O"|]; [|"H"; "O"; "O"|]; [|"O"; "H"; "O"|]; [|"H"; "H"; "H"|]; [|"O"; "O"; "H"|]],
            Day19Part2.getDistinctProductsForMultipleReactants([[|"H"; "H"|]; [|"H"; "O"|]; [|"O"; "H"|]], this.reactions))

    [<Test>]
    member this.Itterate0() = Assert.AreEqual(0, Day19Part2.itterate(0, this.reactions, "HOHOHO", [|[|"H";"O";"H";"O";"H";"O"|]; [|"P";"La";"Y"; "Er"|]|]))

    [<Test>]
    member this.Itterate3() = Assert.AreEqual(3, Day19Part2.itterate(0, this.reactions, "HOH", [|[|"e"|]|]))

    [<Test>]
    member this.Itterate6() = Assert.AreEqual(6, Day19Part2.itterate(0, this.reactions, "HOHOHO", [|[|"e"|]|]))


