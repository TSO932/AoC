namespace AoC2015.Tests

open NUnit.Framework

[<TestFixture>] 
type Day15Part2 () =

    [<Test>]
    member _.Example() =

        let getScoreTest(a:int) = 
            let b = 100 - a
            (max 0 ((a * -1) + (b * 2))) * (max 0 ((a * -2) + (b * 3))) * (max 0 ((a * 6) + (b * -2))) * (max 0 ((a * 3) + (b * -1)))

        let getTotalScoreTest() = 

            let is500Calories(a:int) =
                let b = 100 - a
                (8 * a) + (3 * b) = 500

            let scores = 
                [for a in 0 .. 100 -> is500Calories(a), getScoreTest(a) ]

            scores |> List.filter fst |> List.map snd |> List.max
    
        Assert.AreEqual(57600000, getTotalScoreTest())

