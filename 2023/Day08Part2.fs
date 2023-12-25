namespace _2023

module Day08Part2 =

    let leastCommonMultiple(input:seq<int64>) =
        let rec gcd (x:int64) (y:int64) = if y = 0 then abs x else gcd y (x % y)
        let lcm (x:int64) (y:int64) = x * y / (gcd x y)

        input
        |> Seq.fold (fun mult x -> lcm mult x) 1L

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
        |> Seq.map (fun node -> counter (Array.empty, node, 0))
        |> Seq.map int64
        |> leastCommonMultiple



                


