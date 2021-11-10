namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day12Part2 () =

    [<Test>]
    member _.Example1() = Assert.AreEqual(6, Day12Part2.sumNumbers ("{\"a\":[1,2,3]}"))

    [<Test>]
    member _.Example2() = Assert.AreEqual(4, Day12Part2.sumNumbers ("{\"a\":[1,{\"c\":\"red\",\"b\":2},3]}"))

    [<Test>]
    member _.Example3() = Assert.AreEqual(0, Day12Part2.sumNumbers ("{\"a\":{\"d\":\"red\",\"e\":[1,2,3,4],\"f\":5}}"))

    [<Test>]
    member _.Example4() = Assert.AreEqual(6, Day12Part2.sumNumbers ("{\"a\":[1,\"red\",5]}"))
    
    [<Test>]
    member _.InnerObject() = Assert.AreEqual(8, Day12Part2.sumNumbers ("{\"a\":{\"aa\":\"red\",\"ab\":7},\"b\":{\"ba\":\"green\",\"ab\":8}}"))

    [<Test>]
    member _.ObjectWithArrays1() = Assert.AreEqual(29, Day12Part2.sumNumbers ("{\"a\":{\"aa\":[1,\"blue\",2],\"ab\":[3,\"red\",5],\"ac\":[7,\"green\",11]}}"))

    [<Test>]
    member _.ObjectWithArrays2() = Assert.AreEqual(21, Day12Part2.sumNumbers ("{\"a\":{\"aa\":[1,\"blue\",2],\"ab\":{\"aba\":3,\"abb\":\"red\",\"abc\":5},\"ac\":[7,\"green\",11]}}"))

    [<Test>]
    member _.NestedReds1() = Assert.AreEqual(1, Day12Part2.sumNumbers ("{\"a\":{\"aa\":\"red\",\"ab\":{\"aba\":\"red\",\"abb\":3},\"ac\":4},\"b\":1}"))

    [<Test>]
    member _.NestedReds2() = Assert.AreEqual(1, Day12Part2.sumNumbers ("{\"a\":{\"aa\":{\"aaa\":\"red\",\"aab\":3},\"ab\":\"red\",\"ac\":4},\"b\":1}"))

    [<Test>]
    member _.ObjectInArray() = Assert.AreEqual(9, Day12Part2.sumNumbers ("{\"a\":[1,{\"aa\":3},5]}"))
