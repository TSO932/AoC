namespace AoC2015

open System.Text.RegularExpressions

module Day06Part1 =

     type instruction =
       {  op:string
          x1:int
          y1:int
          x2:int
          y2:int }
          
          member this.isInRange(i:int, j:int) =
               i >= this.x1 && i <= this.x2 && j >= this.y1 && j <= this.y2

          member this.isOn(wasOn:bool) =
               match this.op with
               | "on" -> true
               | "off" -> false
               | _    -> not wasOn

     let switch(inst:instruction) = 
          Array2D.mapi (fun i j x -> if inst.isInRange(i, j) then inst.isOn(x) else x)

     let countOnLights(a:bool[,]) = 
          a |> Seq.cast<bool> |> Seq.filter (fun b -> b = true) |> Seq.length

     let parseInstruction(instruction:string) =
          let splits = instruction.[5..].Split [|' '; ','|]
          { op = splits.[0] ; x1 = int splits.[1] ; y1 = int splits.[2] ; x2 = int splits.[4] ; y2 = int splits.[5] }

     let followInstructions(instructions:seq<string>) =
          instructions |> Seq.fold  (fun grid inst -> switch (parseInstruction inst) grid) (Array2D.create 1000 1000 false) |> countOnLights