namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day25Part1() =

    [<DefaultValue>]
    val mutable exampleInput: seq<string>

    [<DefaultValue>]
    val mutable myHouse: seq<string>

    [<DefaultValue>]
    val mutable myEdges: seq<string * string>

    [<SetUp>]
    member this.SetUp() =

        this.exampleInput <-
            seq {
                "jqt: rhn xhk nvd"
                "rsh: frs pzl lsr"
                "xhk: hfx"
                "cmg: qnr nvd lhk bvb"
                "rhn: xhk bvb hfx"
                "bvb: xhk hfx"
                "pzl: lsr hfx nvd"
                "qnr: nvd"
                "ntq: jqt hfx bvb xhk"
                "nvd: lhk"
                "lsr: lhk"
                "rzs: qnr cmg lsr rsh"
                "frs: qnr lhk lsr"
            }


        //     d
        //    / \
        //   e - c
        //   | x |
        //   a - b

        this.myHouse <-
            seq {
                "a: b"
                "e: a b c d"
                "c: d a b"
            }

        this.myEdges <-
            seq {
                ("a", "b")
                ("e", "a")
                ("e", "b")
                ("e", "c")
                ("e", "d")
                ("c", "d")
                ("c", "a")
                ("c", "b")
            }

    [<Test>]
    member this.GetEdges() =

        let result =
            Day25Part1.getEdges (
                seq {
                    "a: b"
                    "e: a b c d"
                    "c: d a b"
                }
            )

        CollectionAssert.AreEqual(this.myEdges, result)

    [<Test>]
    member this.GetEdgesToDisconnectMyHouse() =

        let result =
            Day25Part1.getEdgesToDisconnect (this.myEdges, 2)
            |> Seq.map (fun (a, b) -> if a < b then (a, b) else (b, a))
            |> Seq.sort

        let expected =
            seq {
                ("c", "d")
                ("d", "e")
            }

        CollectionAssert.AreEqual(expected, result)

    [<Test>]
    member this.GetProductOfSumsMyHouse() =

        let result =
            Day25Part1.getProductOfSums (
                this.myEdges,
                seq {
                    ("c", "d")
                    ("d", "e")
                }
            )

        Assert.AreEqual(4, result)

    [<Test>]
    member this.GetProductOfSumsExample() =

        let inputEdges = Day25Part1.getEdges (this.exampleInput)

        let inputDisconnects =
            seq {
                ("bvb", "cmg")
                ("hfx", "pzl")
                ("jqt", "nvd")
            }

        let result = Day25Part1.getProductOfSums (inputEdges, inputDisconnects)

        Assert.AreEqual(54, result)

    [<Test>]
    member this.GetEdgesToDisconnectExample() =

        let inputEdges = Day25Part1.getEdges (this.exampleInput)

        let result =
            Day25Part1.getEdgesToDisconnect (inputEdges, 3)
            |> Seq.map (fun (a, b) -> if a < b then (a, b) else (b, a))
            |> Seq.sort

        let expected =
            seq {
                ("bvb", "cmg")
                ("hfx", "pzl")
                ("jqt", "nvd")
            }

        CollectionAssert.AreEqual(expected, result)

    [<Test>]
    member this.GetSum() =
        Assert.AreEqual(54, Day25Part1.getResult (this.exampleInput))
