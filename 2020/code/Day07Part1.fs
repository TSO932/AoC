namespace AoC2020

open System

module Day07Part1 =
    let countOuterBags (innerBags:list<string>, bagRules:seq<string>) =

        let bagMap = bagRules |> Seq.map (fun x -> x.Replace("bags", "bag").Split " contain ")

        let rec getBags(bags:list<string>) =
            
            let getOuterBags(bag:string) = bagMap |> Seq.filter (fun x -> x.[1].Contains bag) |> Seq.map (fun x -> x.[0]) |> List.ofSeq
            let outerBags = bags |> List.map getOuterBags |> List.concat |> List.distinct
            let allBags = List.append bags outerBags |> List.distinct
            
            if List.length outerBags = 0 then
                allBags
            else
                List.append allBags (getBags(outerBags)) |> List.distinct

        List.length (getBags(innerBags)) - List.length (innerBags |> List.distinct)


    let myPrecious(bagRules:seq<string>) = countOuterBags (["shiny gold bag"], bagRules)