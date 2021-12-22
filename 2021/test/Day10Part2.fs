namespace AoC2021.Tests

open NUnit.Framework
open AoC2021

[<TestFixture>] 
type Day10Part2 () =

    [<Test>]
    member _.Example01() = Assert.AreEqual(288957, Day10Part2.autoCompleteScore ("[({(<(())[]>[[{[]{<()<>>"))
    [<Test>]
    member _.Example02() = Assert.AreEqual(5566, Day10Part2.autoCompleteScore ("[(()[<>])]({[<{<<[]>>("))
    [<Test>]
    member _.Example04() = Assert.AreEqual(1480781, Day10Part2.autoCompleteScore ("(((({<>}<{<{<>}{[]{[]{}"))
    [<Test>]
    member _.Example07() = Assert.AreEqual(995444, Day10Part2.autoCompleteScore ("{<[[]]>}<{[{[{[]{()[[[]"))
    [<Test>]
    member _.Example10() = Assert.AreEqual(294, Day10Part2.autoCompleteScore ("<{([{{}}[<[[[<>{}]]]>[]]"))

    [<Test>]
    member _.Example() = Assert.AreEqual(288957, Day10Part2.getMedianScore (["[({(<(())[]>[[{[]{<()<>>";
                                                                             "[(()[<>])]({[<{<<[]>>(";
                                                                             "{([(<{}[<>[]}>{[]{[(<()>";
                                                                             "(((({<>}<{<{<>}{[]{[]{}";
                                                                             "[[<[([]))<([[{}[[()]]]";
                                                                             "[{[{({}]{}}([{[{{{}}([]";
                                                                             "{<[[]]>}<{[{[{[]{()[[[]";
                                                                             "[<(<(<(<{}))><([]([]()";
                                                                             "<{([([[(<>()){}]>(<<{{";
                                                                             "<{([{{}}[<[[[<>{}]]]>[]]"]))
