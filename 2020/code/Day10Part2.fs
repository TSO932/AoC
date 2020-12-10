namespace AoC2020

module Day10Part2 =
    let calculate (adapters:seq<string>) =

        let chain = adapters |> Seq.map int |> Seq.sort |> Seq.append (seq {0})
        // let chain2 = chain |> Seq.rev |> Seq.append (seq {(chain |> Seq.rev |> Seq.head) + 3}) |> Seq.rev

        let chainMuncher(chain:seq<int>) =
            if chain |> Seq.length > 1 then
                let head = chain |> Seq.head
                chain |> Seq.filter (fun x -> x > head && x <= head + 3) |> Seq.map (fun x -> (chain |> Seq.filter (fun y -> y >= x)))
            else
                seq {chain}
            
        let rec chainsRUs(chains:seq<seq<int>>) =
            if chains |> Seq.exists (fun c -> c |> Seq.length > 1) then
                chainsRUs (chains |> Seq.collect chainMuncher)
            else
                chains
        
        chainsRUs (seq {chain}) |> Seq.length