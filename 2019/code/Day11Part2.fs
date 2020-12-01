namespace AoC2019

module Day11Part2 =
    let isDebug = false
    let isPartOne = true

    let printOutput(locationsPainted) =
        let locationsToPlot = locationsPainted |> Map.toSeq |> Seq.map fst
        let minX = locationsToPlot |> Seq.minBy fst |> fst
        let maxX = locationsToPlot |> Seq.maxBy fst |> fst
        let minY = locationsToPlot |> Seq.minBy snd |> snd
        let maxY = locationsToPlot |> Seq.maxBy snd |> snd
        for j = minY to maxY do
            for i = minX to maxX do
                let colour = match locationsPainted.TryFind ((i, j)) with
                                | Some x -> if x = 1L then "#" else " "
                                | None -> " "
                printf "%s"colour
            
            printfn ""

        printfn  "all %i white %i" locationsPainted.Count (locationsPainted |> Map.filter (fun _ v -> v = 1L) |> Map.count)

    let runTestProgram =
        let instructions = [(1L,1) ; (0L,0) ; (0L,0) ; (1L,1) ; (1L,1) ; (0L,0) ; (0L,0) ; (1L,1) ; (1L,1) ; (0L,1) ; (1L,0) ; (0L,1) ; (1L,0) ; (0L,1) ; (1L,0) ; (0L,0) ; (1L,1) ; (0L,0) ; (1L,1) ; (0L,0) ; (1L,1)  ; (0L,1) ; (0L,1) ; (1L,0) ; (1L,1) ; (0L,0) ; (0L,0) ; (1L,1) ; (1L,0) ; (0L,1) ; (0L,0); (0L,0); (1L,1) ; (0L,0); (0L,0); (1L,1); (1L,1); (0L,0); (0L,0); (1L,1); (1L,1); (0L,1) ; (1L,0); (0L,1) ; (1L,0); (0L,1) ; (1L,0); (0L,1) ; (1L,0); (0L,0); (0L,0);(1L,1);(1L,1);(0L,0); (0L,0);(1L,1);(1L,1)]
        let mutable currentLocation = ((0, 0), 0)
        let mutable locationsPainted = Map.empty

        for instruction in instructions do
            locationsPainted <- locationsPainted |> Map.add (fst currentLocation) (fst instruction)
            currentLocation <- Day11Part1.rotate(currentLocation, snd instruction)

        printOutput(locationsPainted)


    let runExampleProgram =
    
        let instructions = [1L;0L;0L;0L;1L;0L;1L;0L;0L;1L;1L;0L;1L;0L]
        let mutable isPaintOutput = true
        let mutable currentLocation = ((0, 0), 0)
        let mutable locationsPainted = Map.empty

        for outputValue in instructions do
            if isPaintOutput then          
                locationsPainted <- locationsPainted |> Map.add (fst currentLocation) outputValue
            else
                currentLocation <- Day11Part1.rotate(currentLocation, int outputValue)

            isPaintOutput <- not isPaintOutput

        printOutput(locationsPainted)

    let runProgram (inputString:string, isPartOne) =

        let intcode:(int64 array) = Array.concat [|inputString.Split ',' |> Array.map System.Int64.Parse; (Array.zeroCreate 10000)|] 
        let mutable index = 0

        let mutable currentLocation = ((0, 0), 0)
        let mutable isPaintOutput = true
        let mutable locationsPainted = Map.empty |> Map.add (fst currentLocation) (if isPartOne then 0L else 1L)

        let mutable inputValue = 0L
        let mutable outputValue = 0L
        let mutable relativeBase = 0

        while intcode.[index] <> 99L && locationsPainted.Count < 10000 do

            let opcode = intcode.[index] - 100L * (intcode.[index] / 100L)
            
            let modeSettings =
                let digits = (string intcode.[index]).PadLeft(5, '0')
                digits.[0..digits.Length - 3] |> List.ofSeq |> List.rev
            
            let indexRef = ref index
            let relativeBaseRef = ref relativeBase
            
            let getParameterValue(position:int) =
                if isDebug then printfn "DEBUG index %i relativeBase %i opcode %i position %i mode %s intcode value %i modeSettings %O " index relativeBase opcode position (string modeSettings.[position - 1]) intcode.[index + position] modeSettings

                match modeSettings.[position - 1] with
                | '0' -> intcode.[int intcode.[!indexRef + position]]  //positional mode
                | '1' -> intcode.[!indexRef + position]  //immediate mode
                | '2' -> intcode.[!relativeBaseRef + int intcode.[!indexRef + position]]  //relative mode
                |  _  -> invalidArg "Invalid modeSetting for getParameterValue. Expected 0, 1 or 2" (string modeSettings.[position - 1])
                
            let getIndexForWrite(position:int) =
                match modeSettings.[position - 1] with
                | '0' -> int intcode.[!indexRef + position]  //positional mode
                | '2' -> !relativeBaseRef + int intcode.[!indexRef + position]  //relative mode
                |  _  -> invalidArg "Invalid modeSetting for getIndexForWrite. Expected 0 or 2" (string modeSettings.[position - 1])

            if opcode = 1L then
                intcode.[getIndexForWrite(3)] <- getParameterValue(1) + getParameterValue(2)
                index <- index + 4

            elif opcode = 2L then
                intcode.[getIndexForWrite(3)] <- getParameterValue(1) * getParameterValue(2)
                index <- index + 4

            elif opcode = 3L then
                inputValue <- match locationsPainted.TryFind (fst currentLocation) with
                                | Some x -> x
                                | None -> 0L

                intcode.[getIndexForWrite(1)] <- inputValue
                index <- index + 2

            elif opcode = 4L then
                outputValue <- getParameterValue(1)
                index <- index + 2
                
                if isPaintOutput then          
                    locationsPainted <- locationsPainted |> Map.add (fst currentLocation) outputValue
                else
                    currentLocation <- Day11Part1.rotate(currentLocation, int outputValue)

                isPaintOutput <- not isPaintOutput

            elif opcode = 5L then
                index <- if getParameterValue(1) <> 0L then (getParameterValue(2) |> int)
                         else index + 3
                    
            elif opcode = 6L then
                index <- if getParameterValue(1) = 0L then (getParameterValue(2) |> int)
                         else index + 3

            elif opcode = 7L then
                intcode.[getIndexForWrite(3)] <- if getParameterValue(1) < getParameterValue(2) then 1L else 0L
                index <- index + 4
                
            elif opcode = 8L then
                intcode.[getIndexForWrite(3)] <- if getParameterValue(1) = getParameterValue(2) then 1L else 0L
                index <- index + 4
                
            elif opcode = 9L then
                relativeBase <- relativeBase + (getParameterValue(1) |> int)
                index <- index + 2

        if isDebug then printfn "Relative Base %i" relativeBase

        if not isPartOne then printOutput(locationsPainted)
   
        locationsPainted.Count