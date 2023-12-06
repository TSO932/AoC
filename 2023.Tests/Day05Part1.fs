namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day05Part1 () =

    [<Test>]
    member _.ParseMapLine() = CollectionAssert.AreEqual([|50; 98; 2|], Day05Part1.parseMapLine "50 98 2")

    [<Test>]
    member _.GetNextValue79() = Assert.AreEqual(81, Day05Part1.getNextValue (79, [|"50 98 2"; "52 50 48"|]))

    [<Test>]
    member _.GetNextValue14() = Assert.AreEqual(14, Day05Part1.getNextValue (14, [|"50 98 2"; "52 50 48"|]))

    [<Test>]
    member _.GetNextValue55() = Assert.AreEqual(57, Day05Part1.getNextValue (55, [|"50 98 2"; "52 50 48"|]))

    [<Test>]
    member _.GetNextValue13() = Assert.AreEqual(13, Day05Part1.getNextValue (13, [|"50 98 2"; "52 50 48"|]))

