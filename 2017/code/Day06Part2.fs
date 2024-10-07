namespace AoC2017

module Day06Part2 =

    let findRepeat (banks: array<int>) =

        let rec redistribute (banksHistory: list<array<int>>, latestBanks: array<int>) =

            let newHistory = List.append banksHistory [ Array.copy latestBanks ]

            if List.contains latestBanks banksHistory then

                let firstOccurance =
                    banksHistory
                    |> Seq.mapi (fun i e -> (i, e = latestBanks))
                    |> Seq.filter snd
                    |> Seq.map fst
                    |> Seq.head

                let secondOccurance = List.length banksHistory

                secondOccurance - firstOccurance
            else
                redistribute (newHistory, Day06Part1.distibuteBlocks latestBanks)

        redistribute (List.empty, banks)

    let getAnswer (input: seq<string>) =
        (Seq.head input).Split '\t' |> Seq.map int |> Seq.toArray |> findRepeat
