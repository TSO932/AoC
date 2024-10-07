namespace AoC2017

module Day06Part1 =

    let distibuteBlocks (banks: array<int>) =

        let numberOfBanks = Array.length banks

        let (maxIndex, maxValue) = banks |> Array.mapi (fun i n -> i, n) |> Array.maxBy snd

        let valueToAdd = banks[maxIndex] / numberOfBanks
        let remainder = banks[maxIndex] % numberOfBanks

        Array.set banks maxIndex 0

        let nextIndex(currentIndex) = 
            if currentIndex >= numberOfBanks - 1 then
                0
            else
                currentIndex + 1

        let rec addValues(currentIndex, rem) =
            if rem = 0 then
                ignore
            else
                Array.set banks currentIndex (banks[currentIndex] + 1)
                addValues(nextIndex(currentIndex), rem - 1)

        addValues(nextIndex(maxIndex), remainder) |> ignore

        banks |> Array.map (fun n -> n + valueToAdd)

    let findRepeat (banks: array<int>) =

        let rec redistribute(banksHistory:list<array<int>>, latestBanks:array<int>) =

            let newHistory = List.append banksHistory [Array.copy latestBanks]

            if List.contains latestBanks banksHistory then
                List.length banksHistory
            else
                redistribute (newHistory, distibuteBlocks latestBanks)

        redistribute (List.empty, banks)

    let getAnswer (input:seq<string>) =
        (Seq.head input).Split '\t'
        |> Seq.map int
        |> Seq.toArray
        |> findRepeat
