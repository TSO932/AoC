namespace AoC2020

open System

module Day02Part1 =
    let checkPasswords (passwordsToCheck:seq<string>) =

        let checkPassword(inputLine:string) =
            let split = inputLine.Split([|"-"; " "; ":"|], StringSplitOptions.RemoveEmptyEntries)
            let minCount = int split.[0] 
            let maxCount = int split.[1]
            let charToCheck = split.[2].[0]
            let passwordString = split.[3]
           
            let matchCount = passwordString |> Seq.toList |> List.filter ((=) charToCheck) |> Seq.length
           
            matchCount >= minCount && matchCount <= maxCount
            
        passwordsToCheck |> Seq.map checkPassword |> Seq.filter ((=) true) |> Seq.length
