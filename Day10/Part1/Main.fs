let a = ".#..#
.....
#####
....#
...##"

let isDebug = true
let arrays = a.Split '\010' |> Seq.map (fun a -> Array.ofSeq a) |> Array.ofSeq
let matrix = Array2D.init arrays.Length arrays.[0].Length (fun i j -> arrays.[i].[j])

if isDebug then printfn "%A" matrix

let countAsteroids(y, x) = 

    let getDiagonals =
        let mutable upperRight = false
        let mutable lowerLeft = false
        let mutable upperLeft = false
        let mutable lowerRight = false

        for i in 1 .. min (arrays.Length - y - 2) (arrays.[0].Length - x - 2) do
            if matrix.[y + i, x + i] = '#' then
                lowerRight <- true
            
        for i in 1 .. min (y - 1) (x - 1) do
            if matrix.[y - i, x - i] = '#' then
                upperLeft <- true
                   
        for i in 1 .. min (y - 1) (arrays.[0].Length - x - 2) do
            
            if matrix.[y - i, x + i] = '#' then
                upperRight <- true
            
            
        for i in 1 .. min (arrays.Length - y - 2) (x - 1) do
            if matrix.[y + i, x - i] = '#' then
                lowerLeft <- true

        if isDebug then printfn "y %i x %i ur %b bl %b ul %b br %b" y x upperRight lowerLeft upperLeft lowerLeft
        
//        let mutable upperRightZXX = false
  //      for v in (y + 1)..(arrays.Length - 1) do
    //        for h in (x + 1)..(arrays.[0].Length - 1) do
      //         if matrix.[v,h] = '#' then
        //           diag <- true                   
        
    let up = matrix.[0..(y - 1), x] |> Array.exists ((=) '#')
    let down = matrix.[(y + 1).., x] |> Array.exists ((=) '#')
    let left = matrix.[y, 0..(x - 1)] |> Array.exists ((=) '#')
    let right = matrix.[y, (x + 1)..] |> Array.exists ((=) '#')
    if matrix.[y,x] = '#' then (if up then 1 else 0) + (if down then 1 else 0) + (if left then 1 else 0) + (if right then 1 else 0) else 0

let countedAsteroids = matrix |> Array2D.mapi (fun y x a -> countAsteroids(y, x)) |> Seq.cast<int>
let answer = countedAsteroids |> Seq.findIndex ((=) (countedAsteroids |> Seq.max)) |> fun i -> (i / arrays.[0].Length, i - (i / arrays.[0].Length) * arrays.[0].Length)

printfn "%A" countedAsteroids
printfn "%O" answer
