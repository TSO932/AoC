namespace AoC2022

module Day02Part2 =

    type Choice =
        | Rock = 0
        | Paper = 1
        | Scissors = 2

    type Outcome =
        | Lose = 'X'
        | Draw = 'Y'
        | Win = 'Z'

    let GetOppenentsChoice (choice:char) =
        match choice with
        | 'A' -> Choice.Rock
        | 'B' -> Choice.Paper
        | _   -> Choice.Scissors

    let GetOutcome (choice:char) =
        match choice with
        | 'X' -> Outcome.Lose
        | 'Y' -> Outcome.Draw
        | _   -> Outcome.Win

    let GetChoiceAndOutcome (turn:string) =
        ( GetOppenentsChoice turn[0] , GetOutcome turn[2] )

    let GetScore (turn:string) =
    
        let choiceAndOutcome = GetChoiceAndOutcome(turn)

        match choiceAndOutcome with
            | (Choice.Rock,     Outcome.Lose) -> 3
            | (Choice.Paper,    Outcome.Lose) -> 1
            | (Choice.Scissors, Outcome.Lose) -> 2
            | (Choice.Rock,     Outcome.Draw) -> 4
            | (Choice.Paper,    Outcome.Draw) -> 5
            | (Choice.Scissors, Outcome.Draw) -> 6
            | (Choice.Rock,     Outcome.Win)  -> 8
            | (Choice.Paper,    Outcome.Win)  -> 9
            | _                               -> 7

    let GetTotal (turns:seq<string>) =
        turns |> Seq.sumBy GetScore
