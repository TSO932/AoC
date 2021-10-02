namespace AoC2015

open System.Text.RegularExpressions

module Day06Part2 =

     type instruction =
       {  op:string
          x1:int
          y1:int
          x2:int
          y2:int }
          
          member this.isInRange(i:int, j:int) =
               i >= this.x1 && i <= this.x2 && j >= this.y1 && j <= this.y2

          member this.adjustBrightness(brigtness:int) =
               match this.op with
               | "on" -> brigtness + 1
               | "off" -> max 0 (brigtness - 1) 
               | _    -> brigtness + 2

     let switch(inst:instruction) = 
          Array2D.mapi (fun i j x -> if inst.isInRange(i, j) then inst.adjustBrightness(x) else x)

     let countOnLights(a:int[,]) = 
          a |> Seq.cast<int> |> Seq.sum

     let parseInstruction(instruction:string) =
          let splits = instruction.[5..].Split [|' '; ','|]
          { op = splits.[0] ; x1 = int splits.[1] ; y1 = int splits.[2] ; x2 = int splits.[4] ; y2 = int splits.[5] }

     let followInstructions(instructions:seq<string>) =
          instructions |> Seq.fold  (fun grid inst -> switch (parseInstruction inst) grid) (Array2D.create 1000 1000 0) |> countOnLights