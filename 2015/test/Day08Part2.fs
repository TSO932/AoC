namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day08Part2 () =

    [<Test>]
    member _.Example1() = Assert.AreEqual(6 - 2, Day08Part2.countCharacters ([|"\"\""|]))

    [<Test>]
    member _.Example2() = Assert.AreEqual(9 - 5, Day08Part2.countCharacters ([|"\"abc\""|]))
    
    [<Test>]
    member _.Example3() = Assert.AreEqual(16 - 10, Day08Part2.countCharacters ([|"\"aaa\\\"aaa\""|]))

    [<Test>]
    member _.Example4() = Assert.AreEqual(11 - 6, Day08Part2.countCharacters ([|"\"\\x27\""|]))

    [<Test>]
    member _.WholeExample() = Assert.AreEqual(19, Day08Part2.countCharacters ([|"\"\"" ; "\"abc\"" ; "\"aaa\\\"aaa\"" ; "\"\\x27\""|]))
    