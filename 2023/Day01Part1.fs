namespace _2023

module Day01Part1 =
    let findElfCarryingMostCalories (input: seq<string>) =
        input
        |> Seq.map Seq.toList
        |> Seq.map (Seq.filter (fun x -> x >= '0' && x <= '9'))
        |> Seq.map (fun q -> (q |> Seq.head |> System.Char.ToString ) + (q |> Seq.rev |> Seq.head |> System.Char.ToString))
        |> Seq.sumBy System.Int32.Parse
        
        // + (Seq.rev >> Seq.head))



