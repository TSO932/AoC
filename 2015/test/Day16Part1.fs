namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day16Part1 () =

    [<Test>]
    member _.ParseAuntSue() =
        let sue = { Day16Part1.IdentityNumber = 1;
                    Day16Part1.Trait1 = "children"; Day16Part1.Value1 = 2;
                    Day16Part1.Trait2 = "cats"; Day16Part1.Value2 = 3;
                    Day16Part1.Trait3 = "perfumes"; Day16Part1.Value3 = 7 }

        Assert.AreEqual(sue, Day16Part1.parseAuntSue ("Sue 1: children: 2, cats: 3, perfumes: 7"))

    [<Test>]
    member _.IsTheRightSueTrue() =
        let sue = { Day16Part1.IdentityNumber = 1;
                    Day16Part1.Trait1 = "children"; Day16Part1.Value1 = 3;
                    Day16Part1.Trait2 = "cats"; Day16Part1.Value2 = 7;
                    Day16Part1.Trait3 = "samoyeds"; Day16Part1.Value3 = 2 }

        Assert.AreEqual((true, 1), Day16Part1.isTheRightSue (sue))

    [<Test>]
    member _.IsTheRightSueWrongValue() =
        let sue = { Day16Part1.IdentityNumber = 2;
                    Day16Part1.Trait1 = "children"; Day16Part1.Value1 = 3;
                    Day16Part1.Trait2 = "cats"; Day16Part1.Value2 = 7;
                    Day16Part1.Trait3 = "samoyeds"; Day16Part1.Value3 = 99 }

        Assert.AreEqual((false, 2), Day16Part1.isTheRightSue (sue))

    [<Test>]
    member _.IsTheRightSueMissingTrait() =
        let sue = { Day16Part1.IdentityNumber = 3;
                    Day16Part1.Trait1 = "zebrafish"; Day16Part1.Value1 = 5;
                    Day16Part1.Trait2 = "trees"; Day16Part1.Value2 = 3;
                    Day16Part1.Trait3 = "cars"; Day16Part1.Value3 = 2 }

        Assert.AreEqual((false, 3), Day16Part1.isTheRightSue (sue))
