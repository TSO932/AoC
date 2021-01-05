namespace AoC2020

open System.Collections.Generic

module Day21Part1 =
    let countSafeIngredients (foods:seq<string>) =

        let mutable foodIngredients = List.empty
        let mutable foodAllergens = List.empty
        let mutable foodNumber = 0

        for food in foods do
            
            let insAndAlls = food.Replace(",","").Replace(")","").Split " (contains "

            for ingredient in insAndAlls.[0].Split " " do
                foodIngredients <- List.append [(foodNumber, ingredient)] foodIngredients
            
            for allergen in insAndAlls.[1].Split " " do
                foodAllergens <- List.append [(foodNumber, allergen)] foodAllergens

            foodNumber <- foodNumber + 1


        let mutable suspectAllergenIngredients = List.empty
        let mutable allergenCount = 0
    
        for allergen in foodAllergens |> List.map snd |> List.distinct do
        
            let foods = foodAllergens |> List.filter (fun (_, a) -> a = allergen) |> List.map fst
            let ingredients = foodIngredients |> List.filter (fun (food, _) -> List.contains food foods) |> List.countBy snd |> List.sortBy snd |> List.rev
            let maxOccurances = snd (List.head ingredients)
            let suspects = ingredients |> List.filter (fun (_, occurances) -> occurances = maxOccurances) |> List.map (fun (ingredient, _) -> (allergen, ingredient)) 
            

            suspectAllergenIngredients <- List.append suspects suspectAllergenIngredients
            allergenCount <- allergenCount + 1



        let knownAllergenIngredients = Dictionary<string, string>()

        while Seq.length knownAllergenIngredients.Keys < allergenCount do

            for (_, allergenIngredients) in suspectAllergenIngredients |> List.groupBy fst do
                if List.length allergenIngredients = 1 then
                    let allergenIngredient = List.head allergenIngredients
                    knownAllergenIngredients.Add(allergenIngredient)
                    suspectAllergenIngredients <- suspectAllergenIngredients |> List.filter (fun (_, ingredient) -> ingredient <> snd allergenIngredient)
             
        foodIngredients |> List.filter (fun (_, ingredient) -> not (knownAllergenIngredients.Values |> Seq.contains ingredient)) |> List.length

        
