namespace _2024.Tests

open NUnit.Framework
open _2024

[<TestFixture>] 
type Day11Part1 () =

    [<Test>]
    member _.CountNumberOfDigits0() = Assert.That(Day11Part1.countNumberOfDigits(0UL), Is.EqualTo(1))

    [<Test>]
    member _.CountNumberOfDigits1() = Assert.That(Day11Part1.countNumberOfDigits(1UL), Is.EqualTo(1))

    [<Test>]
    member _.CountNumberOfDigits9() = Assert.That(Day11Part1.countNumberOfDigits(9UL), Is.EqualTo(1))
    
    [<Test>]
    member _.CountNumberOfDigits10() = Assert.That(Day11Part1.countNumberOfDigits(10UL), Is.EqualTo(2))

    [<Test>]
    member _.CountNumberOfDigits11() = Assert.That(Day11Part1.countNumberOfDigits(11UL), Is.EqualTo(2))

    [<Test>]
    member _.CountNumberOfDigitsBig() = Assert.That(Day11Part1.countNumberOfDigits(123456789UL), Is.EqualTo(9))

    [<Test>]
    member _.IsEvenTrue() = Assert.That(Day11Part1.isEven(2), Is.EqualTo(true))

    [<Test>]
    member _.IsEvenFalse() = Assert.That(Day11Part1.isEven(1), Is.EqualTo(false))

    [<Test>]
    member _.IsEvenZero() = Assert.That(Day11Part1.isEven(1), Is.EqualTo(false))

    [<Test>]
    member _.Split() = Assert.That(Day11Part1.split(123456UL, 6), Is.EqualTo([|123UL; 456UL|]))

    [<Test>]
    member _.Blink0() = Assert.That(Day11Part1.blink(0UL), Is.EqualTo(([|1UL|])))

    [<Test>]
    member _.Blink1() = Assert.That(Day11Part1.blink(1UL), Is.EqualTo(([|2024UL|])))

    [<Test>]
    member _.Blink10() = Assert.That(Day11Part1.blink(10UL), Is.EqualTo(([|1UL; 0UL|])))

    [<Test>]
    member _.Blink99() = Assert.That(Day11Part1.blink(99UL), Is.EqualTo(([|9UL; 9UL|])))

    [<Test>]
    member _.Blink999() = Assert.That(Day11Part1.blink(999UL), Is.EqualTo(([|2021976UL|])))

    [<Test>]
    member _.MemoiseFirst() =
        let memoryBank = Day11Part1.blinkMem 
        Assert.That(memoryBank(999UL), Is.EqualTo(([|2021976UL|])))

    [<Test>]
    member _.MemoiseSubsequent() =
        let memoryBank = Day11Part1.blinkMem
        memoryBank(999UL) |> ignore
        Assert.That(memoryBank(999UL), Is.EqualTo(([|2021976UL|])))

    [<Test>]
    member _.ParseLine() = Assert.That(Day11Part1.parseLine("125 17"), Is.EqualTo(([|(125UL, 1UL); (17UL, 1UL)|])))

    [<Test>]
    member _.BlinkMult() =
        let mem = Day11Part1.blinkMult 
        Assert.That(mem(10UL, 7UL), Is.EqualTo(([|(1L, 7UL); (0L, 7UL)|])))

    [<Test>]
    member _.BlinkLine() = Assert.That(Day11Part1.blinkLine([|(125UL, 1UL); (17UL, 1UL)|]), Is.EqualTo(([|(253000UL, 1UL); (1UL, 1UL); (7UL, 1UL)|])))

    [<Test>]
    member _.BlinkLine2() = Assert.That(Day11Part1.blinkLine([|(22UL, 3UL)|]), Is.EqualTo(([|(2UL, 6UL)|])))

    [<Test>]
    member _.BlinkRepeat() =
        let expected = [|(2097446912UL, 1UL); (14168UL, 1UL); (4048UL, 1UL); (2UL, 4UL); (0UL, 2UL); (4UL, 1UL); (40UL, 2UL); (48UL, 2UL); (2024UL, 1UL); (80UL, 1UL); (96UL, 1UL); (8UL, 1UL); (6UL, 2UL); (7UL, 1UL); (3UL, 1UL)|] 
        Assert.That(Day11Part1.blinkRepeat([|(125UL, 1UL); (17UL, 1UL)|], 6), Is.EqualTo(expected))

    [<Test>]
    member _.CountStones() =
        let input = [|(2097446912UL, 1UL); (14168UL, 1UL); (4048UL, 1UL); (2UL, 4UL); (0UL, 2UL); (4UL, 1UL); (40UL, 2UL); (48UL, 2UL); (2024UL, 1UL); (80UL, 1UL); (96UL, 1UL); (8UL, 1UL); (6UL, 2UL); (7UL, 1UL); (3UL, 1UL)|] 
        Assert.That(Day11Part1.countStones(input), Is.EqualTo(22UL))

    [<Test>]
    member _.RunN() = Assert.That(Day11Part1.runN("125 17", 25), Is.EqualTo(55312UL))

    [<Test>]
    member _.Run() = Assert.That(Day11Part1.run("125 17"), Is.EqualTo(55312UL))