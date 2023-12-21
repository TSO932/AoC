namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day16Part2 () =

    [<Test>]
    member _.example() = 
        let input = seq {@".|...\...."; @"|.-.\....."; ".....|-..."; "........|."; ".........."; @".........\"; @"..../.\\.."; ".-.-/..|.."; @".|....-|.\"; "..//.|...."}
        Assert.AreEqual(51, Day16Part2.countTiles(input))