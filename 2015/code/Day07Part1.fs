namespace AoC2015

open System
open System.Collections.Generic

module Day07Part1 =

     type Instruction =
       {  op:string
          in1:string
          in2:string
          out:string }
          
     let parseInstruction(instruction:string) =
          let splits = instruction.Split [|' '|]
          match splits.Length with
          | 3 -> { op = "" ; in1 = splits.[0] ; in2 = "" ; out = splits.[2] }
          | 4 -> { op = splits.[0] ; in1 = splits.[1] ; in2 = "" ; out = splits.[3] }
          | _ -> { op = splits.[1] ; in1 = splits.[0] ; in2 = splits.[2] ; out = splits.[4] }

     type SignalBoard() =
          let signals = new Dictionary<string, uint16>()

          member _.GetSignalValue(signal:string) =
               match signals.TryGetValue (signal) with
               | true, result -> result
               | _            -> 0us

          member this.ApplyInstruction(instruction:string) =
  
               let getVal(input:string) =
                    match UInt16.TryParse input with
                    | true, result -> result
                    | _            -> this.GetSignalValue(input)

               let instr = parseInstruction(instruction)

               let outVal = match instr.op with
                              | "NOT"     -> ~~~ getVal(instr.in1)
                              | "AND"     -> getVal(instr.in1) &&& getVal(instr.in2)
                              | "OR"      -> getVal(instr.in1) ||| getVal(instr.in2)
                              | "LSHIFT"  -> getVal(instr.in1) <<< int instr.in2
                              | "RSHIFT"  -> getVal(instr.in1) >>> int instr.in2
                              | _         -> getVal(instr.in1)

               signals.Remove(instr.out) |> ignore
               signals.Add(instr.out, outVal)

          member this.ApplyInstructions(instructions:seq<string>) =
               instructions |> Seq.iter this.ApplyInstruction

     let getSignalValueA(instructions:seq<string>) =
          let sb = SignalBoard()
          sb.ApplyInstructions(instructions)
          sb.GetSignalValue("a")
          
