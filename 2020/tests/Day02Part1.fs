namespace AoC2020.Tests

open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day02Part1 () =

    [<Test>]
    member this.Example1() = Assert.AreEqual(1, Day02Part1.checkPasswords ([|"1-3 a: abcde"|]))

    [<Test>]
    member this.Example2() = Assert.AreEqual(0, Day02Part1.checkPasswords ([|"1-3 b: cdefg"|]))

    [<Test>]
    member this.Example3() = Assert.AreEqual(1, Day02Part1.checkPasswords ([|"2-9 c: ccccccccc"|]))

    [<Test>]
    member this.Examples() = Assert.AreEqual(2, Day02Part1.checkPasswords ([|"1-3 a: abcde"; "1-3 b: cdefg"; "2-9 c: ccccccccc"|]))
