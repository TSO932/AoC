
let runSimulation(positions, itterations) =

    let mutable moons = positions |> List.map (fun p -> (p, (0, 0, 0)))

    let gravityPair((x0, y0, z0), (x1, y1, z1)) =

        let comp(i, j) =
            if   i > j then -1
            elif i < j then  1
            else 0

        (comp(x0, x1), comp(y0, y1), comp(z0, z1))

    let applyGravity(moon) =
        let sumUp((x0, y0, z0), (x1, y1, z1)) = (x0 + x1, y0 + y1, z0 + z1)
    
        let velocity = moons |> List.map (fun m -> gravityPair(fst moon, fst m)) |>  List.fold (fun mm m -> sumUp(mm, m)) (snd moon)
        let position = sumUp(fst moon, velocity)
    
        (position, velocity)

    for i in [1 .. itterations] do
        moons <- moons |> List.map applyGravity

    let calcEnergy((x0, y0, z0), (x1, y1, z1)) =
        (abs x0 + abs y0 + abs z0) * (abs x1 + abs y1 + abs z1)

    List.sumBy calcEnergy moons

printfn "%i" (runSimulation([(-1, 0, 2); (2, -10, -7); (4, -8, 8); (3, 5, -1)], 10))
printfn "%i" (runSimulation([(-8, -10, 0); (5, 5, 10); (2, -7, 3); (9, -8, -3)], 100))
printfn "%i" (runSimulation([(17, -9, 4); (2, 2, -13); (-1, 5, -1); (4, 7, -7)], 1000))

