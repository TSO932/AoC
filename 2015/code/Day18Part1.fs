namespace AoC2015

module Day18Part1 =

  let lightCount(lights:bool [,]) =
    lights |> Seq.cast |> Seq.countBy ((=) true) |> Seq.sumBy (fun (b, i) -> if b then i else 0)

  let parseLights(lightBoard:seq<string>) =
            
    let arrays = lightBoard |> Seq.map (Array.ofSeq) |> Array.ofSeq
    let maxHeight = arrays.Length
    let maxWidth = arrays.[0].Length
    Array2D.init maxHeight maxWidth (fun i j -> arrays.[i].[j]) |> Array2D.map (fun l -> l = '#')

  let switchLights(oldLights:bool [,]) =
    let maxHeight = oldLights.[*, 0..0].Length
    let maxWidth = oldLights.[0..0, *].Length

    let switchLight(v, h, c) =

      let countNeighbours(col, row) = 
        (oldLights.[(max 0 (row - 1))..(min maxHeight (row + 1)),(max 0 (col - 1))..(min maxWidth (col + 1))] |> lightCount)
          - if oldLights.[row, col] then 1 else 0

      match countNeighbours(v, h), c with
      | 2, true
      | 3, _    -> true
      | _       -> false

    oldLights |> Array2D.mapi (fun h v c -> switchLight(v, h, c))

  let rec animate(initialLights:bool [,], numberOfSteps:int) =

    if numberOfSteps = 0 then
      initialLights
    else
      animate(switchLights(initialLights), numberOfSteps - 1)

  let countOnLights(lightBoard:seq<string>, numberOfSteps:int) = animate(parseLights(lightBoard), numberOfSteps) |> lightCount

  let countLights(lightBoard:seq<string>) = countOnLights(lightBoard, 100)


        
