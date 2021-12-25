namespace AoC2021.Tests

open NUnit.Framework
open AoC2021

[<TestFixture>] 
type Day25Part1 () =

    [<DefaultValue>] val mutable example  : seq<string>

    [<SetUp>]
    member this.SetUp() =
        this.example <-
            [| "v...>>.vv>"; 
            ".vv>>.vv..";
            ">>.>v>...v";
            ">>v>>.>.v.";
            "v>v.vv.v..";
            ">.>>..v...";
            ".vv..>.>v.";
            "v.v..>>v.v" |]

    [<Test>]
    member this.getSeafloor() =

        let result = Day25Part1.getSeafloor(this.example)

        Assert.AreEqual( 34, result |> Seq.cast<char> |> Seq.filter ((=) '.') |> Seq.length, "count ." )
        Assert.AreEqual( 22, result |> Seq.cast<char> |> Seq.filter ((=) '>') |> Seq.length, "count >" )
        Assert.AreEqual( 24, result |> Seq.cast<char> |> Seq.filter ((=) 'v') |> Seq.length, "count v" )

        Assert.AreEqual( '>',  Array2D.get result 3 0, "y = 3, x = 0")
        Assert.AreEqual( '.',  Array2D.get result 0 3, "y = 0, x = 3")
        Assert.AreEqual( '>', Array2D.get result 4 1, "y = 4, x = 1")
        Assert.AreEqual( '>',  Array2D.get result 1 4, "y = 1, x = 4")


    [<Test>]
    member _.MoveEastExample1A() =

        let start = Day25Part1.getSeafloor( ["...>>>>>..." ] )

        let result = Day25Part1.moveEast(start)

        Assert.AreEqual( 6, result |> Seq.cast<char> |> Seq.filter ((=) '.') |> Seq.length, "count ." )
        Assert.AreEqual( 5, result |> Seq.cast<char> |> Seq.filter ((=) '>') |> Seq.length, "count >" )
        Assert.AreEqual( 0, result |> Seq.cast<char> |> Seq.filter ((=) 'v') |> Seq.length, "count v" )

        Assert.AreEqual( '.',  Array2D.get result 0 0, "y = 0, x = 0")
        Assert.AreEqual( '.',  Array2D.get result 0 1, "y = 0, x = 1")
        Assert.AreEqual( '.',  Array2D.get result 0 2, "y = 0, x = 2")
        Assert.AreEqual( '>',  Array2D.get result 0 3, "y = 0, x = 3")
        Assert.AreEqual( '>',  Array2D.get result 0 4, "y = 0, x = 4")
        Assert.AreEqual( '>',  Array2D.get result 0 5, "y = 0, x = 5")
        Assert.AreEqual( '>',  Array2D.get result 0 6, "y = 0, x = 6")
        Assert.AreEqual( '.',  Array2D.get result 0 7, "y = 0, x = 7")
        Assert.AreEqual( '>',  Array2D.get result 0 8, "y = 0, x = 8")
        Assert.AreEqual( '.',  Array2D.get result 0 9, "y = 0, x = 9")
        Assert.AreEqual( '.',  Array2D.get result 0 10, "y = 0, x = 10")

    [<Test>]
    member _.MoveEastExample1B() =

        let start = Day25Part1.getSeafloor( ["...>>>>.>.." ] )

        let result = Day25Part1.moveEast(start)

        Assert.AreEqual( 6, result |> Seq.cast<char> |> Seq.filter ((=) '.') |> Seq.length, "count ." )
        Assert.AreEqual( 5, result |> Seq.cast<char> |> Seq.filter ((=) '>') |> Seq.length, "count >" )
        Assert.AreEqual( 0, result |> Seq.cast<char> |> Seq.filter ((=) 'v') |> Seq.length, "count v" )

        Assert.AreEqual( '.',  Array2D.get result 0 0, "y = 0, x = 0")
        Assert.AreEqual( '.',  Array2D.get result 0 1, "y = 0, x = 1")
        Assert.AreEqual( '.',  Array2D.get result 0 2, "y = 0, x = 2")
        Assert.AreEqual( '>',  Array2D.get result 0 3, "y = 0, x = 3")
        Assert.AreEqual( '>',  Array2D.get result 0 4, "y = 0, x = 4")
        Assert.AreEqual( '>',  Array2D.get result 0 5, "y = 0, x = 5")
        Assert.AreEqual( '.',  Array2D.get result 0 6, "y = 0, x = 6")
        Assert.AreEqual( '>',  Array2D.get result 0 7, "y = 0, x = 7")
        Assert.AreEqual( '.',  Array2D.get result 0 8, "y = 0, x = 8")
        Assert.AreEqual( '>',  Array2D.get result 0 9, "y = 0, x = 9")
        Assert.AreEqual( '.',  Array2D.get result 0 10, "y = 0, x = 10")

    [<Test>]
    member _.MoveExample2A() =

        let start = Day25Part1.getSeafloor( [".........."; ".>v....v.."; ".......>.."; ".........." ] )

        let result = Day25Part1.move(start)

        Assert.AreEqual( 36, result |> Seq.cast<char> |> Seq.filter ((=) '.') |> Seq.length, "count ." )
        Assert.AreEqual(  2, result |> Seq.cast<char> |> Seq.filter ((=) '>') |> Seq.length, "count >" )
        Assert.AreEqual(  2, result |> Seq.cast<char> |> Seq.filter ((=) 'v') |> Seq.length, "count v" )

        Assert.AreEqual( '.',  Array2D.get result 1 0, "y = 1, x = 0")
        Assert.AreEqual( '>',  Array2D.get result 1 1, "y = 1, x = 1")
        Assert.AreEqual( '.',  Array2D.get result 1 2, "y = 1, x = 2")
        Assert.AreEqual( '.',  Array2D.get result 1 3, "y = 1, x = 3")
        Assert.AreEqual( '.',  Array2D.get result 1 7, "y = 1, x = 7")
        Assert.AreEqual( 'v',  Array2D.get result 2 2, "y = 2, x = 2")
        Assert.AreEqual( 'v',  Array2D.get result 2 7, "y = 2, x = 7")

    [<Test>]
    member _.MoveExample3A() =

        let start = Day25Part1.getSeafloor( [ "...>..."; "......."; "......>"; "v.....>"; "......>"; ".......";
                                                 "..vvv.." ] )

        let result = Day25Part1.move(start)

        Assert.AreEqual( 41, result |> Seq.cast<char> |> Seq.filter ((=) '.') |> Seq.length, "count ." )
        Assert.AreEqual(  4, result |> Seq.cast<char> |> Seq.filter ((=) '>') |> Seq.length, "count >" )
        Assert.AreEqual(  4, result |> Seq.cast<char> |> Seq.filter ((=) 'v') |> Seq.length, "count v" )

        Assert.AreEqual( 'v',  Array2D.get result 0 2, "y = 0, x = 2")
        Assert.AreEqual( 'v',  Array2D.get result 0 3, "y = 0, x = 3")
        Assert.AreEqual( '>',  Array2D.get result 0 4, "y = 0, x = 4")
        Assert.AreEqual( '>',  Array2D.get result 2 0, "y = 2, x = 0")
        Assert.AreEqual( 'v',  Array2D.get result 3 0, "y = 3, x = 0")
        Assert.AreEqual( '>',  Array2D.get result 3 6, "y = 3, x = 6")
        Assert.AreEqual( '>',  Array2D.get result 4 0, "y = 4, x = 0")
        Assert.AreEqual( 'v',  Array2D.get result 6 4, "y = 6, x = 4")

    [<Test>]
    member _.AreEqualTrue() =

        let a = Day25Part1.getSeafloor( ["abc"; "def" ] )
        let b = Day25Part1.getSeafloor( ["abc"; "def" ] )
        Assert.AreEqual ( true, Day25Part1.areEqual(a, b) )

    [<Test>]
    member _.AreEqualFalse() =

        let a = Day25Part1.getSeafloor( ["abc"; "def" ] )
        let b = Day25Part1.getSeafloor( ["abc"; "fed" ] )
        Assert.AreEqual ( false, Day25Part1.areEqual(a, b) )

    [<Test>]
    member _.MoveExample4() =

        let start = Day25Part1.getSeafloor( [ "v...>>.vv>"; ".vv>>.vv.."; ">>.>v>...v"; ">>v>>.>.v."; "v>v.vv.v..";
                                                ">.>>..v...";".vv..>.>v."; "v.v..>>v.v"; "....v..v.>" ] )

        Assert.AreEqual( 58, Day25Part1.countSteps(start, 0) )




