namespace AoC2015

open System.Collections.Generic

module Day16Part2 =

    let isTheRightSue(sue:Day16Part1.Sue) =
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

        let checkTrait(t:string,v:int) =
            match t with
                | "cats"
                | "trees"       -> v > sueMap.[t]
                | "pomeranians"
                | "goldfish"    -> v < sueMap.[t]
                | _             -> v = sueMap.[t]

        checkTrait(sue.Trait1, sue.Value1) && checkTrait(sue.Trait2, sue.Value2) && checkTrait(sue.Trait3, sue.Value3), sue.IdentityNumber

    let findAuntSue(sues:seq<string>) =
        sues |> Seq.map Day16Part1.parseAuntSue |> Seq.map isTheRightSue |> Seq.filter fst |> Seq.map snd |> Seq.head

        
