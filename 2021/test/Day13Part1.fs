namespace AoC2021.Tests

open NUnit.Framework
open AoC2021

[<TestFixture>] 
type Day13Part1 () =

    [<DefaultValue>] val mutable example  : seq<string>

    [<SetUp>]
    member this.SetUp() =
        this.example <-
            [| "6,10"; "0,14"; "9,10"; "0,3"; "10,4"; "4,11"; "6,0"; "6,12"; "4,1"; "0,13"; "10,12"; "3,4"; "3,0";
             "8,4"; "1,10"; "2,14"; "8,10"; "9,0"; ""; "fold along y=7"; "fold along x=5" |]

    [<Test>]
    member this.GetPaper() =

        let result = Day13Part1.getPaper(this.example)

        Assert.AreEqual( 18, result |> Seq.cast<bool> |> Seq.filter ((=) true) |> Seq.length, "count" )

        Assert.AreEqual( true,  Array2D.get result 3 0, "y = 3, x = 0")
        Assert.AreEqual( true,  Array2D.get result 0 3, "y = 0, x = 3")
        Assert.AreEqual( false, Array2D.get result 4 1, "y = 4, x = 1")
        Assert.AreEqual( true,  Array2D.get result 1 4, "y = 1, x = 4")

    [<Test>]
    member _.XFold() =

        //  **|..  ->  **
        //  ..|**  ->  **
        //  *.|.*  ->  .*

        let input  = Day13Part1.getPaper( [| "0,0"; "1,0"; "3,1"; "4,1"; "0,2"; "4,2" |] )
        let result = Day13Part1.xFold(2, input) |> Seq.cast<bool>

        CollectionAssert.AreEqual( [true; true; true; true; true; false], result )

    [<Test>]
    member _.YFold() =

        //  *.*
        //  ..*
        //  ---
        //  .*.
        //  **.
        //
        //  |||
        //  VVV
        //
        //  ***
        //  .**
        
        let input  = Day13Part1.getPaper( [| "0,0"; "2,0"; "2,1"; "1,3"; "0,4"; "1,4" |] )
        let result = Day13Part1.yFold(2, input) |> Seq.cast<bool>

        CollectionAssert.AreEqual( [true; true; true; false; true; true], result )

    [<Test>]
    member this.GetFolds() = CollectionAssert.AreEqual( [("y", 7); ("x", 5)], Day13Part1.getFolds(this.example) )

    [<Test>]
    member this.CountAfterFirstFold() = Assert.AreEqual( 17, Day13Part1.CountAfterFirstFold(this.example) )

    [<Test>]
    member this.ShowTheO() =
        let result =
            this.example
            |> Day13Part1.getPaper 
            |> fun paper -> Day13Part1.yFold (7, paper)
            |> fun paper -> Day13Part1.xFold (5, paper)
            |> Seq.cast<bool>

        let expected =
            [true;  true;  true;  true;  true;
             true;  false; false; false; true;
             true;  false; false; false; true;
             true;  false; false; false; true;
             true;  true;  true;  true;  true;
             false; false; false; false; false;
             false; false; false; false; false]
             

        CollectionAssert.AreEqual( expected, result )

    [<Test>]
    member _.XFoldShort() =

        //  ...|.. ->   ...
        //  ...|*. ->   ..*


        let input  = Day13Part1.getPaper( [| "4,1" |] )
        let result = Day13Part1.xFold(3, input) |> Seq.cast<bool>

        CollectionAssert.AreEqual( [false; false; false; false; false; true], result )

    [<Test>]
    member _.YFoldShort() =

        //  ..*
        //  ...
        //  ...
        //  ---
        //  ...
        //  *..

        //
        //  |||
        //  VVV
        //
        //  ..*
        //  *..
        //  ...
        
        let input  = Day13Part1.getPaper( [| "2,0"; "0,5" |] )
        let result = Day13Part1.yFold(3, input) |> Seq.cast<bool>

        CollectionAssert.AreEqual( [false; false; true; true; false; false; false; false; false], result )
