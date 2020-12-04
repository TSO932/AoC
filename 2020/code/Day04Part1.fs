namespace AoC2020

open  System.Text

module Day04Part1 =

    let formatCredentials(credentialFile:seq<string>) =
        let seasonalyFestiveDelimiter = "Ho! Ho! Ho!"
        let credentials =
            let cred1 = credentialFile |> Seq.map (fun x -> if x = "" then seasonalyFestiveDelimiter else x)
            let cred2 = cred1 |> Seq.fold (fun (acc:StringBuilder) cred -> acc.Append(cred).Append(" ")) (new StringBuilder())
            cred2.ToString().Split seasonalyFestiveDelimiter
        credentials

    let validateCredentials(credentials:seq<string>) =
        let requiredFields = ["byr:"; "iyr:"; "eyr:"; "hgt:"; "hcl:"; "ecl:"; "pid:"]

        let containsAllRequiredFields(credential:string) =
            requiredFields |> Seq.map (fun x -> credential.Contains x) |> Seq.contains false |> not
        
        credentials |> Seq.map (fun x -> if containsAllRequiredFields x then 1 else 0 ) |> Seq.sum 
       

    let runProgram (forestMap:seq<string>) =

        let isDebug = true
        
        0