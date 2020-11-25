let isDebug = false
    
let vaporise(spaceMap:string,stationLocation) =
    let arrays = spaceMap.Split ([|'\010'; '\013'|], System.StringSplitOptions.RemoveEmptyEntries) |> Seq.map (Array.ofSeq) |> Array.ofSeq
    let matrix = Array2D.init arrays.Length arrays.[0].Length (fun i j -> arrays.[i].[j])
    let matrixOfAngles = matrix |> Array2D.mapi (fun v h c -> (c = '#' && not (v = snd stationLocation && h = fst stationLocation), (System.Math.Atan2(float (h - fst stationLocation),float (v - snd stationLocation)), abs (h - fst stationLocation) + abs (v - snd stationLocation))))
    let seqOfAngles = matrixOfAngles |> Seq.cast<bool*(double*int)> |> Seq.filter (fst) |> Seq.map (snd)
    
    if isDebug then printfn "%A" matrix
    if isDebug then printfn "%A" matrixOfAngles

    let zapAsteroid((lastAngle,_), asteroidMap) = 
        let smallerAngles = asteroidMap |> Seq.filter (fun x -> fst x < lastAngle) 
        let nextAngle = (if Seq.length smallerAngles > 0 then smallerAngles else asteroidMap) |> Seq.maxBy fst |> fst
        let nextDistance = asteroidMap |> Seq.filter (fun x -> fst x = nextAngle) |> Seq.minBy (fun x -> abs (snd x)) |> snd
        if isDebug then printfn "angle %f distance %i count %i  zap %A" nextAngle nextDistance (Seq.length asteroidMap) (asteroidMap |> Seq.filter (fun x -> (x = (nextAngle, nextDistance))))
        ((nextAngle, nextDistance), asteroidMap |> Seq.filter (fun x -> not (x = (nextAngle, nextDistance))))
     
    let rec zapAsteroids(((angle,distance), asteroids), killCount) = 
        if Seq.length asteroids = 1 || killCount = 199 then
            let lastZap = zapAsteroid((angle,distance), asteroids)
            let lastAsteroid = matrixOfAngles |> Array2D.mapi (fun v h (a,b) -> a && fst (fst lastZap) = fst b && snd (fst lastZap) = abs (h - fst stationLocation) + abs (v - snd stationLocation))
            let coords = Seq.cast<bool> lastAsteroid |> Seq.findIndex ((=) true) |> fun i -> (i - (i / arrays.[0].Length) * arrays.[0].Length, i / arrays.[0].Length)
            fst coords * 100 + snd coords        
        else
           zapAsteroids((zapAsteroid((angle,distance), asteroids)), killCount + 1)
           
    printfn "%A" (zapAsteroids(((double 4.0, 0), seqOfAngles), 0))
    
vaporise(".#
##",(1,0))

vaporise(".#....#####...#..
##...##.#####..##
##...#...#.#####.
..#.....X...###..
..#.#.....#....##",(8,3))

if not isDebug then vaporise(".#..##.###...#######
##.############..##.
.#.######.########.#
.###.#######.####.#.
#####.##.#.##.###.##
..#####..#.#########
####################
#.####....###.#.#.##
##.#################
#####.##.###..####..
..######..##.#######
####.##.####...##..#
.#####..#.######.###
##...#.##########...
#.##########.#######
.####.#.###.###.#.##
....##.##.###..#####
.#.#.###########.###
#.#.#.#####.####.###
###.##.####.##.#..##",(11,13))

if not isDebug then vaporise("##.##..#.####...#.#.####
##.###..##.#######..##..
..######.###.#.##.######
.#######.####.##.#.###.#
..#...##.#.....#####..##
#..###.#...#..###.#..#..
###..#.##.####.#..##..##
.##.##....###.#..#....#.
########..#####..#######
##..#..##.#..##.#.#.#..#
##.#.##.######.#####....
###.##...#.##...#.######
###...##.####..##..#####
##.#...#.#.....######.##
.#...####..####.##...##.
#.#########..###..#.####
#.##..###.#.######.#####
##..##.##...####.#...##.
###...###.##.####.#.##..
####.#.....###..#.####.#
##.####..##.#.##..##.#.#
#####..#...####..##..#.#
.##.##.##...###.##...###
..###.########.#.###..#.",(14,17))
