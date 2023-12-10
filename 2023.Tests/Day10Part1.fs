namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day10Part1 () =

    [<DefaultValue>] val mutable example1 : char[,]
    [<DefaultValue>] val mutable example2 : char[,]
    
    [<SetUp>]
    member this.SetUp() =
        this.example1 <- array2D [['-'; 'L'; '|'; 'F'; '7']; ['7'; 'S'; '-'; '7'; '|']; ['L'; '|'; '7'; '|'; '|'];  ['-'; 'L'; '-'; 'J'; '|']; ['L'; '|'; '-'; 'J'; 'F']]
        this.example2 <- array2D [['7'; '-'; 'F'; '7'; '-']; ['.'; 'F'; 'J'; '|'; '7']; ['S'; 'J'; 'L'; 'L'; '7'];  ['|'; 'F'; '-'; '-'; 'J']; ['L'; 'J'; '.'; 'L'; 'J']]

    [<Test>]
    member this.GetTiles() = CollectionAssert.AreEqual(this.example1, Day10Part1.getTiles ([|"-L|F7"; "7S-7|"; "L|7||"; "-L-J|"; "L|-JF"|]))

    
    [<Test>]
    member this.FindS1() = Assert.AreEqual((1, 1), Day10Part1.findS (this.example1))

    [<Test>]
    member this.FindS2() = Assert.AreEqual((0, 2), Day10Part1.findS (this.example2))

    [<Test>]
    member this.FindFriends() = CollectionAssert.AreEqual([|(1, 1); (1, 2); (2, 1)|], Day10Part1.findFriends (this.example1, (1, 1)))

    [<Test>]
    member this.FindFriendsEdge() = CollectionAssert.AreEqual([|(0, 0)|], Day10Part1.findFriends (this.example1, (0, 0)))

    [<Test>]
    member _.GetPipeLength1() = Assert.AreEqual(4, Day10Part1.getPipeLength ([|"-L|F7"; "7S-7|"; "L|7||"; "-L-J|"; "L|-JF"|]))

    [<Test>]
    member _.GetPipeLength2() = Assert.AreEqual(8, Day10Part1.getPipeLength ([|"7-F7-"; ".FJ|7"; "SJLL7"; "|F--J"; "LJ.LJ"|]))