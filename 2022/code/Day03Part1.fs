namespace AoC2022

module Day03Part1 =

    let GetCommonCharacter (backpack:string) =

        let compartments = backpack |> Seq.splitInto 2 |> Array.ofSeq

        compartments.[0]
            |> Seq.filter (fun c -> Seq.exists (fun c1 -> c1 = c) compartments.[1])
            |> Seq.head

    let GetPriority (item:char) =

        let charCode = int item
        
        if charCode > 96 then
            charCode - 96
        else
            charCode - 38

    let GetSumOfPriorities (backpacks:seq<string>) =

        backpacks |> Seq.sumBy (fun backpack -> backpack |> GetCommonCharacter |> GetPriority)