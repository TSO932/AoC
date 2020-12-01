let rec runSimulation(positions) =

    let xOnly = fun (x, _, _) -> (x, 0)  // x 231614
    let yOnly = fun (_, y, _) -> (y, 0)  // y  96236
    let zOnly = fun (_, _, z) -> (z, 0)  // z 193052

    let startingMoons = positions |> List.map (zOnly)

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

//printfn "%i" (runSimulation([(-1, 0, 2); (2, -10, -7); (4, -8, 8); (3, 5, -1)]))
//printfn "%i" (runSimulation([(-8, -10, 0); (5, 5, 10); (2, -7, 3); (9, -8, -3)]))
printfn "%i" (runSimulation([(17, -9, 4); (2, 2, -13); (-1, 5, -1); (4, 7, -7)]))
