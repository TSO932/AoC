namespace AoC2015

module Day20Part1 =

  let getScore(houseNumber:int) =
    [1 .. houseNumber] |> Seq.map (fun n -> if houseNumber % n = 0 then 10 * n else 0) |> Seq.sum

  let getFirstHouseWithTargetScoreOrMore(targetScore:int, scoring) =

    //The interval speeds things up for larger house numbers.  All the new maxima are multiples of 10 so, only check them.
    let interval = if targetScore > 1000 then 10 else 1

    let rec houseByHouse(houseNumber:int) =
      if scoring(houseNumber) >= targetScore then
        houseNumber
      else
        houseByHouse(houseNumber + interval)
    
    houseByHouse(0)    

  let getFirstHouse(targetScore:string) = getFirstHouseWithTargetScoreOrMore(int targetScore, getScore)