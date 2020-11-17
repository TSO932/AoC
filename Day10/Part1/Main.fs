let a = ".#..#
.....
#####
....#
...##"

let arrays = a.Split '\010' |> Seq.map (fun a -> Array.ofSeq a) |> Array.ofSeq
let matrix = Array2D.init arrays.Length arrays.[0].Length (fun i j -> arrays.[i].[j])

let countAsteroids(y, x) = 
    let up = matrix.[0..(y - 1), x] |> Array.exists ((=) '#')
    let down = matrix.[(y + 1).., x] |> Array.exists ((=) '#')
    let left = matrix.[y, 0..(x - 1)] |> Array.exists ((=) '#')
    let right = matrix.[y, (x + 1)..] |> Array.exists ((=) '#')
    if matrix.[y,x] = '#' then (if up then 1 else 0) + (if down then 1 else 0) + (if left then 1 else 0) + (if right then 1 else 0) else 0

let countedAsteroids = matrix |> Array2D.mapi (fun y x a -> countAsteroids(y, x)) |> Seq.cast<int>
let answer = countedAsteroids |> Seq.findIndex ((=) (countedAsteroids |> Seq.max)) |> fun i -> (i / arrays.[0].Length, i - (i / arrays.[0].Length) * arrays.[0].Length)

printfn "%A" countedAsteroids
printfn "%O" answer
