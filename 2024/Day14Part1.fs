namespace _2024

open System

module Day14Part1 =

    let mutable width = 11
    let mutable height = 7
    let mutable runCount = 100

    let parseLine(inputLine:string) =
        
        inputLine.Replace("p=", "").Replace(" v=", ",").Split ","
        |> Seq.map Int32.Parse
        |> Seq.toArray

    let move(robot:array<int>) =
        
        let newPos(pos, length) =
            if pos < 0 then
                length + pos 
            elif pos >= length then
                pos - length
            else
                pos

        [|newPos(robot[0] + robot[2], width); newPos(robot[1] + robot[3], height); robot[2]; robot[3]|]

    let repeatsAt(robot:array<int>) =

        let rec repeater(count:int, robot2:array<int>) =
            if count > 0 && robot = robot2 then
                count
            else
                repeater(count + 1, move robot2)

        repeater (0, robot)

    let moveToEnd(robot:array<int>) =

        let repeatFrequency = repeatsAt robot 

        runCount % repeatFrequency
        |> Array.zeroCreate
        |> Array.fold (fun r _ -> move r) robot

    let moveToEnd2(robot:array<int>) =

        move [|robot[0]; robot[1]; (robot[2] * runCount) % width; (robot[3] * runCount) % height|]

    let assignQuadrant(robot:array<int>) =

        let middleWidth = width / 2
        let middleHeight = height / 2

        if robot[0] = middleWidth || robot[1] = middleHeight then
            "X"
        else
            if robot[0] < middleWidth then
                if robot[1] < middleHeight then
                    "UL"
                else
                    "LL"
            else
                if robot[1] < middleHeight then
                    "UR"
                else
                    "LR"

    let runInternal(input:seq<string>) =

        input
        |> Seq.map (parseLine >> moveToEnd2 >> assignQuadrant)
        |> Seq.filter ((<>) "X")
        |> Seq.countBy id
        |> Seq.fold (fun acc (_, x) -> acc * x) 1

    let runTest(input:seq<string>) = runInternal input

    let run(input:seq<string>) =

        let mutable width = 101
        let mutable height = 103
        runInternal input