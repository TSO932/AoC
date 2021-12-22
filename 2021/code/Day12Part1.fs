namespace AoC2021

module Day12Part1 =
    let parseCaveConnections(input:seq<string>) =

        let moves = input |> Seq.map (fun s -> s.Split '-')
        let forwardMoves  = moves |> Seq.filter (fun x -> Seq.head x <> "end") 
        let backwardMoves = moves |> Seq.filter (fun x -> Seq.head x <> "start") |> Seq.map Array.rev |> Seq.filter (fun x -> Seq.head x <> "end") 

        [forwardMoves; backwardMoves]
        |> Seq.concat
        |> Seq.groupBy Seq.head
        |> Seq.map ( fun pair -> fst pair, snd pair |> Seq.map (Seq.tail >> Seq.exactlyOne) )
        |> Map.ofSeq
    
    let rec generateRoutes(connections:Map<string,seq<string>>, routes:seq<seq<string>>) =
        
        let extendRoute(route:seq<string>) =   
            match connections.TryFind (Seq.head route) with
            | Some caves -> caves|> Seq.map ( fun b -> Seq.concat [seq {b}; route] )
            | None -> seq { route }
                
        let isValid(route:seq<string>) =
            let smallCaves =
                route
                |> Seq.filter (fun c -> int c[0] > 90) //starts with a lowercase letter

            if Seq.length smallCaves = 0 then
                true
            else
                smallCaves
                |> Seq.groupBy id
                |> Seq.map (fun x -> snd x |> Seq.length)
                |> Seq.max <= 1

        let newRoutes = routes |> Seq.map (fun x -> extendRoute(x)) |> Seq.concat |> Seq.filter isValid

        if Seq.length newRoutes = Seq.length routes then
            routes
        else
            generateRoutes(connections, newRoutes)

    let getRoutes(connections:Map<string,seq<string>>) =
        generateRoutes(connections, [["start"]]) |> Seq.filter (fun x -> (Seq.head x) = "end") |> Seq.length
    
    let run(input:seq<string>) =
        getRoutes(parseCaveConnections(input))
