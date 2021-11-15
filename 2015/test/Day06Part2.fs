namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day06Part2 () =

    [<DefaultValue>] val mutable initialGrid : int[,]

    [<SetUp>]
    member this.SetUp() =
        this.initialGrid <- Array2D.create 1000 1000 0

    [<Test>]
    member this.DoExample1() = Assert.AreEqual(1000000, Day06Part2.switch (Day06Part2.parseInstruction "turn on 0,0 through 999,999") this.initialGrid |> Day06Part2.countOnLights)

    [<Test>]
    member this.DoExample2() = Assert.AreEqual(2000, Day06Part2.switch (Day06Part2.parseInstruction "toggle 0,0 through 999,0") this.initialGrid |> Day06Part2.countOnLights)

    [<Test>]
    member this.DoExample3() = Assert.AreEqual(0, Day06Part2.switch (Day06Part2.parseInstruction "turn off 499,499 through 500,500") this.initialGrid |> Day06Part2.countOnLights)


    [<Test>]
    member _.DoReverseExample1() = Assert.AreEqual(2000000, Day06Part2.switch (Day06Part2.parseInstruction "turn on 0,0 through 999,999") (Array2D.create 1000 1000 1) |> Day06Part2.countOnLights)

    [<Test>]
    member _.DoReverseExample2() = Assert.AreEqual(1002000, Day06Part2.switch (Day06Part2.parseInstruction "toggle 0,0 through 999,0") (Array2D.create 1000 1000 1) |> Day06Part2.countOnLights)

    [<Test>]
    member _.DoReverseExample3() = Assert.AreEqual(999996, Day06Part2.switch (Day06Part2.parseInstruction "turn off 499,499 through 500,500") (Array2D.create 1000 1000 1) |> Day06Part2.countOnLights)

    [<Test>]
    member this.FollowInstructions() = Assert.AreEqual(1001996, Day06Part2.followInstructions ([|"turn on 0,0 through 999,999"; "toggle 0,0 through 999,0"; "turn off 499,499 through 500,500"|]))