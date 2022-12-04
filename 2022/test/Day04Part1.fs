namespace AoC2022.Tests

open NUnit.Framework
open AoC2022

[<TestFixture>] 
type Day04Part1 () =

    [<Test>]
    member _.ParseInput() = Assert.AreEqual([|11; 22; 33; 4444|], Day04Part1.ParseInput "11-22,33-4444" )
       
    [<Test>]
    member _.IsContainedFirstInSecond () = Assert.AreEqual(true, Day04Part1.IsOneFullyContainedWithinTheOther [|15; 20; 14; 21|] )

    [<Test>]
    member _.IsContainedSecondInFirst () = Assert.AreEqual(true, Day04Part1.IsOneFullyContainedWithinTheOther [|1; 100; 14; 21|] )

    [<Test>]
    member _.IsContainedSame () = Assert.AreEqual(true, Day04Part1.IsOneFullyContainedWithinTheOther [|1; 100; 1; 100|] )

    [<Test>]
    member _.IsContainedFalseOverlapA () = Assert.AreEqual(false, Day04Part1.IsOneFullyContainedWithinTheOther [|10; 20; 15; 25|] )

    [<Test>]
    member _.IsContainedFalseOverlapB () = Assert.AreEqual(false, Day04Part1.IsOneFullyContainedWithinTheOther [|10; 20; 5; 15|] )

    [<Test>]
    member _.IsContainedFalseNoOverlapAdjacent () = Assert.AreEqual(false, Day04Part1.IsOneFullyContainedWithinTheOther [|10; 20; 30; 40|] )

    [<Test>]
    member _.IsContainedFalseNoOverlapGap () = Assert.AreEqual(false, Day04Part1.IsOneFullyContainedWithinTheOther [|10; 10; 30; 40|] )

    [<Test>]
    member _.Example() = Assert.AreEqual(2, Day04Part1.GetNumberOfPairsWhereOneRangeFullyContainsTheOther [|"2-4,6-8"; "2-3,4-5"; "5-7,7-9"; "2-8,3-7"; "6-6,4-6"; "2-6,4-8"|] )
