namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day15Part1 () =

    [<Test>]
    member _.example1() = Assert.AreEqual(30, Day15Part1.runAlgoritm("rn=1"))

    [<Test>]
    member _.example2() = Assert.AreEqual(253, Day15Part1.runAlgoritm("cm-"))

    [<Test>]
    member _.example3() = Assert.AreEqual(97, Day15Part1.runAlgoritm("qp=3"))

    [<Test>]
    member _.example4() = Assert.AreEqual(47, Day15Part1.runAlgoritm("cm=2"))

    [<Test>]
    member _.example5() = Assert.AreEqual(14, Day15Part1.runAlgoritm("qp-"))

    [<Test>]
    member _.example6() = Assert.AreEqual(180, Day15Part1.runAlgoritm("pc=4"))

    [<Test>]
    member _.example7() = Assert.AreEqual(9, Day15Part1.runAlgoritm("ot=9"))

    [<Test>]
    member _.example8() = Assert.AreEqual(197, Day15Part1.runAlgoritm("ab=5"))

    [<Test>]
    member _.example9() = Assert.AreEqual(48, Day15Part1.runAlgoritm("pc-"))

    [<Test>]
    member _.example10() = Assert.AreEqual(214, Day15Part1.runAlgoritm("pc=6"))
    
    [<Test>]
    member _.example11() = Assert.AreEqual(231, Day15Part1.runAlgoritm("ot=7"))

    [<Test>]
    member _.exampleAll() = Assert.AreEqual(1320, Day15Part1.getSum("rn=1,cm-,qp=3,cm=2,qp-,pc=4,ot=9,ab=5,pc-,pc=6,ot=7"))

