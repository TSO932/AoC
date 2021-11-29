namespace AoC2015

open System.Collections.Generic

module Day19Part2 =

  let getDistinctProducts(molecule:array<string>, reactions:Dictionary<string, seq<seq<string>>>) =

    molecule |> Seq.mapi (fun i _ -> Day19Part1.getReactionsAtSingleSite(molecule, reactions, i)) |> Seq.concat |> Seq.distinct

  let getDistinctProductsForMultipleReactants(molecules:seq<array<string>>, reactions:Dictionary<string, seq<seq<string>>>) =

    molecules |> Seq.map (fun m -> getDistinctProducts(m, reactions)) |> Seq.concat |> Seq.distinct

  let rec itterate(count:int, reactions:Dictionary<string, seq<seq<string>>>, targetMolecule:string, candidateMolecules:seq<seq<string>>) =

    printfn "Running Count: %i (%i)" count (Seq.length candidateMolecules)

    if candidateMolecules |> Seq.exists (fun m -> String.concat "" m = targetMolecule) then
      count
    elif count >= 8 then
      count
    else
      itterate(count + 1, reactions, targetMolecule, getDistinctProductsForMultipleReactants(candidateMolecules |> Seq.map Array.ofSeq, reactions) |> Seq.map Seq.ofArray)

  let countFewestReactionSteps(input:seq<string>) =

    let targetMolecule = input |> Seq.filter (fun s -> not (s.Contains(" => ")) && s.Length > 0) |> Seq.exactlyOne
    let reactions = Day19Part1.getReactions(input |> Seq.filter (fun s -> s.Contains(" => ")))

    itterate(0, reactions, targetMolecule, [["e"]])


