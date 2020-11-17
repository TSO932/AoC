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

    let up = matrix.[0..(y - 1), x] |> Array.exists ((=) '#') |> (fun b -> if b = true then 1 else 0)
    let down = matrix.[(y + 1).., x] |> Array.exists ((=) '#') |> (fun b -> if b = true then 1 else 0)
    let left = matrix.[y, 0..(x - 1)] |> Array.exists ((=) '#') |> (fun b -> if b = true then 1 else 0)
    let right = matrix.[y, (x + 1)..] |> Array.exists ((=) '#') |> (fun b -> if b = true then 1 else 0)
    
    let mutable lowerRight = 0
    for i in 1 .. min (arrays.Length - y - 1) (arrays.[0].Length - x - 1) do
        if matrix.[y + i, x + i] = '#' then
            lowerRight <- 1

    let mutable upperLeft = 0        
    for i in 1 .. min y x do
        if matrix.[y - i, x - i] = '#' then
            upperLeft <- 1
                   
    let mutable upperRight = 0
    for i in 1 .. min y (arrays.[0].Length - x - 1) do
        if matrix.[y - i, x + i] = '#' then
            upperRight <- 1

    let mutable lowerLeft = 0
    for i in 1 .. min (arrays.Length - y - 1) x do
        if matrix.[y + i, x - i] = '#' then
            lowerLeft <- 1

    if matrix.[y,x] = '#' then up + down + left + right + upperRight + upperLeft + lowerLeft + lowerRight else 0

let countedAsteroids = matrix |> Array2D.mapi (fun y x a -> countAsteroids(y, x)) |> Seq.cast<int>
let answer = countedAsteroids |> Seq.findIndex ((=) (countedAsteroids |> Seq.max)) |> fun i -> (i / arrays.[0].Length, i - (i / arrays.[0].Length) * arrays.[0].Length)

printfn "%O" answer
