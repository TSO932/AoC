namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day09Part1 () =

    [<Test>]
    member _.AndEveryDiscoIveBeenIn() = Assert.AreEqual(("Paris", "Berlin", 878), Day09Part1.parseDistance ("Paris to Berlin = 878"))

    [<Test>]
    member _.getListOfCities() = Assert.AreEqual([|"Paris"; "Berlin"; "London"; "Dublin"|], Day09Part1.getSequenceOfCities ([|"Paris to Berlin = 878"; "London to Dublin = 464"; "London to London = 0"|]))
