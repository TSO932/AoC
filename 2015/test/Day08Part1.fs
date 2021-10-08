namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day08Part1 () =

    [<Test>]
    member _.Example1() = Assert.AreEqual(2, Day08Part1.countNonLiterals ("\"\""))

    [<Test>]
    member _.Example2() = Assert.AreEqual(2, Day08Part1.countNonLiterals ("\"abc\""))
    
    [<Test>]
    member _.Example3() = Assert.AreEqual(3, Day08Part1.countNonLiterals ("\"aaa\\\"aaa\""))

    [<Test>]
    member _.Example4() = Assert.AreEqual(5, Day08Part1.countNonLiterals ("\"\\x27\""))

    [<Test>]
    member _.OneBackslash() = Assert.AreEqual(2, Day08Part1.countNonLiterals ("\"\\\""))

    [<Test>]
    member _.TwoBackslashes() = Assert.AreEqual(3, Day08Part1.countNonLiterals ("\"\\\\\""))

    [<Test>]
    member _.ThreeBackslashes() = Assert.AreEqual(3, Day08Part1.countNonLiterals ("\"\\\\\\\""))

    [<Test>]
    member _.FourBackslashes() = Assert.AreEqual(4, Day08Part1.countNonLiterals ("\"\\\\\\\\\""))

    [<Test>]
    member _.WholeExample() = Assert.AreEqual(12, Day08Part1.countCharacters ([|"\"\"" ; "\"abc\"" ; "\"aaa\\\"aaa\"" ; "\"\\x27\""|]))
    