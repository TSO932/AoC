namespace AoC2022.Tests

open NUnit.Framework
open AoC2022

[<TestFixture>] 
type Day09Part1 () =

    [<Test>]
    member _.GetSingles() = CollectionAssert.AreEqual([|"D"; "D"; "D"; "D"|], Day09Part1.getSingles ("D 4"))

    [<Test>]
    member _.GetDeltas() = CollectionAssert.AreEqual([|(0, -1); (0, -1); (-1, 0); (0, 1); (1, 0)|], Day09Part1.getDeltas ([|"D 2"; "L 1"; "U 1"; "R 1"|]))

    [<Test>]
    member _.Move() = Assert.AreEqual((9, 7), Day09Part1.move((13, 2), (-4, 5)))

    [<Test>]
    member _.GetPathOfHead() = Assert.AreEqual([|(0, 0); (0, -1); (0, -2)|], Day09Part1.getPathOfHead([|"D 2"|]))
