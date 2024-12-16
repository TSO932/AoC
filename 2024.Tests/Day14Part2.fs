namespace _2024.Tests

open NUnit.Framework
open _2024

[<TestFixture>] 
type Day14Part2 () =

    [<Test>]
    member _.isOverlapFalse() =

        let input = [|
            [|0; 4; 2; 3|];
            [|4; 4; 2; 3|];
            [|0; 0; 2; 3|] |]

        Assert.That(Day14Part2.isOverlap(input), Is.EqualTo(false))

    [<Test>]
    member _.isOverlapTrue() =

        let input = [|
            [|4; 4; 2; 3|];
            [|4; 4; 2; 3|];
            [|0; 4; 2; 3|] |]

        Assert.That(Day14Part2.isOverlap(input), Is.EqualTo(true))

    [<Test>]
    member _.Example() =

        let input = seq {
            "p=0,4 v=3,-3";
            "p=6,3 v=-1,-3";
            "p=10,3 v=-1,2";
            "p=2,0 v=2,-1";
            "p=0,0 v=1,3";
            "p=3,0 v=-2,-2";
            "p=7,6 v=-1,-3";
            "p=3,0 v=-1,-2";
            "p=9,3 v=2,3";
            "p=7,3 v=-1,2";
            "p=2,4 v=2,-3";
            "p=9,5 v=-3,-3" }
    
        Assert.That(Day14Part2.run(input), Is.EqualTo(1))