namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day18Part1 () =

    [<Test>]
    member _.LightCount() = Assert.AreEqual(2, Day18Part1.lightCount (array2D [[false;true];[true;false]]))
   
    [<Test>]
    member _.ParseLights() = CollectionAssert.AreEqual(array2D [[false;true];[false;true]], Day18Part1.parseLights([|" #"; " #"|]))

    [<Test>]
    member _.On0TurnsOff() = CollectionAssert.AreEqual(array2D [[false;false];[false;false]], Day18Part1.switchLights(array2D [[true;false];[false;false]]))

    [<Test>]
    member _.On1TurnsOff() = CollectionAssert.AreEqual(array2D [[false;false];[false;false]], Day18Part1.switchLights(array2D [[true;true];[false;false]]))

    [<Test>]
    member _.OnOrOff2StaysOn() = CollectionAssert.AreEqual(array2D [[true;true];[true;true]], Day18Part1.switchLights(array2D [[true;true];[true;false]]))

    [<Test>]
    member _.ExamplePattern() =
        let initialConfiguration = Day18Part1.parseLights([|".#.#.#"; "...##."; "#....#"; "..#..."; "#.#..#"; "####.."|])
        let finalConfiguration   = Day18Part1.parseLights([|"......"; "......"; "..##.."; "..##.."; "......"; "......"|])

        CollectionAssert.AreEqual(finalConfiguration, Day18Part1.animate(initialConfiguration, 4))

    [<Test>]
    member _.ExampleCount() = Assert.AreEqual(4, Day18Part1.countOnLights([|".#.#.#"; "...##."; "#....#"; "..#..."; "#.#..#"; "####.."|], 4))
