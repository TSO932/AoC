namespace _2024

module Day04Part2 =
    let run(spaceMap:seq<string>) =

        let arrays = spaceMap |> Seq.map (Array.ofSeq) |> Array.ofSeq
        let matrix = Array2D.init arrays.Length arrays.[0].Length (fun i j -> arrays.[i].[j])

        let isXmas(v, h, d1, d2) =
            if h + 1 >= Array2D.length2 matrix then
                false
            elif h = 0 then
                false
            elif v + 1 >= Array2D.length1 matrix then
                false
            elif v = 0 then
                false
            else
                matrix[v, h] = 'A' && matrix[v - d1, h - d1] = 'M' && matrix[v + d1, h + d1] = 'S' && matrix[v + d2, h - d2] = 'M' && matrix[v - d2, h + d2] = 'S'

        let isX1(v, h) = isXmas(v, h, 1, 1)
        let isX2(v, h) = isXmas(v, h, 1, -1)             
        let isX3(v, h) = isXmas(v, h, -1, 1)
        let isX4(v, h) = isXmas(v, h, -1, -1)

        let countXmases(f) =                               
            matrix
            |> Array2D.mapi (fun v h _ -> f (v, h))
            |> Seq.cast<bool>
            |> Seq.filter id
            |> Seq.length

        [isX1; isX2; isX3; isX4]
        |> Seq.sumBy (fun f -> countXmases f)