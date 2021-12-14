namespace AoC2021

module Day13Part2 =

    let DoAllFolds(input:seq<string>) =

        let folds = Day13Part1.getFolds(input)
        let paper = Day13Part1.getPaper(input)

        let fold((direction:string, position:int), paper:bool[,]) =
            let nFold = if direction = "y" then Day13Part1.yFold else Day13Part1.xFold
            nFold (position, paper)

        let result = folds |> Seq.fold (fun p f -> fold (f, p) ) paper
               
        result 
        |> Array2D.map (fun b -> if b then '*' else '.')
        |> Seq.cast<char>
        |> Seq.chunkBySize (Array2D.length2 result)
        |> Seq.map (Seq.toArray >> System.String)

