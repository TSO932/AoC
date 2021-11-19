namespace AoC2015

open System
open System.Collections.Generic

module Day19Part1 =

  let getElementsInFormula(formula:string) =
    let mutable i = 0

    let capitalCount(letter:char) =
      if int letter < 97 then
        i <- i + 1
      i

    formula |> Seq.toList |> List.groupBy capitalCount |> Seq.map (snd >> Array.ofSeq >> String)

  let getReactions(reactionStrings:seq<string>) =
    
    let getReaction(reactionString:string) =
      let react = reactionString.Split [|' '|]
      (react.[0], getElementsInFormula(react.[2]))

    let dictionary = new Dictionary<string, seq<seq<string>>>()
    reactionStrings |> Seq.map  getReaction |> Seq.groupBy fst |> Seq.iter (fun (r, ps) -> dictionary.Add(r, Seq.map snd ps)) |> ignore
    dictionary

  let getReactionsAtSingleSite(molecule:array<string>, reactions:Dictionary<string, seq<seq<string>>>, reactionSite:int) =

    match reactions.TryGetValue molecule.[reactionSite] with
      | true,  reactionProducts -> reactionProducts |> Seq.map (fun e -> Array.concat [molecule.[0 .. reactionSite - 1] ; Array.ofSeq e ; molecule.[reactionSite + 1 .. molecule.Length] ])
      | false, _                -> []

  let getDistinctProducts(molecule:array<string>, reactions:Dictionary<string, seq<seq<string>>>) =

    molecule |> Seq.mapi (fun i _ -> getReactionsAtSingleSite(molecule, reactions, i)) |> Seq.concat |> Seq.distinct |> Seq.length

  let countDistinctMolecules(input:seq<string>) =

    let initialMolecule = getElementsInFormula(input |> Seq.filter (fun s -> not (s.Contains(" => ")) && s.Length > 0) |> Seq.exactlyOne) |> Array.ofSeq
    let reactions = getReactions(input |> Seq.filter (fun s -> s.Contains(" => ")))

    getDistinctProducts(initialMolecule, reactions)
