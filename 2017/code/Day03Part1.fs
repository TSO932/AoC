namespace AoC2017

module Day03Part1 =
    let walk (cell) =

        let ring =

            let rec getRing (ring) =

                if cell <= ring * ring then ring else getRing (ring + 2)

            getRing (1)

        let secondLeg = (ring - 1) / 2

        let firstLeg =
            let innerRingArea = (ring - 2) * (ring - 2)
            let eighthOfPerimeterOfRing = (ring * ring - innerRingArea) / 8
            let lengthInOuterSquare = cell - innerRingArea

            // The nearest points are 1/8, 3/8, 5/8 and 7/8 of the way round the outer square.

            seq { 1..2..7 }
            |> Seq.map (fun n -> abs (lengthInOuterSquare - n * eighthOfPerimeterOfRing))
            |> Seq.min

        // Worst case, first leg is the same length as the second leg.

        firstLeg + secondLeg

    let getDistance (input: seq<string>) = input |> Seq.head |> int |> walk
