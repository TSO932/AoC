namespace AoC2020

open System
open System.Collections.Generic
open System.Text.RegularExpressions

module Day19Part1 =
    
    let isMatch(expression:string, pattern:string) =
        Regex.IsMatch (expression, pattern)

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
                    newRule <- newRule + " " + match Int32.TryParse s with
                                                | true,  v -> "(" + parseRule(rulesDic.Item(v)) + ")"
                                                | false, _ -> s
                newRule

        "^" + parseRule(rulesDic.Item(0)).Replace(" ","").Replace("""("a")""","a").Replace("""("b")""","b") + "$"

    let countValidMessages (rulesAndMessages:seq<string>) =

        let pattern = getPattern(rulesAndMessages |> Seq.filter (fun s -> Regex.IsMatch (string s, @"^[0-9]")))
        
        rulesAndMessages |> Seq.filter (fun s -> Regex.IsMatch (s, @"^(a|b)+$")) |> Seq.filter (fun m -> isMatch(m, pattern)) |> Seq.length