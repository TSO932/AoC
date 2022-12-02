namespace AoC2022.Tests

open NUnit.Framework
open AoC2022

[<TestFixture>] 
type Day02Part2 () =

    [<Test>]
    member _.GetGetChoiceAndOutcomeExample1() = Assert.AreEqual( (Day02Part2.Choice.Rock, Day02Part2.Outcome.Draw), Day02Part2.GetChoiceAndOutcome "A Y" )

    [<Test>]
    member _.GetGetChoiceAndOutcomeExample2() = Assert.AreEqual( (Day02Part2.Choice.Paper, Day02Part2.Outcome.Lose), Day02Part2.GetChoiceAndOutcome "B X" )

    [<Test>]
    member _.GetGetChoiceAndOutcomeExample3() = Assert.AreEqual( (Day02Part2.Choice.Scissors, Day02Part2.Outcome.Win), Day02Part2.GetChoiceAndOutcome "C Z" )

    [<Test>]
    member _.GetScoreExample1() = Assert.AreEqual(4 , Day02Part2.GetScore "A Y" )

    [<Test>]
    member _.GetScoreExample2() = Assert.AreEqual(1 , Day02Part2.GetScore "B X" )

    [<Test>]
    member _.GetScoreExample3() = Assert.AreEqual(7 , Day02Part2.GetScore  "C Z" )

    [<Test>]
    member _.GetTotal() = Assert.AreEqual(12 , Day02Part2.GetTotal  [|"A Y"; "B X"; "C Z" |])