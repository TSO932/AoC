namespace _2024.Tests

open NUnit.Framework
open _2024

[<TestFixture>]
type Day03Part2 () =

    [<Test>]
    member _.getDos() =
        let input = "xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))"
        Assert.That(Day03Part2.getDos input, Is.EqualTo([(59, true)]))
    
    [<Test>]
    member _.getDonts() =
        let input = "xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))"
        Assert.That(Day03Part2.getDonts input, Is.EqualTo([(20, false)]))

    [<Test>]
    member _.getDosAndDonts() =
        let input = "xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))"
        Assert.That(Day03Part2.getDosAndDonts input, Is.EqualTo([(20, false); (59, true)]))

    [<Test>]
    member _.isIndexPositionEnabled00() =
        let input = [(20, false); (59, true)]
        Assert.That(Day03Part2.isIndexPositionEnabled (input, 0), Is.EqualTo(true))

    [<Test>]
    member _.isIndexPositionEnabled30() =
        let input = [(20, false); (59, true)]
        Assert.That(Day03Part2.isIndexPositionEnabled (input, 30), Is.EqualTo(false))

    [<Test>]
    member _.isIndexPositionEnabled90() =
        let input = [(20, false); (59, true)]
        Assert.That(Day03Part2.isIndexPositionEnabled (input, 90), Is.EqualTo(true))

    [<Test>]
    member _.getEnabledInstructions() =
        let input = "xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))"
        let expected = "xmul(2,4)&mul[3,7]!^do()?mul(8,5))"
        Assert.That(Day03Part2.getEnabledInstructions input, Is.EqualTo(expected))      

    [<Test>]
    member _.getSum() =
        let input = "xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))"
        Assert.That(Day03Part2.getSum input, Is.EqualTo(48))

