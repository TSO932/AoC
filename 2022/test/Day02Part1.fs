namespace AoC2022.Tests

open NUnit.Framework
open AoC2022

[<TestFixture>] 
type Day02Part1 () =

    [<Test>]
    member _.GetChoicesExample1() = Assert.AreEqual( (Day02Part1.Choice.Rock, Day02Part1.Choice.Paper), Day02Part1.GetChoices "A Y" )

    [<Test>]
    member _.GetChoicesExample2() = Assert.AreEqual( (Day02Part1.Choice.Paper, Day02Part1.Choice.Rock), Day02Part1.GetChoices "B X" )

    [<Test>]
    member _.GetChoicesExample3() = Assert.AreEqual( (Day02Part1.Choice.Scissors, Day02Part1.Choice.Scissors), Day02Part1.GetChoices "C Z" )

    [<Test>]
    member _.GetScoreForShapeSelectedExample1() = Assert.AreEqual(2 , Day02Part1.GetScoreForShapeSelected (Day02Part1.Choice.Rock, Day02Part1.Choice.Paper) )

    [<Test>]
    member _.GetScoreForShapeSelectedExample2() = Assert.AreEqual(1 , Day02Part1.GetScoreForShapeSelected (Day02Part1.Choice.Paper, Day02Part1.Choice.Rock) )

    [<Test>]
    member _.GetScoreForShapeSelectedExample3() = Assert.AreEqual(3 , Day02Part1.GetScoreForShapeSelected (Day02Part1.Choice.Scissors, Day02Part1.Choice.Scissors) )
    
    [<Test>]
    member _.GetScoreForOutcomeExample1() = Assert.AreEqual(6 , Day02Part1.GetScoreForOutcome (Day02Part1.Choice.Rock, Day02Part1.Choice.Paper) )

    [<Test>]
    member _.GetScoreForOutcomeExample2() = Assert.AreEqual(0 , Day02Part1.GetScoreForOutcome (Day02Part1.Choice.Paper, Day02Part1.Choice.Rock) )

    [<Test>]
    member _.GetScoreForOutcomeExample3() = Assert.AreEqual(3 , Day02Part1.GetScoreForOutcome (Day02Part1.Choice.Scissors, Day02Part1.Choice.Scissors) )
        
    [<Test>]
    member _.GetScoreExample1() = Assert.AreEqual(8 , Day02Part1.GetScore "A Y" )

    [<Test>]
    member _.GetScoreExample2() = Assert.AreEqual(1 , Day02Part1.GetScore "B X" )

    [<Test>]
    member _.GetScoreExample3() = Assert.AreEqual(6 , Day02Part1.GetScore  "C Z" )

    [<Test>]
    member _.GetTotal() = Assert.AreEqual(15 , Day02Part1.GetTotal  [|"A Y"; "B X"; "C Z" |])