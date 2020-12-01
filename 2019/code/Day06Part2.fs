namespace AoC2019

module Day06Part2 =
    
    let getShortestTransfer(inputString) =
        let isTest = false

        let mapOfTheStars = Day06Part1.mapOfTheStars inputString

        let rec setOfOrbits(spaceObject) =
            if spaceObject = "COM" then
                Set.empty
            else
                setOfOrbits(mapOfTheStars.[spaceObject]).Add(mapOfTheStars.[spaceObject])

        let rec countOrbits(spaceObject, targetObject) =
            if spaceObject = targetObject then
                0
            else
                countOrbits(mapOfTheStars.[spaceObject], targetObject) + 1

        if isTest then
            printfn "%A" (setOfOrbits("YOU"))
            printfn "%A" (setOfOrbits("SAN"))

        (Set.intersect (setOfOrbits("YOU")) (setOfOrbits("SAN")) |> Set.map (fun x -> countOrbits("YOU", x) + countOrbits("SAN", x)) |> Set.minElement) - 2
