namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day17Part2 () =

    [<Test>]
    member _.IsExtactFitFalse() = Assert.AreEqual((false, 3), Day17Part2.isExtactFit ([|15; 10; 5|], 25))

    [<Test>]
    member _.IsExtactFitTrue() = Assert.AreEqual((true, 3), Day17Part2.isExtactFit ([|15; 5; 5|], 25))

    [<Test>]
    member _.CountCombinations() = Assert.AreEqual(3, Day17Part2.countCombinations ([|20; 15; 10; 5; 5|], 25))