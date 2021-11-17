namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day17Part1 () =

    [<Test>]
    member _.IsExtactFitFalse() = Assert.AreEqual(false, Day17Part1.isExtactFit ([|15; 10; 5|], 25))

    [<Test>]
    member _.IsExtactFitTrue() = Assert.AreEqual(true, Day17Part1.isExtactFit ([|15; 5; 5|], 25))

    [<Test>]
    member _.CountCombinations() = Assert.AreEqual(4, Day17Part1.countCombinations ([|20; 15; 10; 5; 5|], 25))