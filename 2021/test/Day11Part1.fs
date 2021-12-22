namespace AoC2021.Tests

open NUnit.Framework
open AoC2021

[<TestFixture>] 
type Day11Part1 () =

    [<DefaultValue>] val mutable smallerExample : seq<string>
    [<DefaultValue>] val mutable largerExample  : seq<string>

    [<SetUp>]
    member this.SetUp() =
        this.smallerExample <- ["11111"; "19991"; "19191"; "19991"; "11111"]

        this.largerExample <- ["5483143223"; "2745854711"; "5264556173"; "6141336146"; "6357385478";
        "4167524645"; "2176841721"; "6882881134"; "4846848554"; "5283751526"]
        
    [<Test>]
    member _.Step1() =
        let octopuses = Day11Part1.Octopuses([|"123"; "678"; "900"|])
        octopuses.Step()
        Assert.AreEqual(1, octopuses.FlashCount)

    [<Test>]
    member _.Step3() =
        let octopuses = Day11Part1.Octopuses([|"123"; "678"; "090"|])
        octopuses.Step()
        Assert.AreEqual(3, octopuses.FlashCount)

    [<Test>]
    member _.DoubleBump() =
        let octopuses = Day11Part1.Octopuses([|"97"; "79"|])
        octopuses.Step()
        Assert.AreEqual(4, octopuses.FlashCount)

    [<Test>]
    member this.SmallExample() =
        let octopuses = Day11Part1.Octopuses(this.smallerExample)
        octopuses.Step()
        Assert.AreEqual(9, octopuses.FlashCount)

    [<Test>]
    member this.SmallExampleStep1() =
        let octopuses = Day11Part1.Octopuses(this.smallerExample)
        octopuses.Steps(1)
        Assert.AreEqual(9, octopuses.FlashCount)

    [<Test>]
    member this.LargeExampleStep001() =
        let octopuses = Day11Part1.Octopuses(this.largerExample)
        octopuses.Steps(1)
        Assert.AreEqual(0, octopuses.FlashCount)

    [<Test>]
    member this.LargeExampleStep002() =
       
        let octopuses = Day11Part1.Octopuses(this.largerExample)
        octopuses.Steps(2)
        Assert.AreEqual(35, octopuses.FlashCount)

    [<Test>]
    member this.LargeExampleStep003() =
        let octopuses = Day11Part1.Octopuses(this.largerExample)
        octopuses.Steps(3)
        Assert.AreEqual(35 + 45, octopuses.FlashCount)

    [<Test>]
    member this.LargeExampleStep003UsingStep2sOutput() =
        let octopuses = Day11Part1.Octopuses(["8807476555"; "5089087054"; "8597889608"; "8485769600"; "8700908800"; "6600088989";
        "6800005943"; "0000007456"; "9000000876"; "8700006848"])
        octopuses.Steps(1)
        Assert.AreEqual(45, octopuses.FlashCount)

    [<Test>]
    member this.LargeExampleStep004() =
        let octopuses = Day11Part1.Octopuses(this.largerExample)
        octopuses.Steps(4)
        Assert.AreEqual(35 + 45 + 16, octopuses.FlashCount)

    [<Test>]
    member this.LargeExampleStep004UsingStep3sOutput() =
        let octopuses = Day11Part1.Octopuses(["0050900866"; "8500800575"; "9900000039"; "9700000041"; "9935080063"; "7712300000";
        "7911250009"; "2211130000"; "0421125000"; "0021119000"])
        octopuses.Steps(1)
        Assert.AreEqual(16, octopuses.FlashCount)

    [<Test>]
    member this.LargeExampleStep005() =
        let octopuses = Day11Part1.Octopuses(this.largerExample)
        octopuses.Steps(5)
        Assert.AreEqual(35 + 45 + 16 + 8, octopuses.FlashCount)

    [<Test>]
    member this.LargeExampleStep005UsingStep4sOutput() =
        let octopuses = Day11Part1.Octopuses(["2263031977"; "0923031697"; "0032221150"; "0041111163"; "0076191174"; "0053411122";
        "0042361120"; "5532241122"; "1532247211"; "1132230211"])
        octopuses.Steps(1)
        Assert.AreEqual(8, octopuses.FlashCount)

    [<Test>]
    member this.LargeExampleStep006() =
        let octopuses = Day11Part1.Octopuses(this.largerExample)
        octopuses.Steps(6)
        Assert.AreEqual(35 + 45 + 16 + 8 + 1, octopuses.FlashCount)

    
    [<Test>]
    member this.LargeExampleStep007() =
        let octopuses = Day11Part1.Octopuses(this.largerExample)
        octopuses.Steps(7)
        Assert.AreEqual(35 + 45 + 16 + 8 + 1 + 7, octopuses.FlashCount)

    [<Test>]
    member this.LargeExampleStep100() =
        let octopuses = Day11Part1.Octopuses(this.largerExample)
        octopuses.Steps(100)
        Assert.AreEqual(1656, octopuses.FlashCount)

