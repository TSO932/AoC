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

          let isReady(instr:Instruction) =

               let isKnownValue(input:string) = fst (UInt16.TryParse input) || fst (signals.TryGetValue input)

               match instr.op with
                    | "AND" | "OR" -> isKnownValue instr.in1 && isKnownValue instr.in2
                    | _                           -> isKnownValue instr.in1

          member _.GetSignalValue(signal:string) =
               match signals.TryGetValue (signal) with
               | true, result -> result
               | _            -> 0us

          member this.ApplyInstruction(instruction:Instruction) =
  
               let getVal(input:string) =
                    match UInt16.TryParse input with
                    | true, result -> result
                    | _            -> this.GetSignalValue(input)

               let outVal = match instruction.op with
                              | "NOT"     -> ~~~ getVal(instruction.in1)
                              | "AND"     -> getVal(instruction.in1) &&& getVal(instruction.in2)
                              | "OR"      -> getVal(instruction.in1) ||| getVal(instruction.in2)
                              | "LSHIFT"  -> getVal(instruction.in1) <<< int instruction.in2
                              | "RSHIFT"  -> getVal(instruction.in1) >>> int instruction.in2
                              | _         -> getVal(instruction.in1)

               signals.Remove(instruction.out) |> ignore
               signals.Add(instruction.out, outVal)

          member this.ApplyInstructions(instructions:seq<Instruction>) =

               let rec applyInstr(remainingInstructions:seq<Instruction>) =
                    if remainingInstructions |> Seq.isEmpty |> not then
                         let readyInstructions = remainingInstructions |> Seq.groupBy isReady |> Seq.filter fst |> Seq.collect snd |> Set.ofSeq
                         readyInstructions |> Seq.iter this.ApplyInstruction
                         remainingInstructions |> Seq.filter (fun i -> Seq.contains i readyInstructions |> not) |> applyInstr
               
               applyInstr instructions

     let getSignalValueA(instructions:seq<string>) =
          let sb = SignalBoard()

          sb.ApplyInstructions(instructions |> Seq.map parseInstruction)
          sb.GetSignalValue("a")
          
