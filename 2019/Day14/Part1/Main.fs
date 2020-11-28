open System.Collections.Generic

let isDebug = false
                    
let inventory = new Dictionary<string, int>()

let rec tcaer(product, quantity, productList:string) =
    if product = "ORE" then
        quantity
    else
        if product = "FUEL" then
            inventory.Keys |> Seq.iter (inventory.Remove >> ignore)
            
        let formatInventoryLine(line:string) =
            let formatReagent(reagent:string) =
                reagent.Split ' ' |> fun x -> (x.[1], int x.[0])
            let pair = line.Split " => "
            let reagents = pair.[0].Split ", " |> Seq.map formatReagent
            let product = pair.[1].Split ' '
            product.[1], (int product.[0], List.ofSeq reagents)

        let productDic = productList.Split ([|'\010'; '\013'|], System.StringSplitOptions.RemoveEmptyEntries) |> Seq.map formatInventoryLine |> dict
        
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

        //snd reactants |> List.map (fun (r, q) -> (r, q * batchesRequired)) |> List.map tcaer |> List.sum
        List.sumBy tcaer (snd reactants |> List.map (fun (r, q) -> (r, q * batchesRequired)) |> List.groupBy fst |> List.map (fun (a,b) -> (a, b |> List.sumBy snd, productList)))


let list1 = "10 ORE => 10 A
1 ORE => 1 B
7 A, 1 B => 1 C
7 A, 1 C => 1 D
7 A, 1 D => 1 E
7 A, 1 E => 1 FUEL"

let list2 = "9 ORE => 2 A
8 ORE => 3 B
7 ORE => 5 C
3 A, 4 B => 1 AB
5 B, 7 C => 1 BC
4 C, 1 A => 1 CA
2 AB, 3 BC, 4 CA => 1 FUEL"

let list3 = "157 ORE => 5 NZVS
165 ORE => 6 DCFZ
44 XJWVT, 5 KHKGT, 1 QDVJ, 29 NZVS, 9 GPVTF, 48 HKGWZ => 1 FUEL
12 HKGWZ, 1 GPVTF, 8 PSHF => 9 QDVJ
179 ORE => 7 PSHF
177 ORE => 5 HKGWZ
7 DCFZ, 7 PSHF => 2 XJWVT
165 ORE => 2 GPVTF
3 DCFZ, 7 NZVS, 5 HKGWZ, 10 PSHF => 8 KHKGT"

let list4 = "2 VPVL, 7 FWMGM, 2 CXFTF, 11 MNCFX => 1 STKFG
17 NVRVD, 3 JNWZP => 8 VPVL
53 STKFG, 6 MNCFX, 46 VJHF, 81 HVMC, 68 CXFTF, 25 GNMV => 1 FUEL
22 VJHF, 37 MNCFX => 5 FWMGM
139 ORE => 4 NVRVD
144 ORE => 7 JNWZP
5 MNCFX, 7 RFSQX, 2 FWMGM, 2 VPVL, 19 CXFTF => 3 HVMC
5 VJHF, 7 MNCFX, 9 VPVL, 37 CXFTF => 6 GNMV
145 ORE => 6 MNCFX
1 NVRVD => 8 CXFTF
1 VJHF, 6 MNCFX => 4 RFSQX
176 ORE => 6 VJHF"

let list5 = "171 ORE => 8 CNZTR
7 ZLQW, 3 BMBT, 9 XCVML, 26 XMNCP, 1 WPTQ, 2 MZWV, 1 RJRHP => 4 PLWSL
114 ORE => 4 BHXH
14 VRPVC => 6 BMBT
6 BHXH, 18 KTJDG, 12 WPTQ, 7 PLWSL, 31 FHTLT, 37 ZDVW => 1 FUEL
6 WPTQ, 2 BMBT, 8 ZLQW, 18 KTJDG, 1 XMNCP, 6 MZWV, 1 RJRHP => 6 FHTLT
15 XDBXC, 2 LTCX, 1 VRPVC => 6 ZLQW
13 WPTQ, 10 LTCX, 3 RJRHP, 14 XMNCP, 2 MZWV, 1 ZLQW => 1 ZDVW
5 BMBT => 4 WPTQ
189 ORE => 9 KTJDG
1 MZWV, 17 XDBXC, 3 XCVML => 2 XMNCP
12 VRPVC, 27 CNZTR => 2 XDBXC
15 KTJDG, 12 BHXH => 5 XCVML
3 BHXH, 2 VRPVC => 7 MZWV
121 ORE => 7 VRPVC
7 XCVML => 6 RJRHP
5 BHXH, 4 VRPVC => 5 LTCX"

printfn "%i" (tcaer("A", 1, list2)) // 9
printfn "%i" (tcaer("A", 2, list2)) // 9
printfn "%i" (tcaer("B", 1, list2)) // 8
printfn "%i" (tcaer("C", 1, list2)) // 7
inventory.Keys |> Seq.iter (inventory.Remove >> ignore) //need to clear down inventory (happens automatically if "FUEL")
printfn "%i" (tcaer("AB", 1, list2)) // sum of ((no of batches needed) * (units needed for batch)) =>  2 * 9 + 2 * 8 = 34
printfn "%i" (tcaer("BC", 1, list2)) // 2 * 8 + 2 * 7 = 30
printfn "%i" (tcaer("CA", 1, list2)) // 1 * 7 + 1 * 9 = 16
inventory.Keys |> Seq.iter (inventory.Remove >> ignore)
printfn "%i" (tcaer("FUEL", 1, list2))

printfn "%i" (tcaer("FUEL", 1, list1))
printfn "%i" (tcaer("FUEL", 1, list3))
printfn "%i" (tcaer("FUEL", 1, list4))
printfn "%i" (tcaer("FUEL", 1, list5))

let challengeInput = "QWERTYUIOP" // paste input string over dummy values

printfn "%i" (tcaer("FUEL", 1, challengeInput))
