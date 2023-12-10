namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day09Part1 () =

    [<Test>]
    member _.Parse() = CollectionAssert.AreEqual([|0; 3; 6; 9; 12; 15|], Day09Part1.parse "0 3 6 9 12 15")

    [<Test>]
    member _.GetDifferences() = CollectionAssert.AreEqual([|2; 3; 4; 5; 6|], Day09Part1.getDifferences [|1; 3; 6; 10; 15; 21|])

    [<Test>]
    member _.GetDifferencesEmpty() = CollectionAssert.AreEqual(Seq.empty, Day09Part1.getDifferences Seq.empty)

    [<Test>]
    member _.GetSequences() = CollectionAssert.AreEqual([|0; 1; 5; 15|], Day09Part1.getSequences [|1; 3; 6; 10; 15|])

    [<Test>]
    member _.GetPrediction() = Assert.AreEqual(21, Day09Part1.getPrediction [|0; 1; 5; 15|])

    [<Test>]
    member _.GetPredictionEmpty() = Assert.AreEqual(0, Day09Part1.getPrediction Seq.empty)

    [<Test>]
    member _.GetSequencesNegative() = CollectionAssert.AreEqual([|0; -3; -19; -66; -172|], Day09Part1.getSequences [|-1; -2; -10; -28; -59; -106; -172|])

    [<Test>]
    member _.GetPredictionNegative() = Assert.AreEqual(-260, Day09Part1.getPrediction [|0; -3; -19; -66; -172|])

    [<Test>]
    member _.GetSum() = Assert.AreEqual(114, Day09Part1.getSum [|"0 3 6 9 12 15"; "1 3 6 10 15 21"; "10 13 16 21 30 45"|])

    [<Test>]
    member _.GetSequences0110() = Assert.AreEqual([|0; -1; -1; 0|], Day09Part1.getSequences [|0; 1; 1; 0|])


