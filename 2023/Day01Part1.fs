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
                                // .Replace("oneight", "180")
                                // .Replace("threeight", "38")
                                // .Replace("fiveight", "58")
                                // .Replace("nineight", "98")
                                // .Replace("eightwo", "82")
                                // .Replace("eighthree","83")
                                // .Replace("twone", "21")
                                // .Replace("sevenine","79")                              
                                .Replace("one", "one1one")
                                .Replace("two", "two2two")
                                .Replace("three", "three3three")
                                .Replace("four", "four4four")
                                .Replace("five", "five5five")
                                .Replace("six", "six6six")
                                .Replace("seven", "seven7seven")
                                .Replace("eight", "eight8eight")
                                .Replace("nine", "nine9nine"))
                                // .Replace("zero", "0"))

        |> Seq.map Seq.toList
        |> Seq.map (Seq.filter (fun x -> x >= '0' && x <= '9'))
        |> Seq.map (fun q -> (q |> Seq.head |> System.Char.ToString ) + (q |> Seq.rev |> Seq.head |> System.Char.ToString))
        |> Seq.sumBy System.Int32.Parse


