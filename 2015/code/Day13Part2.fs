namespace AoC2015

open System.Collections.Generic

module Day13Part2 =

    let findHappiestSeatingPlan(happinesses:seq<string>) =
        let happies = happinesses |> Seq.map Day13Part1.parsePeoplePairing

        let happiesWithMe = Day13Part1.getListOfPeople(happies) |> Seq.ofList |> Seq.map (fun p -> [(p, "me", 0); ("me", p, 0)]) |> Seq.concat |> Seq.append happies

        let peopleDic = Day13Part1.PeoplePairingDictionary()
        peopleDic.Populate(happiesWithMe)

        let getCirclePairs(people:seq<string>) =
            Seq.pairwise people |> Seq.append [(Seq.head people, Seq.last people)]

        CommonFunctions.permute(Day13Part1.getListOfPeople(happiesWithMe)) |> Seq.map (getCirclePairs >> (fun seqOfPairs -> seqOfPairs |> Seq.sumBy (fun ab -> peopleDic.Get(ab)))) |> Seq.max

        
                
               