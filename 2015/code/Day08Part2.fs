namespace AoC2015

open System.Text.RegularExpressions

module Day08Part2 =

    let countCharacters(strings:seq<string>) =

       2 * (Seq.length strings) + ( strings |> String.concat "" |> Array.ofSeq |> Array.filter (fun c -> c = '"' || c = '\\') |> Array.length )
   