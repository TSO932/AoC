namespace AoC2015

module Day09Part2 =

    let findLongestDistance(distances:seq<string>) =
        let dists = distances |> Seq.map Day09Part1.parseDistance

        let distDic = Day09Part1.DistanceDictionary()
        distDic.Populate(dists)

        CommonFunctions.permute(Day09Part1.getListOfCities(dists)) |> Seq.map (Seq.pairwise >> (fun seqOfPairs -> seqOfPairs |> Seq.sumBy (fun ab -> distDic.Get(ab)))) |> Seq.max

        
                
               