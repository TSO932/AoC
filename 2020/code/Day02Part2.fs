namespace AoC2020

open System

module Day02Part2 =

    let checkPasswords (passwordsToCheck:seq<string>) =
        let checkPassword(inputLine:string) =
            let split = inputLine.Split([|"-"; " "; ":"|], StringSplitOptions.RemoveEmptyEntries)
            let charToCheck = split.[2].[0]
            let charA = split.[3].[int split.[0] - 1]
            let charB = split.[3].[int split.[1] - 1]
               
            (charA = charToCheck) <> (charB = charToCheck)
                
        passwordsToCheck |> Seq.map checkPassword |> Seq.filter ((=) true) |> Seq.length