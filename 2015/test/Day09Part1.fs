namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day09Part1 () =

    [<Test>]
    member _.AndEveryDiscoIveBeenIn() = Assert.AreEqual(("Paris", "Berlin", 878), Day09Part1.parseDistance ("Paris to Berlin = 878"))

    [<Test>]
    member _.GetListOfCities() = Assert.AreEqual(["Paris"; "Berlin"; "London"; "Dublin"], Day09Part1.getListOfCities ([|("Paris", "Berlin", 878); ("London", "Dublin", 464); ("London", "London", 0)|]))

    [<Test>]
    member _.Distance() =
        let distances = Day09Part1.DistanceDictionary()
        distances.Populate([|("A", "B", 1); ("B", "C", 7); ("C", "A", 12)|])
        Assert.AreEqual(7, distances.Get("B", "C"))

    [<Test>]
    member _.DistanceBackwards() =
        let distances = Day09Part1.DistanceDictionary()
        distances.Populate([|("A", "B", 1); ("B", "C", 7); ("C", "A", 12)|])
        Assert.AreEqual(12, distances.Get("A", "C"))

    [<Test>]
    member _.Example() = Assert.AreEqual(605, Day09Part1.findShortestDistance ([|"London to Dublin = 464"; "London to Belfast = 518"; "Dublin to Belfast = 141"|]))





    
