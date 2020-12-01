namespace AoC2019

module Day06Part1 =
    
    let mapOfTheStars(input:seq<string>) = 
        input |> Array.ofSeq |> Array.map (fun binaryPair -> binaryPair.Split ')') |> Array.map (fun x -> (x.[1], x.[0])) |> Map.ofSeq

    let rec countOrbits(spaceObject, map:Map<string,string>) =
        if spaceObject = "COM" then
            0
        else countOrbits(map.[spaceObject], map) + 1

    let getTotalOrbitCount (input:seq<string>) =
            let map = mapOfTheStars input
            map |> Map.toSeq |> Seq.map (fun x -> countOrbits ((fst x), map)) |> Seq.sum
