namespace AoC2015

module Day11Part2 =

    let getNextPassword(password:string) = Day11Part1.generatePassword (Day11Part1.generatePassword (password, Day11Part1.rules), Day11Part1.rules)