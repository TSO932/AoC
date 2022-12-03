namespace AoC2022.Tests

open NUnit.Framework
open AoC2022

[<TestFixture>] 
type Day03Part2 () =

    [<Test>]
    member _.GetBadgeExample1() = Assert.AreEqual('r', Day03Part2.GetBadge [|"vJrwpWtwJgWrhcsFMMfFFhFp"; "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL"; "PmmdzqPrVvPwwTWBwg"|] )

    [<Test>]
    member _.GetBadgeExample2() = Assert.AreEqual('Z', Day03Part2.GetBadge [|"wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn"; "ttgJtRGJQctTZtZT"; "CrZsJsPPZsGzwwsLwLmpwMDw"|] )

    [<Test>]
    member _.GetSumOfPriorities() = Assert.AreEqual(70, Day03Part2.GetSumOfPriorities [|"vJrwpWtwJgWrhcsFMMfFFhFp"; "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL"; "PmmdzqPrVvPwwTWBwg"; "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn"; "ttgJtRGJQctTZtZT"; "CrZsJsPPZsGzwwsLwLmpwMDw"|] )
