namespace AoC2015

module Day07Part2 =

     let getSignalValueA(instructions:seq<string>) =
          let sb = Day07Part1.SignalBoard()

          sb.ApplyInstructions(instructions |> Seq.map Day07Part1.parseInstruction)

          let seedB(instruction:string) =
               if instruction.[instruction.Length - 5..]  = " -> b" then
                    sb.GetSignalValue("a").ToString() + " -> b"
               else
                    instruction

          let sb2 = Day07Part1.SignalBoard()
          sb2.ApplyInstructions(instructions |> Seq.map (seedB >> Day07Part1.parseInstruction))
          sb2.GetSignalValue("a")