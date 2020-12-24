namespace AoC2020

open System.Collections.Generic
open System.Text.RegularExpressions

module Day24Part1 =

    let goEast(x, y, z)      = (x + 1, y - 1, z)
    let goNorthEast(x, y, z) = (x + 1, y,     z - 1)
    let goNorthWest(x, y, z) = (x,     y + 1, z - 1)
    let goWest(x, y, z)      = (x - 1, y + 1, z)
    let goSouthWest(x, y, z) = (x - 1, y,     z + 1)
    let goSouthEast(x, y, z) = (x,     y - 1, z + 1)
    
    let rec getCubeCoord(directions:string, location:int*int*int) =
        
        if directions.Length = 0 then
            location
        else
            if   Regex.IsMatch (directions, @"^e")  then
                getCubeCoord(directions.[1..(directions.Length - 1)], goEast(location))
            
            elif Regex.IsMatch (directions, @"^se") then
                getCubeCoord(directions.[2..(directions.Length - 1)], goSouthEast(location))
            
            elif Regex.IsMatch (directions, @"^sw") then
                getCubeCoord(directions.[2..(directions.Length - 1)], goSouthWest(location))
            
            elif   Regex.IsMatch (directions, @"^w")  then
                getCubeCoord(directions.[1..(directions.Length - 1)], goWest(location))
            
            elif Regex.IsMatch (directions, @"^nw") then
                getCubeCoord(directions.[2..(directions.Length - 1)], goNorthWest(location))
            
            elif Regex.IsMatch (directions, @"^ne") then
                getCubeCoord(directions.[2..(directions.Length - 1)], goNorthEast(location))
            
            else
                invalidArg "Invalid directions. Expected to start with e, se, sw, w, nw or ne" (directions)

    let findTile(directions:string) = getCubeCoord(directions, (0, 0, 0))

    let countTiles (listOfTiles:seq<string>) =

        let mutable tiles = Seq.empty

        for tile in listOfTiles |> Seq.map (findTile) do
            
            if Seq.exists ((=) tile) tiles then
                tiles <- Seq.filter ((<>) tile) tiles
            else
                tiles <- Seq.append tiles (seq { tile })
      
        Seq.length tiles