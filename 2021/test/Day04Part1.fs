namespace AoC2021.Tests

open NUnit.Framework
open AoC2021

[<TestFixture>] 
type Day04Part1 () =

    [<Test>]
    member _.CheckForBingoNo() = Assert.AreEqual(false, fst (Day04Part1.checkForBingo(array2D [["1"; "2"; "3"; "4"; "5"];
                                                                                               ["6"; "7"; "8"; "9"; "10"];
                                                                                               ["1"; "2"; "*"; "4"; "5"];
                                                                                               ["6"; "*"; "8"; "9"; "10"];
                                                                                               ["6"; "7"; "8"; "9"; "10"]])))

                                                                                     
    [<Test>]
    member _.CheckForBingoYesVertical() = Assert.AreEqual((true, 120), Day04Part1.checkForBingo(array2D [["1"; "2"; "*"; "4"; "5"];
                                                                                                         ["6"; "7"; "*"; "9"; "10"];
                                                                                                         ["1"; "2"; "*"; "4"; "5"];
                                                                                                         ["6"; "7"; "*"; "9"; "10"];
                                                                                                         ["6"; "7"; "*"; "9"; "10"]]))
    [<Test>]
    member _.CheckForBingoYesHorizontal() = Assert.AreEqual((true, 135), Day04Part1.checkForBingo(array2D [["1"; "2"; "3"; "4"; "5"];
                                                                                                           ["6"; "7"; "8"; "9"; "10"];
                                                                                                           ["*"; "*"; "*"; "*"; "*"];
                                                                                                           ["6"; "7"; "8"; "9"; "10"];
                                                                                                           ["6"; "7"; "8"; "9"; "10"]]))
