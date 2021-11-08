namespace AoC2015

open System
open System.Text.RegularExpressions

module Day11Part1 =

    let rec incrementPassword(oldPassword:string) =

        let passwordLength = String.length oldPassword
        
        if passwordLength = 0 then
            ""
        elif oldPassword.[passwordLength - 1] = 'z' then
            incrementPassword(oldPassword.[0 .. passwordLength - 2]) + "a"
        else
            let nextChar(oldChar:char) = Convert.ToChar(int oldChar + 1)
            Seq.append oldPassword.[0 .. passwordLength - 2] [|nextChar(oldPassword.[passwordLength - 1])|] |> Seq.toArray |> System.String

    let rec generatePassword(oldPassword:string, rule) =
        let newPassword = incrementPassword(oldPassword)
        if rule(newPassword) then
            newPassword
        else
            generatePassword(newPassword, rule)

    let isStraight(passwordFragment:seq<char>) =
        let charCodeArray = passwordFragment |> Seq.toArray |> Array.map int
        charCodeArray.[1] = charCodeArray.[0] + 1 && charCodeArray.[2] = charCodeArray.[1] + 1

    let ruleOne(password:string) =
        password |> Seq.windowed 3 |> Seq.exists (fun x -> isStraight(x))
    
    let ruleTwo(password:string) = not (Regex.IsMatch (password, "[iol]"))

    let ruleThree(password:string) =
        let firstMatch = Regex.Match(password, @"(.)\1+")
        if firstMatch.Success then
            Regex.IsMatch (password.[firstMatch.Index + 2..],  @"(.)\1+")
        else
           false

    let rules(password:string) = ruleOne(password) && ruleTwo(password) && ruleThree(password)

    let getNextPassword(password:string) = generatePassword (password,rules)
    