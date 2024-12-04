namespace _2024.Tests

open NUnit.Framework
open _2024

[<TestFixture>]
type Day03Part2 () =
 
    [<Test>]
    member _.getEnabledInstructionFalse() =
        Assert.That(Day03Part2.getEnabledInstruction(("hat", false),"ham"), Is.EqualTo(("mul(0,0)", false)))

    [<Test>]
    member _.getEnabledInstructionTrue() =
        Assert.That(Day03Part2.getEnabledInstruction(("hat", true),"ham"), Is.EqualTo(("ham", true)))

    [<Test>]
    member _.getEnabledInstructionDo() =
        Assert.That(Day03Part2.getEnabledInstruction(("hat", true),"do()"), Is.EqualTo(("mul(0,0)", true)))

    [<Test>]
    member _.getEnabledInstructionDont() =
        Assert.That(Day03Part2.getEnabledInstruction(("hat", true),"don't()"), Is.EqualTo(("mul(0,0)", false)))

    [<Test>]
    member _.getSum() =
        let input = "xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))"
        Assert.That(Day03Part2.getSum input, Is.EqualTo(48))

