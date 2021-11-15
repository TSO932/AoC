namespace AoC2015

open System
open System.Text.RegularExpressions

module Day11Part2 =

    let getNextPassword(password:string) = Day11Part1.generatePassword (Day11Part1.generatePassword (password, Day11Part1.rules), Day11Part1.rules)