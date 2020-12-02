namespace AoC2019

open System.Collections.Generic

module Day14Part2 =

    let isDebug = false
                    
    let inventory = new Dictionary<string, int64>()

    let getProductDic(productList:seq<string>) = 
            let formatInventoryLine(line:string) =
                let formatReagent(reagent:string) =
                    reagent.Split ' ' |> fun x -> (x.[1], int64 x.[0])
                let pair = line.Split " => "
                let reagents = pair.[0].Split ", " |> Seq.map formatReagent
                let product = pair.[1].Split ' '
                product.[1], (int64 product.[0], List.ofSeq reagents)

            productList |> Seq.map formatInventoryLine |> dict

    let rec tcaer(product, quantity, productDic:IDictionary<string, (int64 * (string * int64) list)>, isStart) =
        if product = "ORE" then
            quantity
        else
            if isStart then
                inventory.Keys |> Seq.iter (inventory.Remove >> ignore)
                
            let reactants = snd (productDic.TryGetValue(product))
            let currentQuantity = snd (inventory.TryGetValue(product))

            let batchesRequired =
                if quantity > currentQuantity then
                    (quantity - currentQuantity) / fst reactants + if ((quantity - currentQuantity) % fst reactants) <> 0L then 1L else 0L
                else
                    0L
                    
            inventory.Remove(product) |> ignore
            let quantityAferReaction = currentQuantity + batchesRequired * int64(fst reactants) 
            if quantityAferReaction > quantity then
               inventory.Add(product, quantityAferReaction - quantity)
               else true |> ignore

            if isDebug then printfn "p %s q %i cQ %i b %i l %i" product quantity currentQuantity batchesRequired (inventory.Count)

            List.sumBy tcaer (snd reactants |> List.map (fun (r, q) -> (r, q * batchesRequired)) |> List.groupBy fst |> List.map (fun (a,b) -> (a, b |> List.sumBy snd, productDic, false)))

    let findOneTrillion(challengeInput:seq<string>) = 
        let mutable maxUnder = 0L
        let mutable minOver  = 1000000000000L
        while minOver - maxUnder > 1L do
            let splitTheDifference = (minOver + maxUnder) / 2L
            if tcaer("FUEL", splitTheDifference, getProductDic(challengeInput), true) > 1000000000000L then
                minOver <- splitTheDifference
            else
                maxUnder <- splitTheDifference
        
        if isDebug then printfn "%i gives %i" maxUnder (tcaer("FUEL", maxUnder, getProductDic(challengeInput), true))
        if isDebug then printfn "%i gives %i" minOver (tcaer("FUEL", minOver, getProductDic(challengeInput), true))
        maxUnder
