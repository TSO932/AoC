namespace AoC2020

open System.Text.RegularExpressions

module Day18Part2 =

    let rec evaluateMiddleExpression (expression:string) =

        let pattern = @"[0-9]+ \+ [0-9]+"
        if Regex.IsMatch (expression, pattern) then

            let mutable simplifiedExpression = expression
            for (expr, result) in Regex.Matches (expression, pattern) |> Seq.map string  |> Seq.map (fun x -> (x, string (Day18Part1.evaluateSimpleExpression(x)))) do
                simplifiedExpression <- simplifiedExpression.Replace(expr, result)
            
            evaluateMiddleExpression(simplifiedExpression)
        
        else 
            Day18Part1.evaluateSimpleExpression(expression)

    let rec evaluateExpression (expression:string) =

        let pattern = @"\(([0-9]| |\*|\+)+\)"
        if Regex.IsMatch (expression, pattern) then

            let mutable simplifiedExpression = expression
            for (expr, result) in Regex.Matches (expression, pattern) |> Seq.map string  |> Seq.map (fun x -> (x, string (evaluateMiddleExpression(x.[1..(x.Length - 2)])))) do
                simplifiedExpression <- simplifiedExpression.Replace(expr, result)
            
            evaluateExpression(simplifiedExpression)
        
        else 
            evaluateMiddleExpression(expression)

    let sumValues (values:seq<string>) =
        values |> Seq.sumBy evaluateExpression