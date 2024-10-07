namespace AoC2017

module Day07Part1 =

    let parse (input: seq<string>) =

        let parseLine (line: string) =
            line
                .Replace("(", "")
                .Replace(")", "")
                .Replace(",", "")
                .Replace(" -> ", " ")
                .Split
                " "
            |> Seq.toList

        input
        |> Seq.map parseLine
        |> Seq.map (fun p -> (List.head p, List.tail (List.tail p)))
        |> Seq.toList

    let removeTops (towerLinks: list<string * list<string>>) =

        let tops =
            towerLinks
            |> List.filter (fun (_, s) -> List.isEmpty s)
            |> List.map fst

        let remaining =
            towerLinks
            |> List.filter (fun (_, s) -> not (List.isEmpty s))
            |> List.map (fun (p, s) -> (p, s |> List.filter (fun q -> not (List.contains q tops))))

        remaining

    let rec findBase (towerLinks: list<string * list<string>>) =

        if List.length towerLinks = 1 then
            towerLinks
            |> List.head
            |> fst

        else
            findBase (removeTops towerLinks)


    let getBase (input: seq<string>) =

        input |> parse |> findBase