namespace AoC2020

module Day01Part1 =
    let fixExpenses (inputStrings:seq<string>) =

        let digits = inputStrings |> Seq.map int |> List.ofSeq

        let mutable answer = 0
        let mutable isNotAnswered = true

        for position1 in [0..digits.Length - 1] do
            if isNotAnswered then
                for position2 in [0..digits.Length - 1] do
                    if isNotAnswered && (digits.[position1] + digits.[position2] = 2020) && position1 <> position2 then
                        answer <- digits.[position1] * digits.[position2]
                        isNotAnswered <- false 

        answer