let isDebug = false
let isPartOne = false

let rotate(((x0, y0), currentDirection), turnInstruction) =
    
    let resetCircle(angle) =
        if   angle <  0   then angle + 360 * (1 + abs angle/360)
        elif angle >= 360 then angle - 360 * (angle/360)
        else angle
    
    let newDirection = 
        match turnInstruction with
        | 0 -> resetCircle(currentDirection - 90)
        | 1 -> resetCircle(currentDirection + 90)
        | _ -> invalidArg "Invalid turnInstruction input to rotate function. Expected 0 or 1" (string turnInstruction)
       
    let (x1, y1) =
        match newDirection with
        |   0 -> (x0, y0 - 1)
        |  90 -> (x0 + 1, y0)
        | 180 -> (x0, y0 + 1)
        | 270 -> (x0 - 1, y0)
        |   _ -> invalidArg "Invalid newDirection input to rotate function. Expected 0, 90, 180 or 270" (string newDirection)
        
    ((x1, y1), newDirection)

if isDebug then       
    printfn "up    left  %A" (rotate(((0, 0),   0),  0))
    printfn "left  left  %A" (rotate(((0, 0), 270),  0))
    printfn "down  left  %A" (rotate(((0, 0), 180),  0))
    printfn "right left  %A" (rotate(((0, 0),  90),  0))
    printfn "up    right %A" (rotate(((0, 0),   0),  1))
    printfn "left  right %A" (rotate(((0, 0), 270),  1))
    printfn "down  right %A" (rotate(((0, 0), 180),  1))
    printfn "right right %A" (rotate(((0, 0),  90),  1))
    printfn "way over    %A" (rotate(((0, 0), 810),  1))
    printfn "way under   %A" (rotate(((0, 0),-540),  1))
    
    try printfn "NE    right %A" (rotate(((0, 0),  45),  1))
    with | :? System.ArgumentException as ex -> printfn "%s" ex.Message
          
    try printfn "down  wrong %A" (rotate(((0, 0),  90), -2))
    with | :? System.ArgumentException as ex -> printfn "%s" ex.Message


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
        currentLocation <- rotate(currentLocation, snd instruction)

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
            currentLocation <- rotate(currentLocation, int outputValue)

        isPaintOutput <- not isPaintOutput

    printOutput(locationsPainted)


let runProgram (inputString:string) =

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
                currentLocation <- rotate(currentLocation, int outputValue)

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

    printfn "Relative Base %i" relativeBase
    printOutput(locationsPainted)
   
            
let inputString = "3,8,1005,8,318,1106,0,11,0,0,0,104,1,104,0,3,8,102,-1,8,10,1001,10,1,10,4,10,1008,8,1,10,4,10,101,0,8,29,1,107,12,10,2,1003,8,10,3,8,102,-1,8,10,1001,10,1,10,4,10,1008,8,0,10,4,10,1002,8,1,59,1,108,18,10,2,6,7,10,2,1006,3,10,3,8,1002,8,-1,10,1001,10,1,10,4,10,1008,8,1,10,4,10,1002,8,1,93,1,1102,11,10,3,8,102,-1,8,10,1001,10,1,10,4,10,108,1,8,10,4,10,101,0,8,118,2,1102,10,10,3,8,102,-1,8,10,101,1,10,10,4,10,1008,8,0,10,4,10,101,0,8,145,1006,0,17,1006,0,67,3,8,1002,8,-1,10,101,1,10,10,4,10,1008,8,0,10,4,10,101,0,8,173,2,1109,4,10,1006,0,20,3,8,102,-1,8,10,1001,10,1,10,4,10,108,0,8,10,4,10,102,1,8,201,3,8,1002,8,-1,10,1001,10,1,10,4,10,1008,8,0,10,4,10,1002,8,1,224,1006,0,6,1,1008,17,10,2,101,5,10,3,8,1002,8,-1,10,1001,10,1,10,4,10,108,1,8,10,4,10,1001,8,0,256,2,1107,7,10,1,2,4,10,2,2,12,10,1006,0,82,3,8,1002,8,-1,10,1001,10,1,10,4,10,1008,8,1,10,4,10,1002,8,1,294,2,1107,2,10,101,1,9,9,1007,9,988,10,1005,10,15,99,109,640,104,0,104,1,21102,1,837548352256,1,21102,335,1,0,1105,1,439,21102,1,47677543180,1,21102,346,1,0,1106,0,439,3,10,104,0,104,1,3,10,104,0,104,0,3,10,104,0,104,1,3,10,104,0,104,1,3,10,104,0,104,0,3,10,104,0,104,1,21102,1,235190374592,1,21101,393,0,0,1105,1,439,21102,3451060455,1,1,21102,404,1,0,1105,1,439,3,10,104,0,104,0,3,10,104,0,104,0,21102,837896909668,1,1,21102,1,427,0,1105,1,439,21102,1,709580555020,1,21102,438,1,0,1105,1,439,99,109,2,21201,-1,0,1,21102,1,40,2,21102,1,470,3,21102,460,1,0,1106,0,503,109,-2,2105,1,0,0,1,0,0,1,109,2,3,10,204,-1,1001,465,466,481,4,0,1001,465,1,465,108,4,465,10,1006,10,497,1101,0,0,465,109,-2,2105,1,0,0,109,4,1201,-1,0,502,1207,-3,0,10,1006,10,520,21101,0,0,-3,21202,-3,1,1,22101,0,-2,2,21101,1,0,3,21101,0,539,0,1106,0,544,109,-4,2105,1,0,109,5,1207,-3,1,10,1006,10,567,2207,-4,-2,10,1006,10,567,21202,-4,1,-4,1105,1,635,22101,0,-4,1,21201,-3,-1,2,21202,-2,2,3,21101,0,586,0,1105,1,544,22102,1,1,-4,21102,1,1,-1,2207,-4,-2,10,1006,10,605,21102,1,0,-1,22202,-2,-1,-2,2107,0,-3,10,1006,10,627,21202,-1,1,1,21101,627,0,0,105,1,502,21202,-2,-1,-2,22201,-4,-2,-4,109,-5,2105,1,0"

runTestProgram
runExampleProgram
runProgram(inputString)
