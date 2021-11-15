namespace AoC2015

open System.Collections.Generic

module Day13Part1 =

    let parsePeoplePairing(pair:string) =
        let splits = pair.Split [|' '|]
        splits.[0], splits.[10].[..splits.[10].Length - 2], (if splits.[2] = "gain" then 1 else -1) * int splits.[3]

    let getListOfPeople(people:seq<string*string*int>) =
        people |> Seq.map (fun (a, _, _) -> a) |> Seq.distinct |> List.ofSeq

    type PeoplePairingDictionary() =

        let dictionary = new Dictionary<string*string, int>()

        member _.Populate(happinesses:seq<string*string*int>) =
            happinesses |> Seq.iter (fun (a, b, d) -> dictionary.Add((a, b), d)) |> ignore

        member _.Get(a:string, b:string) =
            dictionary.[a, b] + dictionary.[b, a]

    let findHappiestSeatingPlan(happinesses:seq<string>) =
        let happies = happinesses |> Seq.map parsePeoplePairing

        let peopleDic = PeoplePairingDictionary()
        peopleDic.Populate(happies)

        let getCirclePairs(people:seq<string>) =
            Seq.pairwise people |> Seq.append [(Seq.head people, Seq.last people)]

        CommonFunctions.permute(getListOfPeople(happies)) |> Seq.map (getCirclePairs >> (fun seqOfPairs -> seqOfPairs |> Seq.sumBy (fun ab -> peopleDic.Get(ab)))) |> Seq.max

        
                
               