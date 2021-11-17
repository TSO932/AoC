namespace AoC2015

module Day18Part2 =

  let switchLights(oldLights:bool [,]) =
    let maxHeight = oldLights.[*, 0..0].Length
    let maxWidth = oldLights.[0..0, *].Length

    let switchLight(v, h, c) =

      let countNeighbours(col, row) = 
        (oldLights.[(max 0 (row - 1))..(min maxHeight (row + 1)),(max 0 (col - 1))..(min maxWidth (col + 1))] |> Day18Part1.lightCount)
          - if oldLights.[row, col] then 1 else 0

      match countNeighbours(v, h), c with
      | 2, true
      | 3, _    -> true
      | _       -> false

    let isCorner(col, row) = (row = 0 || row = maxHeight - 1) && (col = 0 || col = maxWidth - 1)

    oldLights |> Array2D.mapi (fun h v c -> switchLight(v, h, c)) |> Array2D.mapi (fun h v c -> if isCorner(v, h) then true else c)

  let rec animate(initialLights:bool [,], numberOfSteps:int) =

    if numberOfSteps = 0 then
      initialLights
    else
      animate(switchLights(initialLights), numberOfSteps - 1)

  let countOnLights(lightBoard:seq<string>, numberOfSteps:int) = animate(Day18Part1.parseLights(lightBoard), numberOfSteps) |> Day18Part1.lightCount

  let countLights(lightBoard:seq<string>) = countOnLights(lightBoard, 100)


        
