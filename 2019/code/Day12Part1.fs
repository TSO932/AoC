namespace AoC2019

open System

module Day12Part1 =
    let runSimulation(positions, itterations) =

        let mutable moons = positions |> List.map (fun p -> (p, (0, 0, 0)))

        let applyGravity(moon) =
            let gravityPair((x0:int, y0:int, z0:int), (x1:int, y1:int, z1:int)) =
                    (x1.CompareTo x0, y1.CompareTo y0, z1.CompareTo z0)

            let sumUp((x0, y0, z0), (x1, y1, z1)) = (x0 + x1, y0 + y1, z0 + z1)
        
            let velocity = moons |> List.map (fun m -> gravityPair(fst moon, fst m)) |>  List.fold (fun mm m -> sumUp(mm, m)) (snd moon)
            let position = sumUp(fst moon, velocity)
        
            (position, velocity)

        for i in [1 .. itterations] do
            moons <- moons |> List.map applyGravity

        let calcEnergy((x0, y0, z0), (x1, y1, z1)) =
            (abs x0 + abs y0 + abs z0) * (abs x1 + abs y1 + abs z1)

        List.sumBy calcEnergy moons


    let readCoordinates(inputlines:seq<string>) = 
        let split(inputline:string) =
            let splitLine = inputline.Split([|"<x="; ", y="; ", z="; ">"|], StringSplitOptions.RemoveEmptyEntries)
            (int splitLine.[0], int splitLine.[1], int splitLine.[2])

        inputlines |> Seq.map split |> List.ofSeq