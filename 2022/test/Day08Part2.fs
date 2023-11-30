namespace AoC2022.Tests

open NUnit.Framework
open AoC2022

[<TestFixture>] 
type Day08Part2 () =

    [<DefaultValue>] val mutable example : seq<string>

    [<SetUp>]
    member this.SetUp() =
        this.example <- ["30373"; "25512"; "65332"; "33549"; "35390"]       

    [<Test>]
    member this.getMostScenicScore() = Assert.AreEqual(8, Day08Part2.getMostScenicScore (this.example))

    [<Test>]
    member _.countTreesYouCanSeeFirstTreeTaller() = Assert.AreEqual(1, Day08Part2.countTreesYouCanSee ([|'7'; '5'; '2'; '9'|], '3', false))
 
    [<Test>]
    member _.countTreesYouCanSeeSecondTreeSame() = Assert.AreEqual(2, Day08Part2.countTreesYouCanSee ([|'2'; '4'; '2'; '9'|], '4', false))

    [<Test>]
    member _.countTreesYouCanSeeEdgeCase() = Assert.AreEqual(0, Day08Part2.countTreesYouCanSee ([||], '3', false))

    [<Test>]
    member _.countTreesYouCanSeeLastTreeTaller() = Assert.AreEqual(4, Day08Part2.countTreesYouCanSee ([|'1'; '0'; '2'; '9'|], '3', false))
    
    [<Test>]
    member _.countTreesYouCanSeeAllTrees() = Assert.AreEqual(4, Day08Part2.countTreesYouCanSee ([|'1'; '0'; '2'; '2'|], '3', false))

    [<Test>]
    member _.countTreesYouCanSeeBackwards() = Assert.AreEqual(2, Day08Part2.countTreesYouCanSee ([|'2'; '0'; '5'; '2'|], '4', true))
