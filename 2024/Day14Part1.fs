namespace _2024

open System

module Day14Part1 =

    type BoardType =
    | Test = 0
    | Live = 1
    
    type Board(bt:BoardType) =
        
        let width =
            if bt = BoardType.Test then
                11
            else
                101

        let height =
            if bt = BoardType.Test then
                7
            else
                103

        member this.Width with get() = width
        member this.Height with get() = height
        member this.RunCount with get() = 100          

    let parseLine(inputLine:string) =
        
        inputLine.Replace("p=", "").Replace(" v=", ",").Split ","
        |> Seq.map Int32.Parse
        |> Seq.toArray

    let move(b:Board, robot:array<int>) =
        
        let newPos(pos, length) =
            if pos < 0 then
                length + pos 
            elif pos >= length then
                pos - length
            else
                pos

        [|newPos(robot[0] + robot[2], b.Width); newPos(robot[1] + robot[3], b.Height); robot[2]; robot[3]|]

    let moveToEnd(b:Board, robot:array<int>) =

        move (b, [|robot[0]; robot[1]; (robot[2] * b.RunCount) % b.Width; (robot[3] * b.RunCount) % b.Height|])

    let assignQuadrant(b:Board, robot:array<int>) =

        let middleWidth = b.Width / 2
        let middleHeight = b.Height / 2

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

    let runInternal(b:Board, input:seq<string>) =

        let move(robot) = moveToEnd(b, robot)
        let assign(robot) = assignQuadrant(b, robot)

        input
        |> Seq.map (parseLine >> move >> assign)
        |> Seq.filter ((<>) "X")
        |> Seq.countBy id
        |> Seq.fold (fun acc (_, x) -> acc * x) 1

    let runTest(input:seq<string>) = runInternal (Board(BoardType.Test), input)
    let run(input:seq<string>) =  runInternal (Board(BoardType.Live), input)