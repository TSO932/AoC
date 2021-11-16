namespace AoC2015

open System.Collections.Generic

module Day16Part1 =

    type Sue = {
        IdentityNumber:int
        Trait1:string
        Value1:int
        Trait2:string
        Value2:int
        Trait3:string
        Value3:int }

    let parseAuntSue(pair:string) =
        let splits = pair.[4..].Replace(",","").Replace(":","").Split [|' '|]
        { IdentityNumber = int splits.[0];
          Trait1 = splits.[1]; Value1 = int splits.[2];
          Trait2 = splits.[3]; Value2 = int splits.[4];
          Trait3 = splits.[5]; Value3 = int splits.[6] }

    let isTheRightSue(sue:Sue) =
        let sueMap = Map [
            ("children", 3);
            ("cats", 7);
            ("samoyeds", 2);
            ("pomeranians", 3);
            ("akitas", 0);
            ("vizslas", 0);
            ("goldfish", 5);
            ("trees", 3);
            ("cars", 2);
            ("perfumes", 1)]

        sueMap.TryFind(sue.Trait1) = Some sue.Value1 && sueMap.TryFind(sue.Trait2) = Some sue.Value2 && sueMap.TryFind(sue.Trait3) = Some sue.Value3, sue.IdentityNumber

    let findAuntSue(sues:seq<string>) =
        sues |> Seq.map parseAuntSue |> Seq.map isTheRightSue |> Seq.filter fst |> Seq.map snd |> Seq.head

        
