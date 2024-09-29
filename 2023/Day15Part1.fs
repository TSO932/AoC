namespace _2023

module Day15Part1 =

    let runAlgoritm (input: string) =
        
        input
        |> Seq.map int
        |> Seq.fold (fun a c -> ((a + c) * 17) % 256) 0

    let getSum(input:string) =

        input.Split ","
        |> Seq.sumBy runAlgoritm