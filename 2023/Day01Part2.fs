namespace _2023

module Day01Part2 =

    let calibrate (input: seq<string>) =
        input
        |> Seq.map (fun x -> x
                                .Replace("one", "o1e")
                                .Replace("two", "t2o")
                                .Replace("three", "t3e")
                                .Replace("four", "4")
                                .Replace("five", "5e")
                                .Replace("six", "6")
                                .Replace("seven", "7n")
                                .Replace("eight", "e8t")
                                .Replace("nine", "n9e"))
        |> Seq.map Seq.toList
        |> Seq.map (Seq.filter (fun x -> x >= '0' && x <= '9'))
        |> Seq.map (fun q -> (q |> Seq.head |> System.Char.ToString ) + (q |> Seq.rev |> Seq.head |> System.Char.ToString))
        |> Seq.sumBy System.Int32.Parse


