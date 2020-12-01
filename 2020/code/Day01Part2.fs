namespace AoC2020

module Day01Part2 =
    let fixExpenses (inputString:seq<string>) =

        let digits = inputString |> Seq.map int |> List.ofSeq

        let mutable answer = 0
        for position1 in [0..digits.Length - 1] do
            for position2 in [0..digits.Length - 1] do
                for position3 in [0..digits.Length - 1] do
                if (digits.[position1] + digits.[position2] + digits.[position3]= 2020) && position1 <> position2 && position2 <> position3 then
                    answer <- digits.[position1] * digits.[position2] * digits.[position3] 

        answer