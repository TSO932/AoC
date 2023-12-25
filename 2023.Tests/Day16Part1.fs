namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day16Part1 () =

    [<Test>]
    member _.example() = 
        let input = seq {@".|...\...."; @"|.-.\....."; ".....|-..."; "........|."; ".........."; @".........\"; @"..../.\\.."; ".-.-/..|.."; @".|....-|.\"; "..//.|...."}
        Assert.AreEqual(46, Day16Part1.countTiles(input))