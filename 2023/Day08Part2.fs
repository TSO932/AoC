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
        
        let isEnd (nodes:seq<string>) =
            nodes
            |> Seq.filter (fun m -> m[2] <> 'Z')
            |> Seq.isEmpty 

        let left =
            mapEntries
            |> Seq.map (fun s -> (s[..2], s[7..9]))
            |> Map

        let right =
            mapEntries
            |> Seq.map (fun s -> (s[..2], s[12..14]))
            |> Map

        let rec counter (route, nodes:seq<string>, i) =
    
            if isEnd nodes then
                i
            else
                let newRoute = 
                    if Array.isEmpty route then
                        path
                    else
                        route

                let nextNode (node) =
                    match Array.head newRoute with
                        | 'L' -> left[node]
                        | _ -> right[node]

                let nextNodes =
                    nodes
                    |> Seq.map (fun s -> nextNode s)

                counter (Array.tail newRoute, nextNodes, i + 1)

        counter ([||], startingNodes, 0)

                


