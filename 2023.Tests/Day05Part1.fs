namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day05Part1 () =
    [<DefaultValue>] val mutable seedToSoil : seq<string>
    [<DefaultValue>] val mutable soilToFertilizer : seq<string>
    [<DefaultValue>] val mutable fertilizerToWater : seq<string>
    [<DefaultValue>] val mutable waterToLight : seq<string>
    [<DefaultValue>] val mutable lightToTemperature : seq<string>
    [<DefaultValue>] val mutable temperatureToHumidity : seq<string>
    [<DefaultValue>] val mutable humidityToLocation : seq<string>

    [<DefaultValue>] val mutable mapaHortus : seq<seq<string>>
    
    [<SetUp>]
    member this.SetUp() =
        this.seedToSoil <- [|"50 98 2"; "52 50 48"|]
        this.soilToFertilizer <- [|"0 15 37"; "37 52 2"; "39 0 15"|]
        this.fertilizerToWater <- [|"49 53 8"; "0 11 42"; "42 0 7"; "57 7 4"|]
        this.waterToLight <- [|"88 18 7"; "18 25 70"|]
        this.lightToTemperature <- [|"45 77 23"; "81 45 19"; "68 64 13"|]
        this.temperatureToHumidity <- [|"0 69 1"; "1 0 69"|]
        this.humidityToLocation <- [|"60 56 37"; "56 93 4"|]

        this.mapaHortus <- [|this.seedToSoil; this.soilToFertilizer; this.fertilizerToWater; this.waterToLight; this.lightToTemperature; this.temperatureToHumidity; this.humidityToLocation|]

    [<Test>]
    member _.ParseMapLine() = CollectionAssert.AreEqual([|50; 98; 2|], Day05Part1.parseMapLine "50 98 2")

    [<Test>]
    member _.GetNextValue79() = Assert.AreEqual(81, Day05Part1.getNextValue (79, [|"50 98 2"; "52 50 48"|]))

    [<Test>]
    member _.GetNextValue14() = Assert.AreEqual(14, Day05Part1.getNextValue (14, [|"50 98 2"; "52 50 48"|]))

    [<Test>]
    member _.GetNextValue55() = Assert.AreEqual(57, Day05Part1.getNextValue (55, [|"50 98 2"; "52 50 48"|]))

    [<Test>]
    member _.GetNextValue13() = Assert.AreEqual(13, Day05Part1.getNextValue (13, [|"50 98 2"; "52 50 48"|]))

    [<Test>]
    member this.MapSeedToLocation() = Assert.AreEqual(82, Day05Part1.mapSeedToLocation (79, this.mapaHortus))

    [<Test>]
    member this.FindLowestLocation() = Assert.AreEqual(35, Day05Part1.findLowestLocation ([|79; 14; 55; 13|], this.mapaHortus))
 
    [<Test>]
    member this.FindLowestLocationPart2() = Assert.AreEqual(46L, Day05Part3.findLowestLocation ([|(79L, 14L); (55L, 13L)|], this.mapaHortus))