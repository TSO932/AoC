namespace AoC2015

open System.Text.Json

module Day12Part2 =

    let rec sumNumbers(input:string) =

        let rec sumObject(element:JsonElement) =

            let getValue(jsonElement:JsonElement) =
                match jsonElement.ValueKind with
                                    | JsonValueKind.Number -> jsonElement.GetInt32()
                                    | JsonValueKind.Object
                                    | JsonValueKind.Array  -> sumObject(jsonElement)
                                    | _                    -> 0

            let mutable sum = 0
            let mutable isRed = false

            if element.ValueKind = JsonValueKind.Array then
                for arrayElement in element.EnumerateArray() do
                    sum <- sum + getValue(arrayElement)
            else
                for objectElement in element.EnumerateObject() do
                    sum <- sum + getValue(objectElement.Value)
                    isRed <- isRed || (objectElement.Value.ValueKind = JsonValueKind.String && objectElement.Value.GetString() = "red")

            if isRed then 0 else sum

        sumObject(JsonDocument.Parse(input).RootElement)

