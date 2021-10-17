namespace AoC2015

open System.Collections.Generic

module Day09Part1 =

    let parseDistance(distance:string) =
        let splits = distance.Split [|' '|]
        splits.[0], splits.[2], int splits.[4]

    let getListOfCities(distances:seq<string*string*int>) =
        distances |> Seq.map (fun (a, b, _) -> [ a ; b ]) |> Seq.concat |> Seq.distinct |> List.ofSeq

    let getDictionaryOfDistances(distances:seq<string*string*int>) =

        distances |> Seq.map (fun (a, b, _) -> [ a ; b ]) |> Seq.concat |> Seq.distinct

    type DistanceDictionary() =

        let dictionary = new Dictionary<string*string, int>()

        member _.Populate(distances:seq<string*string*int>) =
            distances |> Seq.iter (fun (a, b, d) -> dictionary.Add((a, b), d)) |> ignore

        member _.Get(a:string, b:string) =
           match dictionary.TryGetValue ((a, b)) with
                | true, result -> result
                | _            -> dictionary.[(b, a)]

    let findShortestDistance(distances:seq<string>) =
        let dists = distances |> Seq.map parseDistance

        let distDic = new DistanceDictionary()
        distDic.Populate(dists)

        let rec distribute e = function
        | [] -> [[e]]
        | x::xs' as xs -> (e::xs)::[for xs in distribute e xs' -> x::xs]

        let rec permute = function
        | [] -> [[]]
        | e::xs -> List.collect (distribute e) (permute xs)

        permute(getListOfCities(dists)) |> Seq.map ((fun route -> Seq.pairwise route ) >> (fun seqOfPairs -> seqOfPairs |> Seq.sumBy (fun ab -> distDic.Get(ab)))) |> Seq.min

        
                
               