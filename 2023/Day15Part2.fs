namespace _2023

open System

module Day15Part2 =

    let getType (input: string) =
        
        let len = String.length input
        let box label = Day15Part1.runAlgoritm label

        if input.Contains "-" then
            let label = input.Substring(0, len - 1)
            (box label, label, None)
        else
            let label = input.Substring(0, len - 2)
            let focal = int (input.Substring(len - 1, 1))
            (box label, label, Some focal)

    let moveNonesToEnd(box:(string*int) option[]) =
        Array.append (Array.filter ((<>) None) box) (Array.filter ((=) None) box)

    let applyStep(box:(string*int) option[], step:(string*(int option))) =
        
        let label = fst step

        let exposeLabels(box:(string*int) option[]) =
            box
            |> Array.map (fun o -> match o with
                                    | None -> String.Empty
                                    | Some a -> fst a)


        let labels = exposeLabels box

        if (snd step).IsSome then
            let focalLength = (snd step).Value

            match Array.tryFindIndex ((=) label) labels with
            | None ->
                let firstEmptySlot = Array.findIndex ((=) String.Empty) labels
                Array.concat [| box[..firstEmptySlot - 1]; [|Some (label, focalLength)|]; box[firstEmptySlot + 1 ..] |]
            | Some x ->
                Array.concat [| box[..x - 1]; [|Some (label, focalLength)|]; box[x + 1 ..] |]
        else
            match Array.tryFindIndex ((=) label) labels with
            | None ->
                box
            | Some x ->
                [| box[..x - 1]; [|None|]; box[x + 1 ..] |]
                |> Array.concat
                |> moveNonesToEnd

    let applySteps(steps:seq<(string*(int option))>) =
        steps
        |> Seq.fold (fun a x -> applyStep (a, x)) [|None; None; None; None; None; None; None; None; None; None|]

    let sumBox(box:(string*int) option[]) =

        let getFocalLength(input:(string*int) option) =
            match input with
            | None -> 0
            | Some a -> snd a

        box
        |> Seq.mapi (fun i s -> (i + 1) * getFocalLength s)
        |> Seq.sum

    let getSum (input: string) =
        input.Split ","
        |> Seq.map getType
        |> Seq.groupBy (fun (a, _, _) -> a)
        |> Seq.map (fun (_, b) -> b |> Seq.map (fun (a, b, c) -> (b, if c.IsSome then Some ((a + 1) * c.Value) else None)))
        |> Seq.sumBy (applySteps >> sumBox)

