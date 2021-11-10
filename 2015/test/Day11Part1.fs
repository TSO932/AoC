namespace AoC2015.Tests

open System
open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day11Part1 () =

    [<Test>]
    member _.IncrementPasswordSimple() = Assert.AreEqual("aab", Day11Part1.incrementPassword ("aaa"))

    [<Test>]
    member _.IncrementPasswordEmpty() = Assert.AreEqual("", Day11Part1.incrementPassword (""))

    [<Test>]
    member _.IncrementPasswordFlips() = Assert.AreEqual("aabaaa", Day11Part1.incrementPassword ("aaazzz"))

    [<Test>]
    member _.IncrementPasswordMax() = Assert.AreEqual("aa", Day11Part1.incrementPassword ("zz"))

    [<Test>]
    member _.generatePassword() = 
        let dummyValidationRule(password:string) =
            not (password = "ab")

        Assert.AreEqual("ac", Day11Part1.generatePassword ("aa", dummyValidationRule))

    [<Test>]
    member _.RuleTwoValid() = Assert.AreEqual(true, Day11Part1.ruleTwo ("aaaaa"))

    [<Test>]
    member _.RuleTwoOneI() = Assert.AreEqual(false, Day11Part1.ruleTwo ("aaiaa"))

    [<Test>]
    member _.RuleTwoTwoOs() = Assert.AreEqual(false, Day11Part1.ruleTwo ("oaaao"))
    
    [<Test>]
    member _.RuleTwoSingleL() = Assert.AreEqual(false, Day11Part1.ruleTwo ("l"))

    [<Test>]
    member _.RuleTwoEmptyIsValid() = Assert.AreEqual(true, Day11Part1.ruleTwo (""))

    [<Test>]
    member _.RuleThreeNoRepeatsInvalid() = Assert.AreEqual(false, Day11Part1.ruleThree ("abcd"))
    
    [<Test>]
    member _.RuleThreeEmptyInvalid() = Assert.AreEqual(false, Day11Part1.ruleThree (""))

    [<Test>]
    member _.RuleThreeFourQsIsValid() = Assert.AreEqual(true, Day11Part1.ruleThree ("qqqq"))

    [<Test>]
    member _.RuleThreeThreeQsIsInvalid() = Assert.AreEqual(false, Day11Part1.ruleThree ("qqq"))

    [<Test>]
    member _.RuleThreeTwoQsIsInvalid() = Assert.AreEqual(false, Day11Part1.ruleThree ("qq"))

    [<Test>]
    member _.RuleThreeTwoQsAndTwoRsIsValid() = Assert.AreEqual(true, Day11Part1.ruleThree ("qqrr"))

    [<Test>]
    member _.RuleThreeTwoQsPaddingAtTheFrontIsValid() = Assert.AreEqual(true, Day11Part1.ruleThree ("aqqqq"))

    [<Test>]
    member _.RuleThreeTwoQsPaddingAtInTheMiddleIsValid() = Assert.AreEqual(true, Day11Part1.ruleThree ("qqaqq"))

    [<Test>]
    member _.RuleThreeTwoQsPaddingAtAtTheEndIsValid() = Assert.AreEqual(true, Day11Part1.ruleThree ("qqqqa"))

    [<Test>]
    member _.RuleThreeTwoQsPaddingIsValid() = Assert.AreEqual(true, Day11Part1.ruleThree ("abcqqdeqqfg"))

    [<Test>]
    member _.isStraightInvalidFalling() = Assert.AreEqual(false, Day11Part1.isStraight ([|'c'; 'b'; 'a'|]))

    [<Test>]
    member _.isStraightInvalidLast() = Assert.AreEqual(false, Day11Part1.isStraight ([|'a'; 'b'; 'd'|]))

    [<Test>]
    member _.isStraightInvalidFirst() = Assert.AreEqual(false, Day11Part1.isStraight ([|'a'; 'c'; 'd'|]))

    [<Test>]
    member _.isStraightValidExample1() = Assert.AreEqual(true, Day11Part1.isStraight ([|'a'; 'b'; 'c'|]))

    [<Test>]
    member _.isStraightValidExample2() = Assert.AreEqual(true, Day11Part1.isStraight ([|'b'; 'c'; 'd'|]))

    [<Test>]
    member _.isStraightValidExample3() = Assert.AreEqual(true, Day11Part1.isStraight ([|'c'; 'd'; 'e'|]))

    [<Test>]
    member _.isStraightValidExample4() = Assert.AreEqual(true, Day11Part1.isStraight ([|'x'; 'y'; 'z'|]))

    [<Test>]
    member _.isStraightTooShort() = Assert.Throws<IndexOutOfRangeException> (fun() -> Assert.AreEqual(false, Day11Part1.isStraight ([||])) |> ignore) |> ignore

    [<Test>]
    member _.RuleOneEmptyIsInvalid() = Assert.AreEqual(false, Day11Part1.ruleOne (""))

    [<Test>]
    member _.RuleOneInvalid() = Assert.AreEqual(false, Day11Part1.ruleOne ("the quick brown fox jumped over the lazy dog. aabbccddeeffgg!"))
    
    [<Test>]
    member _.RuleOneValid() = Assert.AreEqual(true, Day11Part1.ruleOne ("qwertyjkluiop"))

    [<Test>]
    member _.RulesExample1() = Assert.AreEqual(false, Day11Part1.rules ("hijklmmn"))

    [<Test>]
    member _.RulesExample2() = Assert.AreEqual(false, Day11Part1.rules ("abbceffg"))

    [<Test>]
    member _.RulesExample3() = Assert.AreEqual(false, Day11Part1.rules ("abbcegjk"))

    [<Test>]
    member _.RulesValid() = Assert.AreEqual(true, Day11Part1.ruleOne ("aabcdeff"))

    [<Test>]
    member _.GetNextPasswordExample1() = Assert.AreEqual("abcdffaa", Day11Part1.getNextPassword ("abcdefgh"))

    [<Test>]
    [<Ignore("Too long. Don't run.")>]
    member _.GetNextPasswordExample2() = Assert.AreEqual("ghjaabcc", Day11Part1.getNextPassword ("ghijklmn"))

