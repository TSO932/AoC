namespace AoC2015.Tests

open NUnit.Framework

[<TestFixture>] 
type Day15Part1 () =

    [<Test>]
    member _.Example() = 

        let getScoreTest(a:int) = 
            let b = 100 - a
            (max 0 ((a * -1) + (b * 2))) * (max 0 ((a * -2) + (b * 3))) * (max 0 ((a * 6) + (b * -2))) * (max 0 ((a * 3) + (b * -1)))

        let getTotalScoreTest() = 

            let scores =
                [for a in 0 .. 100 -> getScoreTest(a) ]

            List.max scores
    
        Assert.AreEqual(62842880, getTotalScoreTest())
        
