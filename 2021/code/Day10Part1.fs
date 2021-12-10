namespace AoC2021

module Day10Part1 =
    let removePairedBrackets(input:string) =

        let output =  input.Replace("()","").Replace("<>","").Replace("{}","").Replace("[]","")
        let isComplete = input.Length = output.Length
        isComplete, output 
 
    let rec removeAllPairedBrackets(input:string) =

        let output = removePairedBrackets input
        
        if fst output then
            input
        else
            removeAllPairedBrackets(snd output)


    let isComplete(input:string) =
        match input.IndexOfAny [|'['; ']'; '{'; '}'; '<'; '>'; '('; ')'|] with 
        | -1 -> true
        | _  -> false

    let scoreFirstIllegalCharacter(input:string) =
        let simplified = removeAllPairedBrackets(input)
        let ind = simplified.IndexOfAny [|']'; '}'; '>'; ')'|]
        if ind = -1 then
            0
        else match simplified[ind] with
                | ')' -> 3
                | ']' -> 57
                | '}' -> 1197
                | _   -> 25137 // '>' expected

    let getScore(input:seq<string>) =
        input |> Seq.sumBy scoreFirstIllegalCharacter