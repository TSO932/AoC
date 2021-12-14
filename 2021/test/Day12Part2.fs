namespace AoC2021.Tests

open NUnit.Framework
open AoC2021

[<TestFixture>] 
type Day12Part2 () =

    [<Test>]
    member _.Example1() =
        let connections = Day12Part1.parseCaveConnections [| "start-A"; "start-b"; "b-d"; "b-end"; "A-c"; "A-b"; "A-end" |]
        let result = Day12Part2.getRoutes(connections)
        Assert.AreEqual(36,  result)

    [<Test>]
    member _.Example2() =
        let connections = Day12Part1.parseCaveConnections [| "dc-end"; "HN-start"; "start-kj"; "dc-start"; "dc-HN"; "LN-dc"; "HN-end"; "kj-sa"; "kj-HN"; "kj-dc" |]
        let result = Day12Part2.getRoutes(connections)
        Assert.AreEqual(103,  result)

    [<Test>]
    member _.Example3() =
        let connections = Day12Part1.parseCaveConnections [| "fs-end"; "he-DX"; "fs-he"; "start-DX"; "pj-DX"; "end-zg"; "zg-sl"; "zg-pj"; "pj-he";
                 "RW-he"; "fs-DX"; "pj-RW"; "zg-RW"; "start-pj"; "he-WI"; "zg-he"; "pj-fs"; "start-RW" |]
        let result = Day12Part2.getRoutes(connections)
        Assert.AreEqual(3509,  result)



