namespace AoC2022.Tests

open NUnit.Framework
open AoC2022

[<TestFixture>] 
type Day03Part1 () =

    [<Test>]
    member _.GetCommonCharacterExample1() = Assert.AreEqual('p', Day03Part1.GetCommonCharacter "vJrwpWtwJgWrhcsFMMfFFhFp" )
    
    [<Test>]
    member _.GetCommonCharacterExample2() = Assert.AreEqual('L', Day03Part1.GetCommonCharacter "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL" )
    
    [<Test>]
    member _.GetCommonCharacterExample3() = Assert.AreEqual('P', Day03Part1.GetCommonCharacter "PmmdzqPrVvPwwTWBwg" )
    
    [<Test>]
    member _.GetCommonCharacterExample4() = Assert.AreEqual('v', Day03Part1.GetCommonCharacter "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn" )

    [<Test>]
    member _.GetCommonCharacterExample5() = Assert.AreEqual('t', Day03Part1.GetCommonCharacter "ttgJtRGJQctTZtZT" )
    
    [<Test>]
    member _.GetCommonCharacterExample6() = Assert.AreEqual('s', Day03Part1.GetCommonCharacter "CrZsJsPPZsGzwwsLwLmpwMDw" )


    [<Test>]
    member _.GetPriorityMin() = Assert.AreEqual(1, Day03Part1.GetPriority 'a' )
    
    [<Test>]
    member _.GetPriorityMaxLowerCase() = Assert.AreEqual(26, Day03Part1.GetPriority 'z' )
    
    [<Test>]
    member _.GetPriorityMinUpperCase() = Assert.AreEqual(27, Day03Part1.GetPriority 'A' )

    [<Test>]
    member _.GetPriorityMax() = Assert.AreEqual(52, Day03Part1.GetPriority 'Z' )

    [<Test>]
    member _.GetPriorityExample1() = Assert.AreEqual(16, Day03Part1.GetPriority 'p' )
    
    [<Test>]
    member _.GetPriorityExample2() = Assert.AreEqual(38, Day03Part1.GetPriority 'L' )
    
    [<Test>]
    member _.GetPriorityExample3() = Assert.AreEqual(42, Day03Part1.GetPriority 'P' )
    
    [<Test>]
    member _.GetPriorityExample4() = Assert.AreEqual(22, Day03Part1.GetPriority 'v' )
    
    [<Test>]
    member _.GetPriorityExample5() = Assert.AreEqual(20, Day03Part1.GetPriority 't' )
        
    [<Test>]
    member _.GetPriorityExample6() = Assert.AreEqual(19, Day03Part1.GetPriority 's' )
        
    [<Test>]
    member _.GetSumOfPriorities() = Assert.AreEqual(157, Day03Part1.GetSumOfPriorities [|"vJrwpWtwJgWrhcsFMMfFFhFp"; "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL"; "PmmdzqPrVvPwwTWBwg"; "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn"; "ttgJtRGJQctTZtZT"; "CrZsJsPPZsGzwwsLwLmpwMDw"|] )
