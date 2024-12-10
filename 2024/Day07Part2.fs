namespace _2024

open System

module Day07Part2 =

    let splitter(inputLine:string) =
        
        let values = inputLine.Split([|" "; ":"|], StringSplitOptions.RemoveEmptyEntries)

        let validValue = values |> Seq.head |> Int64.Parse

        let inputValues = values |> Seq.tail

        let varients =

            let addNext(acc:seq<seq<seq<string>>>, value:string) =
                let addN(acc1:seq<seq<string>>) =
                    let seperate = Seq.append acc1 [[value]]
                    let together =
                        let revSeq = Seq.rev acc1
                        let lastOne = Seq.head revSeq
                        let prevOnes = revSeq |> Seq.tail |> Seq.rev

                        let lastOne1 =
                            [value]
                            |> Seq.append lastOne

                        [lastOne1]
                        |> Seq.append prevOnes

                    [seperate; together]

                acc
                |> Seq.map addN
                |> Seq.concat
     
            (seq{seq {seq {Seq.head inputValues}}}, Seq.tail inputValues)
            ||> Seq.fold (fun acc value -> addNext(acc, value))
            |> Seq.map (Seq.map (Seq.map Int64.Parse))

        (validValue, varients)

    let peiceTogether(input:seq<seq<seq<string>>>) =

        let peice(input:seq<seq<string>>) =

            let buildString(a:string, b:string) = (a + b).ToString()

            (seq {""}, input)
            ||> Seq.fold (fun acc vals -> acc |> Seq.map (fun a -> vals |> Seq.map (fun v -> buildString(a,v))) |> Seq.concat)

        input
        |> Seq.map peice
        |> Seq.map (fun s -> s |> Seq.map Int64.Parse)
        |> Seq.concat
        
    let getValidValue(inputLine:string) =

        let (validValue, inputValues) = splitter(inputLine)

        let tryVarient(inputVals) =

            let calculatePeice(inputV:seq<int64>) =
                (seq {Seq.head inputV}, Seq.tail inputV)
                ||> Seq.fold (fun acc value -> acc |> Seq.map (fun a -> [a + value; a * value]) |> Seq.concat)

            let convertToString(inputV:seq<int64>) =
                inputV
                |> Seq.map (fun v -> v.ToString())

            inputVals
            |> Seq.map (calculatePeice >> convertToString)

        inputValues
        |> Seq.map tryVarient
        |> peiceTogether
        |> Seq.contains validValue
        |> fun b -> if b then validValue else 0L

    let run(input:seq<String>) = 0


