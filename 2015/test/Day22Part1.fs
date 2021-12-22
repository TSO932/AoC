namespace AoC2015.Tests

open NUnit.Framework
open AoC2015

[<TestFixture>] 
type Day22Part1 () =

    [<Test>]
    member _.Example1() = 
        let spellList = List.map Day22Part1.Spell ["Poison"; "Magic Missile"; "end"]
        Assert.AreEqual(true, Day22Part1.fight(Day22Part1.Wizard(250, 10, []), Day22Part1.Boss(8, 13), spellList))

    [<Test>]
    member _.Example2() = 
        let spellList = List.map Day22Part1.Spell ["Recharge"; "Shield"; "Drain"; "Poison"; "Magic Missile"; "end"]
        Assert.AreEqual(true, Day22Part1.fight(Day22Part1.Wizard(250, 10, []), Day22Part1.Boss(8, 14), spellList))

    [<Test>]
    member _.Find() = Assert.AreEqual(250 - 24, Day22Part1.find(Day22Part1.Wizard(250, 10, []), Day22Part1.Boss(8, 13), 3))



    