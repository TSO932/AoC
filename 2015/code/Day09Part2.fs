namespace AoC2015

open System.Collections.Generic

module Day09Part2 =

    let findLongestDistance(distances:seq<string>) =
        let dists = distances |> Seq.map Day09Part1.parseDistance

        let distDic = new Day09Part1.DistanceDictionary()
        distDic.Populate(dists)

        let rec distribute e = function
        | [] -> [[e]]
        | x::xs' as xs -> (e::xs)::[for xs in distribute e xs' -> x::xs]

        let rec permute = function
        | [] -> [[]]
        | e::xs -> List.collect (distribute e) (permute xs)

        permute(Day09Part1.getListOfCities(dists)) |> Seq.map ((fun route -> Seq.pairwise route ) >> (fun seqOfPairs -> seqOfPairs |> Seq.sumBy (fun ab -> distDic.Get(ab)))) |> Seq.max

        
                
               