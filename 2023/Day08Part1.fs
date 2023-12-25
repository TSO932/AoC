namespace _2023

module Day08Part1 =

    let countSteps (input:seq<string>) =
        let path = Seq.head input |> Seq.toArray
        let mapEntries = input |> Seq.tail |> Seq.tail

        let left =
            mapEntries
            |> Seq.map (fun s -> (s[..2], s[7..9]))
            |> Map


        let right =
            mapEntries
            |> Seq.map (fun s -> (s[..2], s[12..14]))
            |> Map

        let rec counter (route, node, i) =
            if node = "ZZZ" then
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

        counter (Array.empty, "AAA", 0)

                


