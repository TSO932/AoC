namespace AoC2021

module Day11Part1 =

    type Octopus(energyLevel:int) = 
        let mutable energy = energyLevel
        let mutable flashCount  = 0
        let mutable hasFlashedThisStep = false

        let isFlashing() = energy >= 10 && not hasFlashedThisStep

        member this.IncreaseEnergy() =
            energy <- energy + 1

        member this.EndofSubStep() =
            if energy >= 10 && not hasFlashedThisStep then
                hasFlashedThisStep <- true
                flashCount <- flashCount + 1

        member this.EndOfStep() =
            if energy >= 10 then
                energy <- 0
            hasFlashedThisStep <- false

        member this.IsFlashing = isFlashing()
        member this.FlashCount = flashCount

        member this.incrementIfAFlashingNeighbour(v, h, afterArray:Octopus[,]) =

            if isFlashing() then
                let maxHeight = Array2D.length1 afterArray
                let maxWidth  = Array2D.length2 afterArray
                let locality = afterArray[(max 0 (h - 1))..(min maxHeight (h + 1)),(max 0 (v - 1))..(min maxWidth (v + 1))]
                locality |> Array2D.iter (fun o -> o.IncreaseEnergy())
                afterArray[h, v].EndofSubStep()

    type Octopuses(input:Octopus[,]) as self =
        
        let mutable octopuses = input
        
        member this.FlashCount = octopuses |> Array2D.map (fun o -> o.FlashCount) |> Seq.cast<int> |> Seq.sum

        member this.Step() =

            octopuses |> Array2D.iter (fun o -> o.IncreaseEnergy())

            let rec incrementNeighbours() =
                let output = Array2D.copy octopuses
       
                octopuses |> Array2D.iteri (fun h v c -> c.incrementIfAFlashingNeighbour(v, h, output))

                octopuses <- output
            
                if octopuses |> Array2D.map (fun o -> o.IsFlashing) |> Seq.cast<bool> |> Seq.exists ((=) true) then 
                    incrementNeighbours()
                else
                    output |> Array2D.iter (fun c -> c.EndOfStep())

            incrementNeighbours()                 

        member this.Steps(count:int) =
            for n in 1 .. count do
                self.Step()

        new( input:int[,]) = Octopuses( input |> Array2D.map (fun i -> Octopus(i) ) )

        new(input:seq<string>) =
        
            let arrays = input |> Seq.map (Array.ofSeq) |> Array.ofSeq
            let maxHeight = arrays.Length
            let maxWidth = arrays[0].Length
            Octopuses( Array2D.init maxHeight maxWidth (fun i j -> arrays[i][j]) |> Array2D.map ( fun c -> int (c.ToString()) ) )

    let run(input:seq<string>) =
        let octopuses = Octopuses(input)
        octopuses.Steps(100)
        octopuses.FlashCount