namespace AoC2017.Tests

open NUnit.Framework
open AoC2017

[<TestFixture>]
type Day07Part1() =

    [<Test>]
    member _.TestParse() =
        let input =
            seq {
                "pbga (66)"
                "xhth (57)"
                "ebii (61)"
                "havc (66)"
                "ktlj (57)"
                "fwft (72) -> ktlj, cntj, xhth"
                "qoyq (66)"
                "padx (45) -> pbga, havc, qoyq"
                "tknk (41) -> ugml, padx, fwft"
                "jptl (61)"
                "ugml (68) -> gyxo, ebii, jptl"
                "gyxo (61)"
                "cntj (57)"
            }

        let expected =
            [ ("pbga", [])
              ("xhth", [])
              ("ebii", [])
              ("havc", [])
              ("ktlj", [])
              ("fwft", [ "ktlj"; "cntj"; "xhth" ])
              ("qoyq", [])
              ("padx", [ "pbga"; "havc"; "qoyq" ])
              ("tknk", [ "ugml"; "padx"; "fwft" ])
              ("jptl", [])
              ("ugml", [ "gyxo"; "ebii"; "jptl" ])
              ("gyxo", [])
              ("cntj", []) ]

        CollectionAssert.AreEqual(expected, Day07Part1.parse input)

    [<Test>]
    member _.TestRemoveTops1() =

        let input =
            [ ("pbga", [])
              ("xhth", [])
              ("ebii", [])
              ("havc", [])
              ("ktlj", [])
              ("fwft", [ "ktlj"; "cntj"; "xhth" ])
              ("qoyq", [])
              ("padx", [ "pbga"; "havc"; "qoyq" ])
              ("tknk", [ "ugml"; "padx"; "fwft" ])
              ("jptl", [])
              ("ugml", [ "gyxo"; "ebii"; "jptl" ])
              ("gyxo", [])
              ("cntj", []) ]

        let expected =
            [ ("fwft", [])
              ("padx", [])
              ("tknk", [ "ugml"; "padx"; "fwft" ])
              ("ugml", []) ]

        CollectionAssert.AreEqual(expected, Day07Part1.removeTops input)

    [<Test>]
    member _.TestRemoveTops2() =

        let input =
            [ ("fwft", [])
              ("padx", [])
              ("tknk", [ "ugml"; "padx"; "fwft" ])
              ("ugml", []) ]

        let expected = [ ("tknk", List.empty<string>) ]

        CollectionAssert.AreEqual(expected, Day07Part1.removeTops input)

    [<Test>]
    member _.TestFindBase() =

        let input =
            [ ("pbga", [])
              ("xhth", [])
              ("ebii", [])
              ("havc", [])
              ("ktlj", [])
              ("fwft", [ "ktlj"; "cntj"; "xhth" ])
              ("qoyq", [])
              ("padx", [ "pbga"; "havc"; "qoyq" ])
              ("tknk", [ "ugml"; "padx"; "fwft" ])
              ("jptl", [])
              ("ugml", [ "gyxo"; "ebii"; "jptl" ])
              ("gyxo", [])
              ("cntj", []) ]

        Assert.AreEqual("tknk", Day07Part1.findBase input)
