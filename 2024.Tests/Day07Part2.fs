namespace _2024.Tests

open NUnit.Framework
open _2024

[<TestFixture>] 
type Day07Part2 () =

    [<Test>]
    member _.Splitter1() =
        let expected = (190, [[[10]; [19]]; [[10; 19]]])
        let actual = Day07Part2.splitter("190: 10 19")
        Assert.That(actual, Is.EqualTo(expected))

    [<Test>]
    member _.Splitter2() =
        let expected = (3267, [[[81]; [40]; [27]]; [[81]; [40; 27]]; [[81; 40]; [27]]; [[81; 40; 27]]])
        Assert.That(Day07Part2.splitter("3267: 81 40 27"), Is.EqualTo(expected))

    [<Test>]
    member _.Splitter5() =
        let expected = (7290, [[[6]; [8]; [6]; [15]]; [[6]; [8]; [6; 15]]; [[6]; [8; 6]; [15]]; [[6]; [8; 6; 15]]; [[6; 8]; [6]; [15]]; [[6; 8]; [6; 15]]; [[6; 8; 6]; [15]]; [[6; 8; 6; 15]]])
        Assert.That(Day07Part2.splitter("7290: 6 8 6 15"), Is.EqualTo(expected))

    [<Test>]
    member _.peiceTogether1() =
        let input = seq {seq {seq {"10"}; seq {"19"}}; seq {seq {"10"; "19"}}}
        let expected = seq {1019; 10; 19}

        let actual = Day07Part2.peiceTogether(input)
        Assert.That(actual, Is.EqualTo(expected))

    [<Test>]
    member _.peiceTogether2() =
        let input = seq {seq {seq {"81"}; seq {"40"}; seq {"27"}}; seq {seq {"81"}; seq {"40"; "27"}}; seq {seq {"81"; "40"}; seq {"27"}}; seq {seq {"81"; "40"; "27"}}}
        let expected = seq {814027; 8140; 8127; 8127; 4027; 81; 40; 27}

        let actual = Day07Part2.peiceTogether(input)
        Assert.That(actual, Is.EqualTo(expected))

    // [<Test>]
    // member _.Example1() = Assert.That(Day07Part2.getValidValue("190: 10 19"), Is.EqualTo(190L))

    // [<Test>]
    // member _.Example2() = Assert.That(Day07Part2.getValidValue("3267: 81 40 27"), Is.EqualTo(3267L))

    // [<Test>]
    // member _.Example3() = Assert.That(Day07Part2.getValidValue("83: 17 5"), Is.EqualTo(0L))
    
    // [<Test>]
    // member _.Example4() = Assert.That(Day07Part2.getValidValue("156: 15 6"), Is.EqualTo(156L))
        
    // [<Test>]
    // member _.Example5() = Assert.That(Day07Part2.getValidValue("7290: 6 8 6 15"), Is.EqualTo(7290L))

    // [<Test>]
    // member _.Example6() = Assert.That(Day07Part2.getValidValue("161011: 16 10 13"), Is.EqualTo(0L))
    
    // [<Test>]
    // member _.Example7() = Assert.That(Day07Part2.getValidValue("192: 17 8 14"), Is.EqualTo(192L))
    
    // [<Test>]
    // member _.Example8() = Assert.That(Day07Part2.getValidValue("21037: 9 7 18 13"), Is.EqualTo(0L))
    
    // [<Test>]
    // member _.Example9() = Assert.That(Day07Part2.getValidValue("292: 11 6 16 20"), Is.EqualTo(292L))

    // [<Test>]
    // member _.Example() =
    
    //     let input = [
    //         "190: 10 19";
    //         "3267: 81 40 27";
    //         "83: 17 5";
    //         "156: 15 6";
    //         "7290: 6 8 6 15";
    //         "161011: 16 10 13";
    //         "192: 17 8 14";
    //         "21037: 9 7 18 13";
    //         "292: 11 6 16 20"
    //         ]

    //     Assert.That(Day07Part2.run(input), Is.EqualTo(11387))

