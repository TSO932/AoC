namespace AoC2017

module Day04Part1 =

    let isValid(password:string) =
    
        let words = password.Split " "

        let wordCount = Seq.length words

        let uniqueWordCount =
            words
            |> Seq.distinct
            |> Seq.length

        wordCount = uniqueWordCount

    let countValidPasswords(passwords:seq<string>) =
        passwords
        |> Seq.filter isValid
        |> Seq.length