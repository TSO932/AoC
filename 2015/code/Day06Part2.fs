namespace AoC2015

module Day06Part2 =

     type Instruction =
       {  Op:string
          X1:int
          Y1:int
          X2:int
          Y2:int }
          
          member this.IsInRange(i:int, j:int) =
               i >= this.X1 && i <= this.X2 && j >= this.Y1 && j <= this.Y2

          member this.AdjustBrightness(brigtness:int) =
               match this.Op with
               | "on" -> brigtness + 1
               | "off" -> max 0 (brigtness - 1) 
               | _    -> brigtness + 2

     let switch(inst:Instruction) = 
          Array2D.mapi (fun i j x -> if inst.IsInRange(i, j) then inst.AdjustBrightness(x) else x)

     let countOnLights(a:int[,]) = 
          a |> Seq.cast<int> |> Seq.sum

     let parseInstruction(instruction:string) =
          let splits = instruction.[5..].Split [|' '; ','|]
          { Op = splits.[0] ; X1 = int splits.[1] ; Y1 = int splits.[2] ; X2 = int splits.[4] ; Y2 = int splits.[5] }

     let followInstructions(instructions:seq<string>) =
          instructions |> Seq.fold  (fun grid inst -> switch (parseInstruction inst) grid) (Array2D.create 1000 1000 0) |> countOnLights