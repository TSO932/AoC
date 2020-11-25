let findBestAsteroid(spaceMap:string) =
    let isDebug = false
    let arrays = spaceMap.Split '\010' |> Seq.map (fun a -> Array.ofSeq a) |> Array.ofSeq
    let matrix = Array2D.init arrays.Length arrays.[0].Length (fun i j -> arrays.[i].[j])

    if isDebug then printfn "%A" matrix

    let countAsteroids(y, x) = 
        let angles = matrix |> Array2D.mapi (fun v h c -> (c = '#' && not (y = v && x = h), System.Math.Atan2(float (y - v), float (x - h))))
        angles |> Seq.cast<bool*double> |> Seq.filter (fun x -> fst x) |> Seq.distinct |> Seq.length

    let countedAsteroids = matrix |> Array2D.mapi (fun y x c -> if c = '#' then countAsteroids(y, x) else 0) |> Seq.cast<int>
    let asteroidCount = (countedAsteroids |> Seq.max)
    let location = countedAsteroids |> Seq.findIndex ((=) (countedAsteroids |> Seq.max)) |> fun i -> (i - (i / arrays.[0].Length) * arrays.[0].Length, i / arrays.[0].Length)
    printfn "location %O count %i" location asteroidCount

findBestAsteroid(".#..#
.....
#####
....#
...##")

findBestAsteroid("......#.#.
#..#.#....
..#######.
.#.#.###..
.#..#.....
..#....#.#
#..#....#.
.##.#..###
##...#..#.
.#....####")

findBestAsteroid("#.#...#.#.
.###....#.
.#....#...
##.#.#.#.#
....#.#.#.
.##..###.#
..#...##..
..##....##
......#...
.####.###.")

findBestAsteroid(".#..#..###
####.###.#
....###.#.
..###.##.#
##.##.#.#.
....###..#
..#.#..#.#
#..#.#.###
.##...##.#
.....#.#..")

findBestAsteroid(".#..##.###...#######
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
###.##.####.##.#..##")

findBestAsteroid("##.##..#.####...#.#.####
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
..###.########.#.###..#.")
