namespace AoC2015

open System.Security.Cryptography
open System.Text

module Day04Part1 =

    let getHash (input:string) =

        use md5 = MD5.Create()
        (StringBuilder(), md5.ComputeHash(Encoding.UTF8.GetBytes(input))) ||> Array.fold (fun sb1 b -> sb1.Append(b.ToString("x2"))) |> string


    let isValid (input:string) =
        input.[..4] = "00000"

    let getAdventCoin (input:seq<string>) =

         let rec findAdventCoin(secretKey:string, deci:int) =
            if isValid(getHash(secretKey + string deci)) then
                deci
            else
                findAdventCoin(secretKey, deci + 1)

         findAdventCoin(input |> Array.ofSeq |> Array.head, 0)



    