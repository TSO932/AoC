namespace AoC2022

module Day02Part1 =

    type Choice =
        | Rock = 0
        | Paper = 1
        | Scissors = 2

    let GetOppenentsChoice (choice:char) =
        match choice with
        | 'A' -> Choice.Rock
        | 'B' -> Choice.Paper
        | _   -> Choice.Scissors

    let GetYourChoice (choice:char) =
        match choice with
        | 'X' -> Choice.Rock
        | 'Y' -> Choice.Paper
        | _   -> Choice.Scissors

    let GetChoices (turn:string) =
        ( GetOppenentsChoice turn[0] , GetYourChoice turn[2] )

    let GetScoreForShapeSelected (turn:Choice*Choice) =
        match snd turn with
        | Choice.Rock -> 1
        | Choice.Paper -> 2
        | _ -> 3

    let GetScoreForOutcome (turn:Choice*Choice) =
        match turn with
            | (Choice.Rock,     Choice.Rock) 
            | (Choice.Paper,    Choice.Paper)
            | (Choice.Scissors, Choice.Scissors) -> 3
            | (Choice.Rock,     Choice.Paper)
            | (Choice.Paper,    Choice.Scissors)
            | (Choice.Scissors, Choice.Rock) -> 6
            | _ -> 0

    let GetScore (turn:string) =
        let choices = GetChoices(turn)
        GetScoreForOutcome choices + GetScoreForShapeSelected choices

    let GetTotal (turns:seq<string>) =
        turns |> Seq.sumBy GetScore
