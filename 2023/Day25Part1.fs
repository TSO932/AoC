namespace _2023

open System

module Day25Part1 =

    let getEdges (input: seq<string>) =

        let parseLine (line: string) =

            let lineVals = line.Replace(":", "").Split ' '

            let fromVal = Seq.head lineVals

            lineVals |> Seq.tail |> Seq.map (fun toVal -> (fromVal, toVal))

        input |> Seq.map parseLine |> Seq.concat

    let getEdgesToDisconnect (edges: seq<string * string>, minEdges) =

        let edgeList = edges |> Seq.map (fun a -> (a, a)) |> Seq.toList

        let ramdomNumberGenerator = Random()

        let rec contractEdges (remainingEdges, removedEdges, vertexIdentifier) =

            let finalVertices =
                remainingEdges
                |> List.map snd
                |> List.map (fun (a, b) -> [ a; b ])
                |> List.concat
                |> List.distinct

            if List.length finalVertices = 2 then

                let finalEdges =
                    remainingEdges
                    |> List.filter (fun (_, (a, b)) ->
                        (a = finalVertices[0] && b = finalVertices[1])
                        || (a = finalVertices[1] && b = finalVertices[0]))
                    |> List.map fst

                if List.length finalEdges > minEdges then
                    contractEdges (edgeList, [], 0)
                else
                    finalEdges

            else
                let maxIdx = Seq.length remainingEdges - 1
                let idx = ramdomNumberGenerator.Next(maxIdx + 1)

                let removedEdge = remainingEdges[idx]
                let oldVertex1 = fst (snd removedEdge)
                let oldVertex2 = snd (snd removedEdge)
                let mergedVertex = vertexIdentifier.ToString()

                let updateEdge (e) =
                    let updateEdgeVertex (v) =
                        (if v = oldVertex1 || v = oldVertex2 then mergedVertex else v)

                    (fst e, (updateEdgeVertex (fst (snd e)), updateEdgeVertex (snd (snd e))))

                let stillRemainingEdges = remainingEdges |> List.removeAt idx |> List.map updateEdge

                contractEdges (stillRemainingEdges, List.append [ fst removedEdge ] removedEdges, vertexIdentifier + 1)

        contractEdges (edgeList, [], 0) |> List.toSeq


    let getProductOfSums (edges: seq<string * string>, edgesToDisconnect: seq<string * string>) =

        let (seed1, seed2) = Seq.head edgesToDisconnect

        let edgesToDisconnectBiDi =
            (edgesToDisconnect, edgesToDisconnect |> Seq.map (fun (a, b) -> (b, a)))
            ||> Seq.append
            |> Seq.toList

        let initialEdgesToCheck =
            edges
            |> Seq.toList
            |> List.filter (fun e -> not (List.contains e edgesToDisconnectBiDi))

        let rec findGroup
            (verticesInGroup: list<string>, edgesToCheck: list<string * string>, newVerticesToCheck: list<string>)
            =

            let checkMatch (a, b) =
                newVerticesToCheck |> List.exists (fun v -> v = a || v = b)

            let newEdges = edgesToCheck |> List.filter checkMatch

            let newVertices =
                newEdges
                |> List.map (fun (a, b) -> [ a; b ])
                |> List.concat
                |> List.append verticesInGroup
                |> List.distinct

            if List.length newVertices = List.length verticesInGroup then
                List.length verticesInGroup
            else
                let remainingEdges =
                    edgesToCheck |> List.filter (fun e -> not (List.contains e newEdges))

                findGroup (newVertices, remainingEdges, newVertices)

        let findGroupInit (seed: string) =
            findGroup ([ seed ], initialEdgesToCheck, [ seed ])

        let group1 = findGroupInit (seed1)
        let group2 = findGroupInit (seed2)

        group1 * group2

    let getResult (input: seq<string>) =

        let allEdges = getEdges input
        let disconnectedEdges = getEdgesToDisconnect (allEdges, 3)
        getProductOfSums (allEdges, disconnectedEdges)

