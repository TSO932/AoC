namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day18Part2 () =

    [<Test>]
    member _.ExamplePattern() =
        let initialConfiguration = Day18Part1.parseLights([|"##.#.#"; "...##."; "#....#"; "..#..."; "#.#..#"; "####.#"|])
        let finalConfiguration   = Day18Part1.parseLights([|"##.###"; ".##..#"; ".##..."; ".##..."; "#.#..."; "##...#"|])

        CollectionAssert.AreEqual(finalConfiguration, Day18Part2.animate(initialConfiguration, 5))

    [<Test>]
    member _.ExampleCount() = Assert.AreEqual(17, Day18Part2.countOnLights([|"##.#.#"; "...##."; "#....#"; "..#..."; "#.#..#"; "####.#"|], 5))
