module AoC2015.Tests2

open NUnit.Framework
open AoC2015


[<Test>]
let rule1Example1() = Assert.AreEqual(true, Day05Part2.isValidRule1 ("xyxy"))

[<Test>]
let rule1Example2() = Assert.AreEqual(true, Day05Part2.isValidRule1 ("aabcdefgaa"))

[<Test>]
let rule1Example3() = Assert.AreEqual(false, Day05Part2.isValidRule1 ("aaa"))

[<Test>]
let rule2Example1() = Assert.AreEqual(true, Day05Part2.isValidRule2 ("xyx"))

[<Test>]
let rule2Example2() = Assert.AreEqual(true, Day05Part2.isValidRule2 ("abcdefeghi"))

[<Test>]
let rule2Example3() = Assert.AreEqual(true, Day05Part2.isValidRule2 ("aaa"))

[<Test>]
let rule2NotValid() = Assert.AreEqual(false, Day05Part2.isValidRule2 ("aabb"))

[<Test>]
let example1() = Assert.AreEqual(true, Day05Part2.isValid ("qjhvhtzxzqqjkmpb"))

[<Test>]
let example2() = Assert.AreEqual(true, Day05Part2.isValid ("xxyxx"))

[<Test>]
let example3() = Assert.AreEqual(false, Day05Part2.isValid ("uurcxstgmygtbstg"))

[<Test>]
let example4() = Assert.AreEqual(false, Day05Part2.isValid ("ieodomkazucvgmuy"))
