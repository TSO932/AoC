namespace AoC2017

open System

module Day04Part2 =

    let isValid(password:string) =

        let words =
            password.Split " "
            |> Seq.map Seq.sort
            |> Seq.map String.Concat
        
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