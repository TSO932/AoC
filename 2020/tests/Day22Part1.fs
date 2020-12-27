namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day22Part1 () =


    [<Test>]
    member this.ReadCards() = 
        let actual = Day22Part1.readCards (seq {"a"; "b"; "00"; "88"; "77"; "qq"; ""; "ee"; "999"; "0"; "!"; "4"; "42"; "99"})
        printfn "%A" actual
        Assert.AreEqual([|[88; 77; 999]; [4; 42; 99]|], actual)

    [<Test>]
    member this.PlayRoundLose() = 
        let actual = Day22Part1.playRound ([|[1; 2; 3]; [4; 5; 6]|])
        printfn "%A" actual
        Assert.AreEqual([|[2; 3]; [5; 6; 4; 1]|], actual)

    [<Test>]
    member this.PlayRoundWin() = 
        let actual = Day22Part1.playRound ([|[9; 2; 3]; [4; 5; 6]|])
        printfn "%A" actual
        Assert.AreEqual([|[2; 3; 9; 4]; [5; 6]|], actual)

    //No rule for a draw is specified.

    [<Test>]
    member this.ScoreDeck() = 
        Assert.AreEqual(370, Day22Part1.scoreDeck ([100; 20; 30]))

    [<Test>]
    member this.PlayCombat() = Assert.AreEqual(306, Day22Part1.playCombat (File.ReadAllLines("../../../data/Day22/test1.txt")))