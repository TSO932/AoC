namespace AoC2020

open System.Text.RegularExpressions

module Day18Part1 =
    let evaluateSimpleExpression (expression:string) =

        let seq = expression.Split " " |> Array.ofSeq
        
        let rec eval(s:string array) =
            if s.Length = 1 then
                int64 s.[0]
            else
                if s.[1] = "+" then
                    eval( Array.append [| string (int64 s.[0] + int64 s.[2]) |] s.[3..])
                else
                    eval( Array.append [| string (int64 s.[0] * int64 s.[2]) |] s.[3..])

        eval(seq)

    let rec evaluateExpression (expression:string) =

        let pattern = @"\(([0-9]| |\*|\+)+\)"
        if Regex.IsMatch (expression, pattern) then

            let mutable simplifiedExpression = expression
            for (expr, result) in Regex.Matches (expression, pattern) |> Seq.map string  |> Seq.map (fun x -> (x, string (evaluateSimpleExpression(x.[1..(x.Length - 2)])))) do
                simplifiedExpression <- simplifiedExpression.Replace(expr, result)
            
            evaluateExpression(simplifiedExpression)
        else 
            evaluateSimpleExpression(expression)

    let sumValues (values:seq<string>) =
        values |> Seq.sumBy evaluateExpression