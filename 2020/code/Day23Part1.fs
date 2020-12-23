namespace AoC2020

open System

module Day23Part1 =


    let getCircleOfCups(cupString:string) =
        cupString |> Array.ofSeq |> Array.map (string >> int)

    let getDestinationPosition(cupCircle:int[]) =

        let circleWithoutCupsToMove = Array.append cupCircle.[0..0] cupCircle.[4..(Array.length cupCircle - 1)]
        
        let lowerValuesOrWrap =
            let lowerValues = circleWithoutCupsToMove |> Array.filter ((>) cupCircle.[0])
            if Array.isEmpty lowerValues then circleWithoutCupsToMove else lowerValues
         
        Array.IndexOf(circleWithoutCupsToMove, lowerValuesOrWrap |> Array.maxBy (id)) + 3

    let rotateCircle(currentPosition:int, cupCircle:int[]) = 
        Array.append cupCircle.[currentPosition..(Array.length cupCircle - 1)] cupCircle.[0..(currentPosition - 1)] 

    let rotateCircleByOne(cupCircle:int[]) = rotateCircle(1, cupCircle) 

    let cutAndShunt(cupCircle:int[]) =
        let destinationPosition = getDestinationPosition(cupCircle)

        Array.append
            (Array.append
                (Array.append
                    cupCircle.[0..0]
                    cupCircle.[4..destinationPosition])
                    cupCircle.[1..3])
                    cupCircle.[(destinationPosition + 1)..(Array.length cupCircle - 1)]

    let rec play(itterations:int, cupCircle:int[]) =
        if itterations = 0 then
            cupCircle
        else
            play(itterations - 1, rotateCircleByOne(cutAndShunt(cupCircle)))

    let playGame (inputData:seq<string>) =
        play(100, getCircleOfCups((Array.ofSeq inputData).[0]))
