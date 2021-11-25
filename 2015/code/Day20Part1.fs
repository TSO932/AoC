namespace AoC2015

module Day20Part1 =

  let getScore(houseNumber:int) =
    [1 .. houseNumber] |> Seq.map (fun n -> if houseNumber % n = 0 then 10 * n else 0) |> Seq.sum

  let getFirstHouseWithTargetScoreOrMore(targetScore:int) =

    let rec houseByHouse(houseNumber:int) =
      if getScore(houseNumber) >= targetScore then
        houseNumber
      else
        houseByHouse(houseNumber + 10)
    
    houseByHouse(0)
    

