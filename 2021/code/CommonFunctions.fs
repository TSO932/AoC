namespace AoC2021

open System.Collections.Generic

module CommonFunctions =

    // https://stackoverflow.com/questions/1526046/f-permutations
    // https://www.ffconsultancy.com/products/fsharp_for_technical_computing/index.html?so

    let rec distribute e = function
    | [] -> [[e]]
    | x::xs' as xs -> (e::xs)::[for xs in distribute e xs' -> x::xs]

    let rec permute = function
    | [] -> [[]]
    | e::xs -> List.collect (distribute e) (permute xs)


    // http://www.fssnip.net/2z/title/All-combinations-of-list-elements
    
    let allCombinations lst =
        let rec comb accLst elemLst =
            match elemLst with
            | h::t ->
                let next = [h]::List.map (fun el -> h::el) accLst @ accLst
                comb next t
            | _ -> accLst
        comb [] lst


    // https://codereview.stackexchange.com/questions/167679/counting-letter-frequencies-from-an-input-file

    let countById64 xs =
        let counts = Dictionary<_,_>()
        for x in xs do
            match counts.TryGetValue x with
            | true,  c -> counts[x] <- c + 1L
            | false, _ -> counts[x] <- 1L
        counts
        |> Seq.map (fun (KeyValue kv) -> kv)