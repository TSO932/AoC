namespace AoC2020

module Day10Part2 =
    let calculate (adapters:seq<string>) =

        let chain = adapters |> Seq.map int |> Seq.sort |> Seq.rev
        let chain2 = chain |> Seq.append (seq {(chain |> Seq.head) + 3})

        let bit(elem) =
            let a = (chain2 |> Seq.filter (fun x -> x > elem && x < elem + 4) |> Seq.length)
            // printfn "%i %i" elem a
            a

        let foldingChain = chain |> Seq.fold (fun acc elem -> acc * bit(elem)) 1
        
        
        foldingChain