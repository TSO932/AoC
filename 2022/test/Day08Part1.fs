namespace AoC2022.Tests

open NUnit.Framework
open AoC2022

[<TestFixture>] 
type Day08Part1 () =

    [<DefaultValue>] val mutable example : seq<string>

    [<SetUp>]
    member this.SetUp() =
        this.example <- ["30373"; "25512"; "25512"; "33549"; "35390"]       

    [<Test>]
    member this.countVisibleTrees() = Assert.AreEqual(21, Day08Part1.countVisibleTrees (this.example))

    [<Test>]
    member _.isVisibleFalseBigger() = Assert.AreEqual(false, Day08Part1.isVisible ([|'7'; '5'; '2'; '9'|], '3'))

    [<Test>]
    member _.isVisibleFalseSameHeight() = Assert.AreEqual(false, Day08Part1.isVisible ([|'4'|], '4'))
    
    [<Test>]
    member _.isVisibleTrueEdgeCase() = Assert.AreEqual(true, Day08Part1.isVisible ([||], '4'))

    [<Test>]
    member _.isVisibleTrueAllSmaller() = Assert.AreEqual(true, Day08Part1.isVisible ([|'2'; '3'; '1'|], '4'))
   
    [<Test>]
    member _.isVisibleFalseNumeric() = Assert.AreEqual(false, Day08Part1.isVisible ([|4; 5|], 4))