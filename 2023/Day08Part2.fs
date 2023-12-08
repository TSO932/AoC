namespace _2023

module Day08Part2 =

    let countSteps (input:seq<string>) =

        let path = 
            input
            |> Seq.head
            |> Seq.toArray
        
        let mapEntries =
            input
            |> Seq.tail
            |> Seq.tail

        let startingNodes =
            mapEntries
            |> Seq.filter (fun m -> m[2] = 'A')
            |> Seq.map (fun m -> m[..2]) 

        let left =
            mapEntries
            |> Seq.map (fun s -> (s[..2], s[7..9]))
            |> Map

        let right =
            mapEntries
            |> Seq.map (fun s -> (s[..2], s[12..14]))
            |> Map

        let rec counter (route, node:string, i) =
            if node[2] = 'Z' then
                i
            else
                let newRoute = 
                    if Array.isEmpty route then
                        path
                    else
                        route

                let nextNode = 
                    match Array.head newRoute with
                        | 'L' -> left[node]
                        | _ -> right[node]

                counter (Array.tail newRoute, nextNode, i + 1)

        startingNodes
        |> Seq.map (fun node -> counter ([||], node, 0))
        |> Seq.iter (fun n -> printfn "%i" n)

        0

                


