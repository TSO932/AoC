namespace _2024

module Day04Part1 =
    let run(spaceMap:seq<string>) =

        let arrays = spaceMap |> Seq.map (Array.ofSeq) |> Array.ofSeq
        let matrix = Array2D.init arrays.Length arrays.[0].Length (fun i j -> arrays.[i].[j])

        let isXmas(v, h, dv, dh) =
            if dh > 0 && h + 3 >= Array2D.length2 matrix then
                false
            elif dh < 0 && h - 3 < 0 then
                false
            elif dv > 0 && v + 3 >= Array2D.length1 matrix then
                false
            elif dv < 0 && v - 3 < 0 then
                false
            else
                matrix[v, h] = 'X' && matrix[v + dv, h + dh] = 'M' && matrix[v + 2*dv, h + 2*dh] = 'A' && matrix[v + 3*dv, h + 3*dh] = 'S'

        let isHoriz(v, h) = isXmas(v, h, 0, 1)
        let isHorizReverse(v, h) = isXmas(v, h, 0, -1)             
        let isVert(v, h) = isXmas(v, h, 1, 0)
        let isVertReverse(v, h) = isXmas(v, h, -1, 0)
        let isDiag1(v, h) = isXmas(v, h, 1, 1)
        let isDiag1Rev(v, h) = isXmas(v, h, -1, -1)
        let isDiag2(v, h) = isXmas(v, h, -1, 1)
        let isDiag2Rev(v, h) = isXmas(v, h, 1, -1)

        let countXmases(f) =                               
            matrix
            |> Array2D.mapi (fun v h _ -> f (v, h))
            |> Seq.cast<bool>
            |> Seq.filter id
            |> Seq.length

        [isHoriz; isHorizReverse; isVert; isVertReverse; isDiag1; isDiag1Rev; isDiag2; isDiag2Rev]
        |> Seq.sumBy (fun f -> countXmases f)