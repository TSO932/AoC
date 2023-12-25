namespace AoC2022.Tests

open NUnit.Framework
open AoC2022

[<TestFixture>] 
type Day04Part2 () =

    [<Test>]
    member _.IsOverlapExample1 () = Assert.AreEqual(false, Day04Part2.IsOverlap [|2; 4; 6; 8|] )

    [<Test>]
    member _.IsOverlapExample2 () = Assert.AreEqual(false, Day04Part2.IsOverlap [|2; 3; 4; 5|] )

    [<Test>]
    member _.IsOverlapExample3 () = Assert.AreEqual(true, Day04Part2.IsOverlap [|5; 7; 7; 9|] )

    [<Test>]
    member _.IsOverlapExample4 () = Assert.AreEqual(true, Day04Part2.IsOverlap [|2; 8; 3; 7|] )
    
    [<Test>]
    member _.IsOverlapExample5 () = Assert.AreEqual(true, Day04Part2.IsOverlap [|6; 6; 4; 6|] )

    [<Test>]
    member _.IsOverlapExample6 () = Assert.AreEqual(true, Day04Part2.IsOverlap [|2; 6; 4; 8|] )

    [<Test>]
    member _.Example() = Assert.AreEqual(4, Day04Part2.GetNumberOfOverlaps [|"2-4,6-8"; "2-3,4-5"; "5-7,7-9"; "2-8,3-7"; "6-6,4-6"; "2-6,4-8"|] )
