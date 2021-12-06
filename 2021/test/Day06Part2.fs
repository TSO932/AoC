namespace AoC2021.Tests

open NUnit.Framework
open AoC2021

[<TestFixture>] 
type Day06Part2 () =

    [<Test>]
    member _.ageFishes() = Assert.AreEqual([(2, 2); (3, 1); (6, 4); (8, 3)], Day06Part2.ageFishes([(3, 2); (4, 1); (0, 3); (7, 1)]))
    
    [<Test>]
    member _.example1() = Assert.AreEqual(26, Day06Part2.countFish("3,4,3,1,2", 18))

    [<Test>]
    member _.example2() = Assert.AreEqual(5934, Day06Part2.countFish("3,4,3,1,2", 80))

    [<Test>]
    member _.example3() = Assert.AreEqual(26984457539L, Day06Part2.countFish("3,4,3,1,2", 256))
