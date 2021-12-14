namespace AoC2021

module Day12Part2 =
    
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
                |> Seq.sort
                |> Seq.rev
                |> ( fun sc -> Seq.head sc <= 2 && if Seq.length sc > 1 then sc |> Seq.tail |> Seq.max <= 1 else true )

                && smallCaves |> Seq.filter ((=) "start") |> Seq.length <= 1

        let newRoutes = routes |> Seq.map (fun x -> extendRoute(x)) |> Seq.concat |> Seq.filter isValid

        if Seq.length newRoutes = Seq.length routes then
            routes
        else
            generateRoutes(connections, newRoutes)

    let getRoutes(connections:Map<string,seq<string>>) =
        generateRoutes(connections, [["start"]]) |> Seq.filter (fun x -> (Seq.head x) = "end") |> Seq.length
    
    let run(input:seq<string>) =
        getRoutes(Day12Part1.parseCaveConnections(input))
