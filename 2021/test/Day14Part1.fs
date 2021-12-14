namespace AoC2021.Tests

open NUnit.Framework
open AoC2021

[<TestFixture>] 
type Day14Part1 () =

    [<DefaultValue>] val mutable example  : seq<string>

    [<SetUp>]
    member this.SetUp() =
        this.example <-
            [| "NNCB"; ""; "CH -> B"; "HH -> N"; "CB -> H"; "NH -> C"; "HB -> C"; "HC -> B"; "HN -> C"; "NN -> C"; "BH -> H"; "NC -> B";
             "NB -> B"; "BN -> B"; "BB -> N"; "BC -> B"; "CC -> N"; "CN -> C" |]

    [<Test>]
    member this.ParseRules() =

        let result = Day14Part1.parseRules(this.example)

        Assert.AreEqual( 16, result |> Map.keys |> Seq.length, "count" )
        Assert.AreEqual( 'B', result[ ('C','H') ], "first row" )
        Assert.AreEqual( 'C', result[ ('C','N') ], "last row" )

    [<Test>]
    member this.Step1() =

        let rules  = Day14Part1.parseRules(this.example)
        let result = Day14Part1.insert(rules, "NNCB")

        Assert.AreEqual( "NCNBCHB", result )

    [<Test>]
    member this.Step2() =

        let rules  = Day14Part1.parseRules(this.example)
        let result = Day14Part1.insert(rules, "NCNBCHB")

        Assert.AreEqual( "NBCCNBBBCBHCB", result )

    [<Test>]
    member this.Step3() =

        let rules  = Day14Part1.parseRules(this.example)
        let result = Day14Part1.insert(rules, "NBCCNBBBCBHCB")

        Assert.AreEqual( "NBBBCNCCNBBNBNBBCHBHHBCHB", result )


    [<Test>]
    member this.Step4() =

        let rules  = Day14Part1.parseRules(this.example)
        let result = Day14Part1.insert(rules, "NBBBCNCCNBBNBNBBCHBHHBCHB")

        Assert.AreEqual( "NBBNBNBBCCNBCNCCNBBNBBNBBBNBBNBBCBHCBHHNHCBBCBHCB", result )

    [<Test>]
    member this.Step5() =

        let rules  = Day14Part1.parseRules(this.example)
        let result = Day14Part1.doSteps(rules, "NNCB", 5)

        Assert.AreEqual( 97, String.length result )

    
    [<Test>]
    member this.Step10() =

        let rules  = Day14Part1.parseRules(this.example)
        let result = Day14Part1.doSteps(rules, "NNCB", 10)

        Assert.AreEqual( 3073, String.length result )

    [<Test>]
    member this.LargestMinusSmallest() =

        let rules  = Day14Part1.parseRules(this.example)
        let polymer = Day14Part1.doSteps(rules, "NNCB", 10)
        let result = Day14Part1.largestMinusSmallest(polymer)

        Assert.AreEqual( 1588, result )

    [<Test>]
    member this.Run() = Assert.AreEqual( 1588, Day14Part1.run(this.example) )