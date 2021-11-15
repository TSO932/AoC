namespace AoC2015

open System.Text.RegularExpressions

module Day08Part1 =

    let countNonLiterals (input:string) =

        let replaceSpecials(str:string) =

            if Regex.IsMatch (str, "^\\\\[\\\\\"].?") then //4 backslashes: 2 to escape in F#; 2 to escape in Regex
                1
            elif Regex.IsMatch (str, "^\\\\x[0-9a-f]{1}.?") then
                3
            else
                0

        let input2 = input.Replace ("\\\\", "\\\"") //avoids overcounting of double backslashes
        2 + (input2.[1..input.Length - 2] |> Seq.mapi (fun i _ -> input2.[i + 1..input.Length - 2]) |> Seq.sumBy replaceSpecials)

    let countCharacters(strings:seq<string>) =
        strings |> Seq.sumBy countNonLiterals
