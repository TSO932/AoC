namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day05Part2 () =

    [<Test>]
    member _.GetSeeds() =
        let seeds = Day05Part2.getSeeds [|(79L, 14L); (55L, 13L)|]
        Assert.AreEqual(27L, Seq.length seeds, "length")


    [<Test>]
    member _.GetTransitionPoints() =
        let input = [|[|50L; 98L; 2L|]; [|52L; 50L; 48L|]|]
        CollectionAssert.AreEqual([|50L; 98L; 100L|], Day05Part3.getTransitionPoints(input))
    
    [<Test>]
    member _.GetTransitionPoints2() =
        let input = [|[|0L; 15L; 37L|]; [|37L; 52L; 2L|]; [|39L; 0L; 15L|]|]
        CollectionAssert.AreEqual([|0L; 15L; 52L; 54L|], Day05Part3.getTransitionPoints(input))

    [<Test>]
    member _.BackOneLevel() =
        let input1 = [|0L; 15L; 52L; 54L|]
        let input2 = [|[|50L; 98L; 2L|]; [|52L; 50L; 48L|]|]
        let expected = [|0L; 15L; 50L; 52L; 98L; 100L|]
        CollectionAssert.AreEqual(expected, Day05Part3.backOneLevel(input1, input2))

    [<Test>]
    member _.BackAllLevels() =
        let seedToSoil = seq {"50 98 2"; "52 50 48"}
        let soilToFertilizer = seq {"0 15 37"; "37 52 2"; "39 0 15"}
        let fertilizerToWater = seq {"49 53 8"; "0 11 42"; "42 0 7"; "57 7 4"}
        
        let mapaHortus = seq {seedToSoil; soilToFertilizer; fertilizerToWater}

        let expected = [|0L; 14L; 15L; 22L; 26L; 50L; 52L; 59L; 98L; 100L|]

        CollectionAssert.AreEqual(expected, Day05Part3.backAllLevels(mapaHortus))
