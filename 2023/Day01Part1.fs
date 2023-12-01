namespace _2023

module Day01Part1 =
    let findElfCarryingMostCalories (input: seq<string>) =
        input
        |> Seq.map Seq.toList
        |> Seq.map (Seq.filter (fun x -> x >= '0' && x <= '9'))
        |> Seq.map (fun q -> (q |> Seq.head |> System.Char.ToString ) + (q |> Seq.rev |> Seq.head |> System.Char.ToString))
        |> Seq.sumBy System.Int32.Parse

    let findElfCarryingMostCalories2 (input: seq<string>) =
        input
        |> Seq.map (fun x -> x
                                .Replace("oneight", "1ight")
                                .Replace("threeight", "3ight")
                                .Replace("fiveight", "5ight")
                                .Replace("nineight", "9ight")
                                .Replace("eightwo", "8wo")
                                .Replace("eighthree","8hree")
                                .Replace("twone", "2ne")
                                .Replace("sevenine","7ine")
                                .Replace("one", "1")
                                .Replace("two", "2")
                                .Replace("three", "3")
                                .Replace("four", "4")
                                .Replace("five", "5")
                                .Replace("six", "6")
                                .Replace("seven", "7")
                                .Replace("eight", "8")
                                .Replace("nine", "9"))
                                // .Replace("zero", "0"))

        |> Seq.map Seq.toList
        |> Seq.map (Seq.filter (fun x -> x >= '0' && x <= '9'))
        |> Seq.map (fun q -> (q |> Seq.head |> System.Char.ToString ) + (q |> Seq.rev |> Seq.head |> System.Char.ToString))
        |> Seq.sumBy System.Int32.Parse


