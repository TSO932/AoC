namespace AoC2021.Tests

open NUnit.Framework
open AoC2021

[<TestFixture>] 
type Day10Part1 () =

    [<Test>]
    member _.RemovePairedBrackets() = Assert.AreEqual((false, "AB{C[D]E<FG>HIJKLMNO}P"), Day10Part1.removePairedBrackets ("A()B{C[D]E<FG>H[]IJK{}LMN<>O}P"))

    [<Test>]
    member _.RemovePairedBracketsComplete() = Assert.AreEqual((true, "AB{C[D]E<FG>HIJKLMNO}P"), Day10Part1.removePairedBrackets ("AB{C[D]E<FG>HIJKLMNO}P"))

    [<Test>]
    member _.RemoveAllPairedBracketsComplete() = Assert.AreEqual("Hello!", Day10Part1.removeAllPairedBrackets ("Hell{{{([<<>>])}}}[]o!"))

    [<Test>]
    member _.IsCompleteTrue() = Assert.AreEqual(true, Day10Part1.isComplete ("Hello to Jason Issacs."))

    [<Test>]
    member _.IsCompleteFalse() = Assert.AreEqual(false, Day10Part1.isComplete ("Hell{{{([<<>>])}}}[]o!"))


    [<Test>]
    member _.Example01() = Assert.AreEqual(0, Day10Part1.scoreFirstIllegalCharacter ("[({(<(())[]>[[{[]{<()<>>"))
    [<Test>]
    member _.Example02() = Assert.AreEqual(0, Day10Part1.scoreFirstIllegalCharacter ("[(()[<>])]({[<{<<[]>>("))
    [<Test>]
    member _.Example03() = Assert.AreEqual(1197, Day10Part1.scoreFirstIllegalCharacter ("{([(<{}[<>[]}>{[]{[(<()>"))
    [<Test>]
    member _.Example04() = Assert.AreEqual(0, Day10Part1.scoreFirstIllegalCharacter ("(((({<>}<{<{<>}{[]{[]{}"))
    [<Test>]
    member _.Example05() = Assert.AreEqual(3, Day10Part1.scoreFirstIllegalCharacter ("[[<[([]))<([[{}[[()]]]"))
    [<Test>]
    member _.Example06() = Assert.AreEqual(57, Day10Part1.scoreFirstIllegalCharacter ("[{[{({}]{}}([{[{{{}}([]"))
    [<Test>]
    member _.Example07() = Assert.AreEqual(0, Day10Part1.scoreFirstIllegalCharacter ("{<[[]]>}<{[{[{[]{()[[[]"))
    [<Test>]
    member _.Example08() = Assert.AreEqual(3, Day10Part1.scoreFirstIllegalCharacter ("[<(<(<(<{}))><([]([]()"))
    [<Test>]
    member _.Example09() = Assert.AreEqual(25137, Day10Part1.scoreFirstIllegalCharacter ("<{([([[(<>()){}]>(<<{{"))
    [<Test>]
    member _.Example10() = Assert.AreEqual(0, Day10Part1.scoreFirstIllegalCharacter ("<{([{{}}[<[[[<>{}]]]>[]]"))

    [<Test>]
    member _.Example() = Assert.AreEqual(26397, Day10Part1.getScore (["[({(<(())[]>[[{[]{<()<>>";
                                                                             "[(()[<>])]({[<{<<[]>>(";
                                                                             "{([(<{}[<>[]}>{[]{[(<()>";
                                                                             "(((({<>}<{<{<>}{[]{[]{}";
                                                                             "[[<[([]))<([[{}[[()]]]";
                                                                             "[{[{({}]{}}([{[{{{}}([]";
                                                                             "{<[[]]>}<{[{[{[]{()[[[]";
                                                                             "[<(<(<(<{}))><([]([]()";
                                                                             "<{([([[(<>()){}]>(<<{{";
                                                                             "<{([{{}}[<[[[<>{}]]]>[]]"]))