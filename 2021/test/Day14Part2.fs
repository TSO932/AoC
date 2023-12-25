namespace AoC2021.Tests

open NUnit.Framework
open AoC2021

[<TestFixture>] 
type Day14Part2 () =

    [<DefaultValue>] val mutable example  : seq<string>

    [<SetUp>]
    member this.SetUp() =
        this.example <-
            [| "NNCB"; ""; "CH -> B"; "HH -> N"; "CB -> H"; "NH -> C"; "HB -> C"; "HC -> B"; "HN -> C"; "NN -> C"; "BH -> H"; "NC -> B";
             "NB -> B"; "BN -> B"; "BB -> N"; "BC -> B"; "CC -> N"; "CN -> C" |]

    [<Test>]
    member this.ParseRules() =

        let result = Day14Part2.parseRules(this.example)

        Assert.AreEqual( 16, result |> Map.keys |> Seq.length, "count" )
        Assert.AreEqual( [ ('C', 'B'); ('B', 'H') ], result[ ('C','H') ], "first row" )
        Assert.AreEqual( [ ('C', 'C'); ('C', 'N') ],result[ ('C','N') ], "last row" )

    [<Test>]
    member this.Step1() =

        let rules  = Day14Part2.parseRules(this.example)
        let start  = Day14Part2.getStarting("NNCB")
        let result = Day14Part2.insert(rules, start)

        CollectionAssert.AreEqual( [(('N', 'C'), 1); (('C', 'N'), 1); (('N', 'B'), 1); (('B', 'C'), 1); (('C', 'H'), 1); (('H', 'B'), 1)], result )

    [<Test>]
    member this.Step2() =

        let rules  = Day14Part2.parseRules(this.example)
        let start  = Day14Part2.getStarting("NCNBCHB")
        let result = Day14Part2.insert(rules, start)


        CollectionAssert.AreEqual( [(('N', 'B'), 2); (('B', 'C'), 2); (('C', 'C'), 1); (('C', 'N'), 1); (('B', 'B'), 2); (('C', 'B'), 2); (('B', 'H'), 1); (('H', 'C'), 1)], result )

    [<Test>]
    member this.LargestMinusSmallest() =

        let rules   = Day14Part2.parseRules(this.example)
        let start   = Day14Part2.getStarting("NNCB")
        let polymer = Day14Part2.doSteps(rules, start, 40)
        let result  = Day14Part2.largestMinusSmallest(polymer, "NNCB")

        Assert.AreEqual( 2188189693529L, result )

    [<Test>]
    member this.Run() = Assert.AreEqual( 2188189693529L, Day14Part2.run(this.example) )