namespace AoC2015

module Day15Part1 =

    let getScore(a:int, b:int, c:int) = 
        let d = 100 - (a + b + c)
        (a * 2) * (max 0 ((b * 5) + (d * -1))) * (max 0 ((a * -2) + (b * -3) + (c * 5))) * (max 0 ((c * -1) + (d * 5))) 

    let getTotalScore() = 

        let scores = 
            [for a in 0 .. 100 do
                for b in 0 .. 100 - a do
                    for c in 0 .. 100 - (a + b)
                        -> getScore(a, b, c) ]

        List.max scores
