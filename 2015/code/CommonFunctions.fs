namespace AoC2015

module CommonFunctions =

    // https://stackoverflow.com/questions/1526046/f-permutations
    // https://www.ffconsultancy.com/products/fsharp_for_technical_computing/index.html?so

    let rec distribute e = function
    | [] -> [[e]]
    | x::xs' as xs -> (e::xs)::[for xs in distribute e xs' -> x::xs]

    let rec permute = function
    | [] -> [[]]
    | e::xs -> List.collect (distribute e) (permute xs)
