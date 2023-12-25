namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day15Part2 () =

    [<Test>]
    member _.Example1() = Assert.AreEqual((0, "rn", Some 1), Day15Part2.getType("rn=1"))

    [<Test>]
    member _.Example2() = Assert.AreEqual((0, "cm", None), Day15Part2.getType("cm-"))

    [<Test>]
    member _.Example3() = Assert.AreEqual((1, "qp", Some 3), Day15Part2.getType("qp=3"))

    [<Test>]
    member _.Example4() = Assert.AreEqual((0, "cm", Some 2),  Day15Part2.getType("cm=2"))

    [<Test>]
    member _.Example5() = Assert.AreEqual((1, "qp", None),  Day15Part2.getType("qp-"))

    [<Test>]
    member _.Example6() = Assert.AreEqual((3, "pc", Some 4),  Day15Part2.getType("pc=4"))

    [<Test>]
    member _.Example7() = Assert.AreEqual((3, "ot", Some 9),  Day15Part2.getType("ot=9"))

    [<Test>]
    member _.Example8() = Assert.AreEqual((3, "ab", Some 5),  Day15Part2.getType("ab=5"))

    [<Test>]
    member _.Example9() = Assert.AreEqual((3, "pc", None),  Day15Part2.getType("pc-"))

    [<Test>]
    member _.Example10() = Assert.AreEqual((3, "pc", Some 6), Day15Part2.getType("pc=6"))
    
    [<Test>]
    member _.Example11() = Assert.AreEqual((3, "ot", Some 7),  Day15Part2.getType("ot=7"))

    [<Test>]
    member _.ExampleLonger() = Assert.AreEqual((88, "zark", Some 7),  Day15Part2.getType("zark=7"))

    [<Test>]
    member _.GetSum() = Assert.AreEqual(145, Day15Part2.getSum("rn=1,cm-,qp=3,cm=2,qp-,pc=4,ot=9,ab=5,pc-,pc=6,ot=7"))

    [<Test>]
    member _.ApplyStepP1() =
        let box = [|None; None; None; None; None; None; None; None; None; None|]
        let step = ("rn", Some 1)
        let expected = [|Some ("rn", 1); None; None; None; None; None; None; None; None; None|]

        CollectionAssert.AreEqual(expected, Day15Part2.applyStep(box, step))

    [<Test>]
    member _.ApplyStepP2() =
        let box = [|Some ("rn", 1); None; None; None; None; None; None; None; None; None|]
        let step = ("cm", None)
        let expected = [|Some ("rn", 1); None; None; None; None; None; None; None; None; None|]

        CollectionAssert.AreEqual(expected, Day15Part2.applyStep(box, step))

    [<Test>]
    member _.ApplyStepP3() =
        let box = [|Some ("rn", 1); None; None; None; None; None; None; None; None; None|]
        let step = ("qp", Some 3)
        let expected = [|Some ("rn", 1); Some ("qp", 3); None; None; None; None; None; None; None; None|]

        CollectionAssert.AreEqual(expected, Day15Part2.applyStep(box, step))

    [<Test>]
    member _.ApplyStepP4() =
        let box = [|Some ("rn", 1); Some ("qp", 3); None; None; None; None; None; None; None; None|]
        let step = ("cm", Some 2)
        let expected = [|Some ("rn", 1); Some ("qp", 3); Some ("cm", 2); None; None; None; None; None; None; None|]

        CollectionAssert.AreEqual(expected, Day15Part2.applyStep(box, step))

    [<Test>]
    member _.ApplyStepP5() =
        let box = [|Some ("rn", 1); Some ("qp", 3); Some ("cm", 2); None; None; None; None; None; None; None|]
        let step = ("qp", None)
        let expected = [|Some ("rn", 1); Some ("cm", 2); None; None; None; None; None; None; None; None|]

        CollectionAssert.AreEqual(expected, Day15Part2.applyStep(box, step))

    [<Test>]
    member _.MoveNonesToEnd() =
        let box = [|Some ("rn", 1); Some ("qp", 3); Some ("cm", 2); None; None; None; None; None; None; None|]
        let step = ("qp", None)

        let before = [|Some ("rn", 1); None; Some ("cm", 2); None; Some ("zy", 77); None|]
        let after  = [|Some ("rn", 1); Some ("cm", 2); Some ("zy", 77); None; None; None|]

        CollectionAssert.AreEqual(after, Day15Part2.moveNonesToEnd(before))

    [<Test>]
    member _.ApplyStepP6() =
        let box = [|Some ("rn", 1); Some ("cm", 2); None; None; None; None; None; None; None; None|]
        let step = ("pc", Some 4)
        let expected = [|Some ("rn", 1); Some ("cm", 2); Some ("pc", 4); None; None; None; None; None; None; None|]

        CollectionAssert.AreEqual(expected, Day15Part2.applyStep(box, step))

    [<Test>]
    member _.ApplyStepP7() =
        let box = [|Some ("rn", 1); Some ("cm", 2); None; None; None; None; None; None; None; None|]
        let step = ("pc", Some 6)
        let expected = [|Some ("rn", 1); Some ("cm", 2); Some ("pc", 6); None; None; None; None; None; None; None|]

        CollectionAssert.AreEqual(expected, Day15Part2.applyStep(box, step))

    [<Test>]
    member _.SumBox() =
        let box = [|Some ("xx", 7); Some ("xx", 5); Some ("xx", 6); None; None; None; None; None; None; None|]
        Assert.AreEqual(35, Day15Part2.sumBox(box))
