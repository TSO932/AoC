namespace AoC2022

module Day06Part1 =

    let isMarker (snippet:string) =

        if Seq.length snippet <> 4 then
            false
        else 
            let a = Array.ofSeq snippet
            a[0] <> a[1] && a[0] <> a[2] && a[0] <> a[3] && a[1] <> a[2] && a[1] <> a[3] && a[2] <> a[3]

    let FindPosition (signal:string) =

        let position = signal
                        |> Seq.mapi (fun i _ -> ( i, signal[ i-3 .. i ] ))
                        |> Seq.filter (fun (_, e) -> isMarker e)
                        |> Seq.head
                        |> fst

        position + 1
        