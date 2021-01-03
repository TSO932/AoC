namespace AoC2020

open System
open System.Collections.Generic
open System.Text.RegularExpressions

module Day19Part2 =
    
    let getPattern(rules:seq<string>) =

        let rulesDic = new Dictionary<int, string>()

        for rule in rules do
            let seq = rule.Split ": " |> Array.ofSeq
            rulesDic.Add((int seq.[0]), seq.[1])

        let rec parseRule(initialRule:string) =
            if Regex.IsMatch (initialRule, @"^(a|b|\|)+$") then
                initialRule
            else
                let mutable newRule = ""

                for s in (initialRule.Split " " |> Array.ofSeq) do
                    let getSpecialLookup(key:int) =
                        match key with
                        | 8  -> " ( 42 ) + "
                        | 11 -> " ( 42 31 ) | ( ( 42 ) {2} ( 31 ) {2} ) | ( ( 42 ) {3} ( 31 ) {3} ) | ( ( 42 ) {4} ( 31 ) {4} ) | ( ( 42 ) {5} ( 31 ) {5} )" 
                        | _  -> parseRule(rulesDic.Item(key))
                        
                    newRule <- newRule + " " + match Int32.TryParse s with
                                                | true,  v -> "(" + parseRule(getSpecialLookup(v)) + ")"
                                                | false, _ -> s
                newRule

        "^" + parseRule(rulesDic.Item(0)).Replace(" ","").Replace("""("a")""","a").Replace("""("b")""","b") + "$"

    let countValidMessages (rulesAndMessages:seq<string>) =

        let pattern = getPattern(rulesAndMessages |> Seq.filter (fun s -> Regex.IsMatch (string s, @"^[0-9]")))
        
        rulesAndMessages |> Seq.filter (fun s -> Regex.IsMatch (s, @"^(a|b)+$")) |> Seq.filter (fun m -> Regex.IsMatch(m, pattern)) |> Seq.length