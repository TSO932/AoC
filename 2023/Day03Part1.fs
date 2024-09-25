namespace _2023

module Day03Part1 =

    let getNumber (line:char[], x) =

        let digits = [|'0'; '1'; '2'; '3'; '4'; '5'; '6'; '7'; '8'; '9'|]

        let leftSide = if x > 0 then line[0 .. x - 1] else Array.empty

        let leftDigits =
            match leftSide |> Array.tryFindIndexBack (fun c -> not (Array.contains c digits)) with
            | Some index -> leftSide[index + 1 .. Array.length leftSide - 1]
            | None -> leftSide

        let lineLength = Array.length line
        let rightSide = if x < lineLength - 1 then line[x + 1 .. lineLength - 1] else Array.empty

        let rightDigits =
            match rightSide |> Array.tryFindIndex (fun c -> not (Array.contains c digits)) with
            | Some index -> rightSide[0 .. index - 1]
            | None -> rightSide

        if Array.contains line[x] digits then

            rightDigits
            |> Array.append line[x .. x]
            |> Array.append leftDigits
            |> System.String
            |> int

        else
            let GetNumber digitChars =
                digitChars
                |> Array.append [|'0'|]
                |> System.String
                |> int
            
            GetNumber leftDigits + GetNumber rightDigits

    let getPartNumberForPartSymbol(schematic:char[,], x, y, symb:char) =

        if "0123456789.".Contains symb then
            0
        else
            getNumber(schematic[x - 1, *], y)
            + getNumber(schematic[x , *], y)
            + getNumber(schematic[x + 1, *], y)

    let getSum input =
        let schematic = input |> array2D

        schematic
        |> Array2D.mapi (fun x y v -> getPartNumberForPartSymbol (schematic, x, y, v))
        |> Seq.cast<int>
        |> Seq.sum

