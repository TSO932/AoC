namespace AoC2020

open System.Collections.Generic

module Day15Part1 =
    let playMemoryGame (startingNumbers:seq<int>) =


        let isDebug = false
        
        let elvesMemory = new Dictionary<int, int>()

        let mutable roundNumber = 1
        let mutable lastSpokenNumber = -1

        let speak(numberToSay:int) =
 
            elvesMemory.Remove(lastSpokenNumber) |> ignore
            elvesMemory.Add(lastSpokenNumber, roundNumber)
            lastSpokenNumber <- numberToSay
            
            if isDebug then
                printfn "round %i number %i" roundNumber numberToSay
            
            roundNumber <- roundNumber + 1

        for number in startingNumbers do 
                speak number

        while roundNumber <= 2020 do
            let (hasBeenSpokenBefore, turnWhenLastSpoken) = elvesMemory.TryGetValue(lastSpokenNumber)
            speak (if hasBeenSpokenBefore then roundNumber - turnWhenLastSpoken else 0)

        lastSpokenNumber

    let getStartingNumbers(input:seq<string>) =
        (input |> Array.ofSeq |> Array.head).Split ',' |> Seq.map int