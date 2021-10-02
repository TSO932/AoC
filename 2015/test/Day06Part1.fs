namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day06Part1 () =

    [<DefaultValue>] val mutable initialGrid : bool[,]

    [<SetUp>]
    member this.SetUp() =
        this.initialGrid <- Array2D.create 1000 1000 false

    [<Test>]
    member this.Initial() = Assert.AreEqual(0, Day06Part1.countOnLights this.initialGrid)

    [<Test>]
    member _.ParseExample1() = Assert.AreEqual({Day06Part1.op = "on" ; Day06Part1.x1 = 0 ; Day06Part1.y1 = 0 ; Day06Part1.x2 = 999 ; Day06Part1.y2 = 999}, Day06Part1.parseInstruction "turn on 0,0 through 999,999")
    
    [<Test>]
    member _.ParseExample2() = Assert.AreEqual({Day06Part1.op = "e" ; Day06Part1.x1 = 0 ; Day06Part1.y1 = 0 ; Day06Part1.x2 = 999 ; Day06Part1.y2 = 0}, Day06Part1.parseInstruction "toggle 0,0 through 999,0")

    [<Test>]
    member _.ParseExample3() = Assert.AreEqual({Day06Part1.op = "off" ; Day06Part1.x1 = 499 ; Day06Part1.y1 = 499 ; Day06Part1.x2 = 500 ; Day06Part1.y2 = 500}, Day06Part1.parseInstruction "turn off 499,499 through 500,500")

    [<Test>]
    member this.DoExample1() = Assert.AreEqual(1000000, Day06Part1.switch (Day06Part1.parseInstruction "turn on 0,0 through 999,999") this.initialGrid |> Day06Part1.countOnLights)

    [<Test>]
    member this.DoExample2() = Assert.AreEqual(1000, Day06Part1.switch (Day06Part1.parseInstruction "toggle 0,0 through 999,0") this.initialGrid |> Day06Part1.countOnLights)

    [<Test>]
    member this.DoExample3() = Assert.AreEqual(0, Day06Part1.switch (Day06Part1.parseInstruction "turn off 499,499 through 500,500") this.initialGrid |> Day06Part1.countOnLights)


    [<Test>]
    member _.DoReverseExample1() = Assert.AreEqual(1000000, Day06Part1.switch (Day06Part1.parseInstruction "turn on 0,0 through 999,999") (Array2D.create 1000 1000 true) |> Day06Part1.countOnLights)

    [<Test>]
    member _.DoReverseExample2() = Assert.AreEqual(999000, Day06Part1.switch (Day06Part1.parseInstruction "toggle 0,0 through 999,0") (Array2D.create 1000 1000 true) |> Day06Part1.countOnLights)

    [<Test>]
    member _.DoReverseExample3() = Assert.AreEqual(999996, Day06Part1.switch (Day06Part1.parseInstruction "turn off 499,499 through 500,500") (Array2D.create 1000 1000 true) |> Day06Part1.countOnLights)

    [<Test>]
    member this.FollowInstructions() = Assert.AreEqual(998996, Day06Part1.followInstructions ([|"turn on 0,0 through 999,999"; "toggle 0,0 through 999,0"; "turn off 499,499 through 500,500"|]))