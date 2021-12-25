namespace AoC2021

module Day25Part1 =
    let getSeafloor(input:seq<string>) =

        let arrays = input |> Seq.map (Array.ofSeq) |> Array.ofSeq
        let maxHeight = arrays.Length
        let maxWidth = arrays[0].Length
        Array2D.init maxHeight maxWidth (fun i j -> arrays[i][j])

    let moveEast(input:char[,]) =

        let height = (Array2D.length1 input)
        let width  = (Array2D.length2 input)
        let output = Array2D.create height width '.'

        let move(y:int, x:int, c:char) =

            if c = '>' then
                let x1 = if x = width - 1 then 0 else x + 1
                if input[y, x1] = '.' then
                    Array2D.set output y x1 c
                else
                    Array2D.set output y x  c

            if c = 'v' then Array2D.set output y x c

        input |> Array2D.mapi (fun y x c -> move(y, x, c)) |> ignore

        output

    let moveSouth(input:char[,]) =

        let height = (Array2D.length1 input)
        let width  = (Array2D.length2 input)
        let output = Array2D.create height width '.'

        let move(y:int, x:int, c:char) =

            if c = 'v' then
                let y1 = if y = height - 1 then 0 else y + 1
                if input[y1, x] = '.' then
                    Array2D.set output y1 x c
                else
                    Array2D.set output y  x c

            if c = '>' then Array2D.set output y x c

        input |> Array2D.mapi (fun y x c -> move(y, x, c)) |> ignore

        output

    let move(input:char[,]) =
        input
        |> moveEast
        |> moveSouth

    let areEqual(a:char[,], b:char[,]) =
        a
        |> Array2D.mapi (fun y x c -> b[y, x] = c)
        |> Seq.cast<bool>
        |> Seq.contains false |> not

    let rec countSteps(seafloor:char[,], stepCount:int) =
        
        let theSeaCucmbersHaveMoved = seafloor |> move
        
        if areEqual(seafloor, theSeaCucmbersHaveMoved) then
            stepCount + 1
        else
            countSteps(theSeaCucmbersHaveMoved, stepCount + 1)

    let run(input:seq<string>) =
        countSteps(getSeafloor(input), 0)