namespace AoC2015

module Day15Part2 =

    let getTotalScore() = 

        let is500Calories(a:int, b:int, c:int) =
            let d = 100 - (a + b + c)
            (3 * a) + (3 * b) + (8 * c) + (8 * d) = 500

        let scores = 
            [for a in 0 .. 100 do
                for b in 0 .. 100 - a do
                    for c in 0 .. 100 - (a + b)
                        -> is500Calories(a, b, c), Day15Part1.getScore(a, b, c) ]

        scores |> List.filter fst |> List.map snd |> List.max


 