namespace AoC2020

module Day10Part2 =
    let calculate (adapters:seq<string>) =

        let chain = adapters |> Seq.map int |> Seq.sort |> Seq.append (seq {0})

        let chainMuncher(chain:int64*seq<int>) =
            if snd chain |> Seq.length > 1 then
                let head = snd chain |> Seq.head
                snd chain |> Seq.filter (fun x -> x > head && x <= head + 3) |> Seq.map (fun x -> (fst chain, (snd chain |> Seq.filter (fun y -> y >= x))))
            else
                seq {chain}
            
        let rec chainsRUs(chains:seq<int64*seq<int>>) =
            if chains |> Seq.exists (fun c -> snd c |> Seq.length > 1) then
                chainsRUs (chains |> Seq.collect chainMuncher |> Seq.groupBy (fun c -> snd c |> Seq.head) |> Seq.map (fun (a, b) -> (b |> Seq.sumBy (fun x -> fst x), b |> Seq.head |> snd)))
            else
                chains
        
        chainsRUs (seq {(1L, chain)}) |> Seq.head |> fst