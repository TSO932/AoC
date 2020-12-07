namespace AoC2020

open System

module Day07Part2 =
    let rec countBags (outerBag:string, bagRules:seq<string>) =

        let parseBagRule(rule:array<string>) =
            let parse(bag:string) =
                let delim = bag.IndexOf(' ')
                (int (bag.[0..(delim - 1)].Replace("no", "0")), bag.[(delim + 1)..(bag.Length - 1)])
            let components = rule.[1].Split ", " |> Array.map parse
            (rule.[0], components)

        let bagMap = bagRules |> Seq.map (fun x -> x.Replace("bags", "bag").Replace(".", "").Split " contain " |> parseBagRule) |> Map.ofSeq

        if outerBag = "other bag" then
            0
        else
            1 + ( bagMap.[outerBag] |> Seq.sumBy (fun x -> fst x * countBags(snd x, bagRules)) )
            
    let countInnerBags (outerBag:string, bagRules:seq<string>) =
        countBags(outerBag, bagRules) - 1

    let myPrecious(bagRules:seq<string>) = countInnerBags ("shiny gold bag", bagRules)