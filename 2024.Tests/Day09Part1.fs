namespace _2024.Tests

open NUnit.Framework
open _2024

[<TestFixture>] 
type Day09Part1 () =

    [<Test>]
    member _.Example() = Assert.That(Day09Part1.run("2333133121414131402"), Is.EqualTo(1928))
