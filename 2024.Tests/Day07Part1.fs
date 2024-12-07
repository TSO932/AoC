namespace _2024.Tests

open NUnit.Framework
open _2024

[<TestFixture>] 
type Day07Part1 () =

    [<Test>]
    member _.Example1() = Assert.That(Day07Part1.getValidValue("190: 10 19"), Is.EqualTo(190L))

    [<Test>]
    member _.Example2() = Assert.That(Day07Part1.getValidValue("3267: 81 40 27"), Is.EqualTo(3267L))

    [<Test>]
    member _.Example3() = Assert.That(Day07Part1.getValidValue("83: 17 5"), Is.EqualTo(0L))
    
    [<Test>]
    member _.Example4() = Assert.That(Day07Part1.getValidValue("156: 15 6"), Is.EqualTo(0L))
        
    [<Test>]
    member _.Example5() = Assert.That(Day07Part1.getValidValue("7290: 6 8 6 15"), Is.EqualTo(0L))

    [<Test>]
    member _.Example6() = Assert.That(Day07Part1.getValidValue("161011: 16 10 13"), Is.EqualTo(0L))
    
    [<Test>]
    member _.Example7() = Assert.That(Day07Part1.getValidValue("192: 17 8 14"), Is.EqualTo(0L))
    
    [<Test>]
    member _.Example8() = Assert.That(Day07Part1.getValidValue("21037: 9 7 18 13"), Is.EqualTo(0L))
    
    [<Test>]
    member _.Example9() = Assert.That(Day07Part1.getValidValue("292: 11 6 16 20"), Is.EqualTo(292L))

    [<Test>]
    member _.Example() =
    
        let input = [
            "190: 10 19";
            "3267: 81 40 27";
            "83: 17 5";
            "156: 15 6";
            "7290: 6 8 6 15";
            "161011: 16 10 13";
            "192: 17 8 14";
            "21037: 9 7 18 13";
            "292: 11 6 16 20"
            ]

        Assert.That(Day07Part1.run(input), Is.EqualTo(3749))







        