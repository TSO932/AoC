namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day05Part1 () =

    [<Test>]
    member _.Rule1Example1() = Assert.AreEqual(true, Day05Part1.isValidRule1 ("aei"))

    [<Test>]
    member _.Rule1Example2() = Assert.AreEqual(true, Day05Part1.isValidRule1 ("xazegov"))

    [<Test>]
    member _.Rule1Example3() = Assert.AreEqual(true, Day05Part1.isValidRule1 ("aeiouaeiouaeiou"))

    [<Test>]
    member _.Rule1NotValid() = Assert.AreEqual(false, Day05Part1.isValidRule1 ("rhythms"))

    [<Test>]
    member _.Rule2Example1() = Assert.AreEqual(true, Day05Part1.isValidRule2 ("xx"))

    [<Test>]
    member _.Rule2Example2() = Assert.AreEqual(true, Day05Part1.isValidRule2 ("dd"))

    [<Test>]
    member _.Rule2Example3() = Assert.AreEqual(true, Day05Part1.isValidRule2 ("aabbccdd"))

    [<Test>]
    member _.Rule2NotValid() = Assert.AreEqual(false, Day05Part1.isValidRule2 ("abcdefgfgfgfgfgf"))

    [<Test>]
    member _.Rule3Example1() = Assert.AreEqual(false, Day05Part1.isValidRule3 ("ab"))

    [<Test>]
    member _.Rule3Example2() = Assert.AreEqual(false, Day05Part1.isValidRule3 ("ccdd"))

    [<Test>]
    member _.Rule3Example3() = Assert.AreEqual(false, Day05Part1.isValidRule3 ("pq"))
    
    [<Test>]
    member _.Rule3Example4() = Assert.AreEqual(false, Day05Part1.isValidRule3 ("xy"))

    [<Test>]
    member _.Rule3Valid() = Assert.AreEqual(true, Day05Part1.isValidRule3 ("acpxbdqy"))

    [<Test>]
    member _.Example1() = Assert.AreEqual(true, Day05Part1.isValid ("ugknbfddgicrmopn"))

    [<Test>]
    member _.Example2() = Assert.AreEqual(true, Day05Part1.isValid ("aaa"))

    [<Test>]
    member _.Example3() = Assert.AreEqual(false, Day05Part1.isValid ("jchzalrnumimnmhp"))

    [<Test>]
    member _.Example4() = Assert.AreEqual(false, Day05Part1.isValid ("haegwjzuvuyypxyu"))

    [<Test>]
    member _.Example5() = Assert.AreEqual(false, Day05Part1.isValid ("dvszwmarrgswjxmb"))

    [<Test>]
    member _.CountNiceStrings() = Assert.AreEqual(2, Day05Part1.countNiceStrings([|"ugknbfddgicrmopn"; "a"; "aaa"; "aa"; "x"|]))