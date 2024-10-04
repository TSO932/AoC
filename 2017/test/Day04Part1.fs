namespace AoC2017.Tests

open NUnit.Framework
open AoC2017

[<TestFixture>]
type Day04Part1() =

    [<Test>]
    member _.Example1() =
        Assert.AreEqual(true, Day04Part1.isValid "aa bb cc dd ee")

    [<Test>]
    member _.Example2() =
        Assert.AreEqual(false, Day04Part1.isValid "aa bb cc dd aa")

    [<Test>]
    member _.Example3() =
        Assert.AreEqual(true, Day04Part1.isValid "aa bb cc dd aaa")

    [<Test>]
    member _.BunchOfQuotations() =
        let input =
            [ "A horse, a horse, my kingdom for a horse!"
              "one potato, two potato, three potato, four"
              "One flesh, one bone, One true religion. One voice, one hope, one real decision. Whoa, whoa, whoa, whoa, whoa, whoa. Give me one vision, yeah"
              "Talk for sixty seconds on a given subject without hesitation, repetition or deviation" ]

        Assert.AreEqual(1, Day04Part1.countValidPasswords input)
