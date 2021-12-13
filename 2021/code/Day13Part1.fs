namespace AoC2021

module Day13Part1 =
    let getPaper(input:seq<string>) =

        let coords =
            input
            |> Seq.map (fun s -> s.Split ',') 
            |> Seq.filter (fun l -> Seq.length l = 2)
            |> Seq.map (fun xy -> xy |> Seq.head |> int, xy |> Seq.tail |> Seq.exactlyOne |> int)

        let width  = (coords |> Seq.map fst |> Seq.max) + 1
        let height = (coords |> Seq.map snd |> Seq.max) + 1

        let paper = Array2D.create height width false

        coords |> Seq.iter (fun (x, y) -> Array2D.set paper y x true)
        paper
    
    let xFold(x:int, paper:bool[,]) =
        let left  = paper[*, .. x - 1]
        let right = paper[*, x + 1 ..]
        let width  = (Array2D.length2 left) - 1

        let folded = Array2D.copy left
        right |> Array2D.mapi (fun y x b -> Array2D.set folded y (width - x) (b || Array2D.get left y (width - x))) |> ignore
        folded
    
    let yFold(y:int, paper:bool[,]) =
        let top    = paper[.. y - 1, *]
        let bottom = paper[y + 1 .., *]
        let height  = (Array2D.length1 top) - 1

        let folded = Array2D.copy top
        bottom |> Array2D.mapi (fun y x b -> Array2D.set folded (height - y) x (b || Array2D.get top (height - y) x)) |> ignore
        folded

    let getFolds(input:seq<string>) =
        input
        |> Seq.map ( fun s -> s.Split [|' '; '='|] )
        |> Seq.filter (fun l -> Seq.length l = 4)
        |> Array.ofSeq
        |> Array.map (fun l -> l[2], int l[3])

    let CountAfterFirstFold(input:seq<string>) =

        let fold = getFolds(input) |> Seq.head
        let paper = getPaper(input)
        let nFold = if fst fold = "y" then yFold else xFold
        
        nFold (snd fold, paper) |> Seq.cast<bool> |> Seq.filter ((=) true) |> Seq.length
        