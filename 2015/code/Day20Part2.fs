namespace AoC2015

module Day20Part2 =

  let getScore(houseNumber:int) =
    [1 .. houseNumber] |> Seq.map (fun n -> if houseNumber % n = 0 && n * 50 >= houseNumber then 11 * n else 0) |> Seq.sum

  let getFirstHouse(targetScore:string) = Day20Part1.getFirstHouseWithTargetScoreOrMore(int targetScore, getScore)
    

