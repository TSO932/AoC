namespace _2023

module Day24Part1 =
    let getPointAndVelocity(input:string) =

        let numbers = input.Replace("@", ",").Replace(" ","").Split ","
        (double numbers[0], double numbers[1], double numbers[2], double numbers[3], double numbers[4], double numbers[5])

    let getLine(px:double, py:double, pz:double, dx:double, dy:double, dz:double) =
        let a = dy / dx
        let b = -1.0
        let c =  py - (dy /dx) * px
        (a, b, c, px, dx)

    let isInPast(px, dx, x) =
        if dx >= 0.0 then
            x < px
        else
            x > px

    let getIntersection((a1:double, b1:double, c1:double, px1:double, dx1:double), (a2:double, b2:double, c2:double, px2:double, dx2:double)) =

        let denominator = a1 * b2 - a2 * b1
        let xNumerator = b1 * c2 - b2 * c1
        let yNumerator = a2 * c1 - a1 * c2
        
        if denominator = 0.0 then
            None
        else
            let x = xNumerator / denominator
            let y = yNumerator / denominator

            if isInPast (px1, dx1, x) then
                None
            elif isInPast (px2, dx2, x) then
                None
            else
                Some (x, y)         
 
    let testRule(i:float) =
        i >= 7.0 && i <= 27.0

    let rangeRule(i:float) =
        i >= 200000000000000.0 && i <= 400000000000000.0

    let isInRange(intersection, rule) =
        match intersection with
        | Some (x, y) -> rule x && rule y
        | _ -> false

    let getSumInternal(input:seq<string>, rule) =

        let lines = input |> Seq.map (getPointAndVelocity >> getLine)
      
        lines
        |> Seq.map (fun l1 -> lines |> Seq.map (fun l2 -> isInRange(getIntersection(l1, l2), rule)))
        |> Seq.concat
        |> Seq.filter id
        |> Seq.length
        |> fun x -> x / 2
    
    let getSum(input:seq<string>) = getSumInternal(input, rangeRule)

    