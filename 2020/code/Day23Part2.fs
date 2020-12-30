namespace AoC2020

open System
open System.Collections.Generic

module Day23Part2 =

    let rotateCircle(currentPosition:int, cupCircle:int[]) = 
        Array.append cupCircle.[currentPosition..(cupCircle.Length - 1)] cupCircle.[0..(currentPosition - 1)] 

    let rotateCircleByOne(cupCircle:int[]) = rotateCircle(1, cupCircle) 

    let getCircleOfCups(cupString:string) =
        let start = cupString |> Array.ofSeq |> Array.map (string >> int)
        let circle = Array.append start (seq {(start.Length + 1)..1000000} |> Array.ofSeq)

        let rotatedCircle = rotateCircleByOne(circle) 
        let cupMap = new Dictionary<int, int>()
        circle |> Array.iteri (fun i x -> cupMap.Add(x, rotatedCircle.[i]))

        circle

    let getDestinationPosition(cupCircle:int[]) =

        let circleWithoutCupsToMove = Array.append cupCircle.[0..0] cupCircle.[4..(cupCircle.Length - 1)]
        
        let lowerValuesOrWrap =
            let lowerValues = circleWithoutCupsToMove |> Array.filter ((>) cupCircle.[0])
            if Array.isEmpty lowerValues then circleWithoutCupsToMove else lowerValues
         
        Array.IndexOf(circleWithoutCupsToMove, lowerValuesOrWrap |> Array.maxBy (id)) + 3

    let cutAndShunt(cupCircle:int[]) =
        let destinationPosition = getDestinationPosition(cupCircle)

        Array.append
            (Array.append
                (Array.append
                    cupCircle.[0..0]
                    cupCircle.[4..destinationPosition])
                    cupCircle.[1..3])
                    cupCircle.[(destinationPosition + 1)..(cupCircle.Length - 1)]

    let rec play(itterations:int, cupCircle:int[]) =
        if itterations = 0 then
            let positionOfOne = Array.IndexOf(cupCircle, 1)
            let findPosition(relativePosition:int) =
                let newPosition = positionOfOne + relativePosition
                if newPosition < cupCircle.Length then
                    newPosition
                else
                    newPosition - cupCircle.Length 

            int64(cupCircle.[findPosition(1)]) * int64(cupCircle.[findPosition(2)]) 
        else
            play(itterations - 1, rotateCircleByOne(cutAndShunt(cupCircle)))

    let playGame (inputData:seq<string>) =
        // play(10000000, getCircleOfCups((Array.ofSeq inputData).[0]))
        play(10000, getCircleOfCups((Array.ofSeq inputData).[0]))
