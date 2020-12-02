namespace AoC2019

module Day12Part2 =
    let runSimulation(positions, dimension) =

        let startingMoons = positions |> List.map (dimension)

        let rec findRepeatingState(moons, itteration) =
            
            let applyGravity(moon) =
                let comparePair(p0:int, p1:int) = p1.CompareTo p0
                let velocity = moons |> List.map (fun m -> comparePair(fst moon, fst m)) |>  List.fold (fun mm m -> mm + m) (snd moon)
                let position = fst moon + velocity
        
                (position, velocity)
              
            if itteration > 0L && moons = startingMoons then
                itteration
            else
                findRepeatingState(moons |> List.map applyGravity, itteration + 1L)
        
        findRepeatingState(startingMoons, 0L)

    let runSimulationThrice(positions) =
        let xOnly = fun (x, _, _) -> (x, 0)
        let yOnly = fun (_, y, _) -> (y, 0)
        let zOnly = fun (_, _, z) -> (z, 0)

        (runSimulation(positions, xOnly), runSimulation(positions, yOnly), runSimulation(positions, zOnly))