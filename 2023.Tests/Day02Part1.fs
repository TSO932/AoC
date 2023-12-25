namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day02Part1 () =

    [<Test>]
    member _.Example() = Assert.AreEqual(8, Day02Part1.gameSum [|"Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green"; "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue"; "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red"; "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red"; "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green"|])

    [<Test>]
    member _.GetCubeCount() = Assert.AreEqual(("green", 13), Day02Part1.getCubeCount "13 green")

    [<Test>]
    member _.GetCubeCountLeadingSpace() = Assert.AreEqual(("green", 13), Day02Part1.getCubeCount " 13 green")

    [<Test>]
    member _.GetGameId() = Assert.AreEqual(123, Day02Part1.getGameId "Game 123")

    [<Test>]
    member _.CheckValidityGreenPass() = Assert.AreEqual(true, Day02Part1.checkValidity ("green", 3))

    [<Test>]
    member _.CheckValidityRedFail() = Assert.AreEqual(false, Day02Part1.checkValidity ("red", 99))