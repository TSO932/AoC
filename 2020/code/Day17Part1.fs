namespace AoC2020

open System

module Day17Part1 =
    let countActiveCells (initalState:seq<string>) =

        let isDebug = false
        let numberOfRounds = 6

        let initalSquareSize = Seq.length initalState
        let arrays = (Seq.map (Array.ofSeq) initalState) |> Array.ofSeq
        
        let experimentalEnergySource = Array3D.zeroCreate (initalSquareSize + 2 * numberOfRounds) (initalSquareSize + 2 * numberOfRounds) (1 + 2 * numberOfRounds)
        
        for x in seq {0..(initalSquareSize - 1)} do
            for y in seq {0..(initalSquareSize - 1)} do
                experimentalEnergySource.[x + numberOfRounds, y + numberOfRounds, numberOfRounds] <- if arrays.[y].[x] = '#' then 1 else 0

        let rec cycle(energySource:int[,,], rounds:int) =
            if isDebug then printfn "(%i) %i" rounds (energySource |> Seq.cast<int> |> Seq.sum)
            if rounds = 0 then 
                energySource
            else
                let changeState(x:int, y:int, z:int, i:int) =
                    match energySource.[(x - 1)..(x + 1), (y - 1)..(y + 1), (z - 1)..(z + 1)] |> Seq.cast<int> |> Seq.sum with
                        | 4 -> if i = 1 then 1 else 0
                        | 3 -> 1
                        | _ -> 0

                cycle (energySource |> Array3D.mapi (fun x y z i -> changeState(x, y, z, i)), rounds - 1) 
        
        cycle(experimentalEnergySource, numberOfRounds) |> Seq.cast<int> |> Seq.sum

