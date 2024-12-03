namespace _2024.Tests

open NUnit.Framework
open _2024

[<TestFixture>]
type Day03Part1 () =

    [<Test>]
    member _.getMultiple() =
        Assert.That(Day03Part1.getMultiple "mul(44,46)", Is.EqualTo(2024))

    [<Test>]
    member _.getInstructions() =
        let input = "xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))"
        let expected = ["mul(2,4)"; "mul(5,5)"; "mul(11,8)"; "mul(8,5)"]
        Assert.That(Day03Part1.getInstructions input, Is.EqualTo(expected))

    [<Test>]
    member _.getSum() =
        let input = "xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))"
        Assert.That(Day03Part1.getSum input, Is.EqualTo(161))
