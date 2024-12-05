namespace _2024

open System

module Day05Part1 =
    let getPageOrder(input:seq<string>) =

        let getPageNumbers(input:string) =
            let pages = input.Split '|'
            (pages[0], pages[1])

        let getFirst(pairs) =

            let afters = Seq.map snd pairs

            pairs
            |> Seq.map fst
            |> Seq.filter (fun p -> not (Seq.contains p afters))
            |> Seq.head

        let rec getSequence(pageOrder, pairs) =

            if Seq.length pairs = 0 then
                pageOrder
            else
                let firstPage = getFirst(pairs)
                let pages = Seq.append pageOrder [firstPage]             
                let rest = Seq.filter (fun (p, _) -> p <> firstPage) pairs
                getSequence(pages, rest)

        getSequence(Seq.empty, Seq.map getPageNumbers input)

    let getUpdatePack(input:string) = input.Split ','

    let getPack(pageOrder, pagesToInclude) =
        let sortedPack = Seq.filter (fun p -> (Seq.contains p pagesToInclude)) pageOrder
        
        let isOutOfOrder =
            (pagesToInclude, sortedPack)
            ||> Seq.zip
            |> Seq.exists (fun (a, b) -> a <> b)

        if isOutOfOrder then
            seq { "0" }
        else
            sortedPack
        
    let getMiddlePage(input) =
        let inputArray = Seq.toArray input
        inputArray[(Seq.length input) / 2]

    let run(input:seq<string>) =

        // let pagesNeeded =
        //     input
        //     |> Seq.filter (fun s -> s.Contains(","))
        //     |> Seq.map (fun s -> s.Split ',')
        //     |> Seq.concat
        //     |> Seq.distinct

        let pageOrder =
            input
            |> Seq.filter (fun s -> s.Contains("|"))
            // |> Seq.filter (fun s -> pagesNeeded |> Seq.exists (fun r -> s.Contains(r)))
            |> getPageOrder

        let getMiddleNumber(pack) =
            (pageOrder, pack)
            |> getPack
            |> getMiddlePage
            |> Int32.Parse

        input
        |> Seq.filter (fun s -> s.Contains(","))
        |> Seq.sumBy (getUpdatePack >> getMiddleNumber)