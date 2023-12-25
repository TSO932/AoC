namespace _2023.Tests

open NUnit.Framework
open _2023

[<TestFixture>]
type Day10Part2 () =

    [<DefaultValue>] val mutable example1 : char[,]
    [<DefaultValue>] val mutable example2 : char[,]
    
    [<SetUp>]
    member this.SetUp() =
        this.example1 <- array2D [[' '; ' '; ' '; ' '; ' ']; [' '; 'S'; '-'; '7'; ' ']; [' '; '|'; ' '; '|'; ' '];  [' '; 'L'; '-'; 'J'; ' ']; [' '; ' '; ' '; ' '; ' ']]
        this.example2 <- array2D [[' '; ' '; 'F'; '7'; ' ']; [' '; 'F'; 'J'; '|'; ' ']; ['S'; 'J'; ' '; 'L'; '7'];  ['|'; 'F'; '-'; '-'; 'J']; ['L'; 'J'; ' '; ' '; ' ']]
    [<Test>]
    member this.GetPipe1() = Assert.AreEqual(this.example1, Day10Part2.getPipe ([|"-L|F7"; "7S-7|"; "L|7||"; "-L-J|"; "L|-JF"|]))

    [<Test>]
    member this.GetPipe2() = Assert.AreEqual(this.example2, Day10Part2.getPipe ([|"7-F7-"; ".FJ|7"; "SJLL7"; "|F--J"; "LJ.LJ"|]))

    [<Test>]
    member this.GetArea1() = Assert.AreEqual(4, Day10Part2.getArea ([|"..........."; ".S-------7."; ".|F-----7|."; ".||.....||."; ".||.....||."; ".|L-7.F-J|."; ".|..|.|..|."; ".L--J.L--J."; "..........."|]))

    [<Test>]
    member this.GetArea2() = Assert.AreEqual(4, Day10Part2.getArea ([|".........."; ".S------7."; ".|F----7|."; ".||OOOO||."; ".||OOOO||."; ".|L-7F-J|."; ".|II||II|."; ".L--JL--J."; ".........."|]))

    [<Test>]
    member this.GetArea3() = Assert.AreEqual(8, Day10Part2.getArea ([|".F----7F7F7F7F-7...."; ".|F--7||||||||FJ...."; ".||.FJ||||||||L7...."; "FJL7L7LJLJ||LJ.L-7.."; "L--J.L7...LJS7F-7L7."; "....F-J..F7FJ|L7L7L7"; "....L7.F7||L7|.L7L7|"; ".....|FJLJ|FJ|F7|.LJ"; "....FJL-7.||.||||..."; "....L---J.LJ.LJLJ..."|]))

    [<Test>]
    member this.GetArea4() = Assert.AreEqual(10, Day10Part2.getArea ([|"FF7FSF7F7F7F7F7F---7"; "L|LJ||||||||||||F--J"; "FL-7LJLJ||||||LJL-77"; "F--JF--7||LJLJ7F7FJ-"; "L---JF-JLJ.||-FJLJJ7"; "|F|F-JF---7F7-L7L|7|"; "|FFJF7L7F-JF7|JL---7"; "7-L-JL7||F7|L7F-7F7|"; "L.L7LFJ|||||FJL7||LJ"; "L7JLJL-JLJLJL--JLJ.L"|]))