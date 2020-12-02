namespace AoC2019

open System.Collections.Generic

module Day14Part1 =

    let isDebug = false
                    
    let inventory = new Dictionary<string, int>()

    let getProductDic(productList:seq<string>) = 
            let formatInventoryLine(line:string) =
                let formatReagent(reagent:string) =
                    reagent.Split ' ' |> fun x -> (x.[1], int x.[0])
                let pair = line.Split " => "
                let reagents = pair.[0].Split ", " |> Seq.map formatReagent
                let product = pair.[1].Split ' '
                product.[1], (int product.[0], List.ofSeq reagents)

            productList |> Seq.map formatInventoryLine |> dict

    let rec tcaer(product, quantity, productDic:IDictionary<string, (int * (string * int) list)>, isStart) =
        if product = "ORE" then
            quantity
        else
            if isStart then
                inventory.Keys |> Seq.iter (inventory.Remove >> ignore)
                
            let reactants = snd (productDic.TryGetValue(product))
            let currentQuantity = snd (inventory.TryGetValue(product))

            let batchesRequired =
                if quantity > currentQuantity then
                    (quantity - currentQuantity) / fst reactants + if ((quantity - currentQuantity) % fst reactants) <> 0 then 1 else 0
                else
                    0
                    
            inventory.Remove(product) |> ignore
            let quantityAferReaction = currentQuantity + batchesRequired * fst reactants 
            if quantityAferReaction > quantity then
               inventory.Add(product, quantityAferReaction - quantity)
               else true |> ignore

            if isDebug then printfn "p %s q %i cQ %i b %i l %i" product quantity currentQuantity batchesRequired (inventory.Count)

            List.sumBy tcaer (snd reactants |> List.map (fun (r, q) -> (r, q * batchesRequired)) |> List.groupBy fst |> List.map (fun (a,b) -> (a, b |> List.sumBy snd, productDic, false)))
