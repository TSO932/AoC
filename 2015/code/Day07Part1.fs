namespace AoC2015

open System
open System.Collections.Generic

module Day07Part1 =

     type Instruction =
       {  Op:string
          In1:string
          In2:string
          Out:string }
          
     let parseInstruction(instruction:string) =
          let splits = instruction.Split [|' '|]
          match splits.Length with
          | 3 -> { Op = "" ; In1 = splits.[0] ; In2 = "" ; Out = splits.[2] }
          | 4 -> { Op = splits.[0] ; In1 = splits.[1] ; In2 = "" ; Out = splits.[3] }
          | _ -> { Op = splits.[1] ; In1 = splits.[0] ; In2 = splits.[2] ; Out = splits.[4] }

     type SignalBoard() =
          let signals = new Dictionary<string, uint16>()

          let isReady(instr:Instruction) =

               let isKnownValue(input:string) = fst (UInt16.TryParse input) || fst (signals.TryGetValue input)

               match instr.Op with
                    | "AND" | "OR" -> isKnownValue instr.In1 && isKnownValue instr.In2
                    | _                           -> isKnownValue instr.In1

          member _.GetSignalValue(signal:string) =
               match signals.TryGetValue (signal) with
               | true, result -> result
               | _            -> 0us

          member _.ApplyInstruction(instruction:Instruction) =
  
               let getVal(input:string) =
                    match UInt16.TryParse input with
                    | true, result -> result
                    | _            -> signals.[input]

               let outVal = match instruction.Op with
                              | "NOT"     -> ~~~ getVal(instruction.In1)
                              | "AND"     -> getVal(instruction.In1) &&& getVal(instruction.In2)
                              | "OR"      -> getVal(instruction.In1) ||| getVal(instruction.In2)
                              | "LSHIFT"  -> getVal(instruction.In1) <<< int instruction.In2
                              | "RSHIFT"  -> getVal(instruction.In1) >>> int instruction.In2
                              | _         -> getVal(instruction.In1)

               signals.Remove(instruction.Out) |> ignore
               signals.Add(instruction.Out, outVal)

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
          
