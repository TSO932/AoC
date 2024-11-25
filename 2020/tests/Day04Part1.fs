namespace AoC2020.Tests

open System.IO
open NUnit.Framework
open AoC2020

[<TestFixture>] 
type Day04Part1 () =

    [<Test>]
    member this.formatCredentials() =
        let expected = ["hcl:#cfa07d byr:1929 "; " hcl:#ae17e1 iyr:2013 eyr:2024 "; " hcl:#cfa07d eyr:2025 pid:166559648 iyr:2011 "]
        CollectionAssert.AreEqual(expected, Day04Part1.formatCredentials (File.ReadAllLines("../../../data/Day04/test2.txt")))

    [<Test>]
    member this.validateCredentialsTrue() =
        Assert.AreEqual(1, Day04Part1.validateCredentials (["byr: iyr: eyr: hgt: hcl: ecl: pid: cid:"]))

    [<Test>]
    member this.validateCredentialsFalse() =
        Assert.AreEqual(0, Day04Part1.validateCredentials (["iyr: eyr: hgt: hcl: ecl: pid: cid:"]))

    [<Test>]
    member this.Example1() = Assert.AreEqual(2, Day04Part1.validateCredentials(Day04Part1.formatCredentials (File.ReadAllLines("../../../data/Day04/test1.txt"))))
