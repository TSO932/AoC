namespace AoC2015

open System.Collections.Generic

module Day19Part1 =

  let getElementsInFormula(formula:string) =
    let mutable i = 0

    let capitalCount(letter:char) =
      if int letter < 97 then
        i <- i + 1
      i

    formula |> Seq.toList |> List.groupBy capitalCount |> Seq.map snd

  let getReactions(reactionStrings:seq<string>) =
    
    let getReaction(reactionString:string) =
      let react = reactionString.Split [|' '|]
      (react.[0], react.[2])

    let dictionary = new Dictionary<string, seq<string>>()
    reactionStrings |> Seq.map  getReaction |> Seq.groupBy fst |> Seq.iter (fun (r, ps) -> dictionary.Add(r, Seq.map snd ps)) |> ignore
    dictionary