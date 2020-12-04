namespace AoC2020

open  System
open  System.Text
open System.Text.RegularExpressions

module Day04Part2 =

    let validateCredential(credential:string) =
        let validate(cred:seq<string>) =
            let value = Seq.tail cred |> Seq.head
            match Seq.head cred with
                | "byr" -> value.Length = 4 && Regex.IsMatch (value, @"(19[2-9][0-9])|(200[0-2])")
                | "iyr" -> value.Length = 4 &&  Regex.IsMatch (value, @"20(1[0-9]|20)")
                | "eyr" -> value.Length = 4 && Regex.IsMatch (value, @"20(2[0-9]|30)")
                | "hgt" -> value.Length <= 5 && Regex.IsMatch (value, @"(1[5-8][0-9]|19[0-3])cm|(59|6[0-9]|7[0-6])in")
                | "hcl" -> value.Length = 7 && Regex.IsMatch (value, @"^#([0-9]|[a-f]){6}$")
                | "ecl" -> value.Length = 3 && match value with
                                                | "amb" | "blu" | "brn" | "gry" | "grn" | "hzl" | "oth" -> true
                                                | _ -> false
                | "pid" -> value.Length = 9 && Regex.IsMatch (value, @"[0-9]{9}")
                | _     -> true

        credential.Split(' ', StringSplitOptions.RemoveEmptyEntries) |> Seq.map (fun x -> x.Split ':') |> Seq.map validate |> Seq.contains false |> not

    let validateCredentials(credentials:seq<string>) =
        let requiredFields = ["byr:"; "iyr:"; "eyr:"; "hgt:"; "hcl:"; "ecl:"; "pid:"]

        let containsAllRequiredFields(credential:string) =
            requiredFields |> Seq.map (fun x -> credential.Contains x) |> Seq.contains false |> not
        
        credentials |> Seq.filter containsAllRequiredFields |> Seq.map (fun x -> if validateCredential x then 1 else 0 ) |> Seq.sum  