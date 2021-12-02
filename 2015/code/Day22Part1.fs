namespace AoC2015

module Day22Part1 =
  
  type Spell(name:string, cost:int, damage:int, armour:int, healing:int, mana:int, turns:int, isActive:bool) =

    new(name:string) =
      match name with
      | "Magic Missile" -> Spell (name,  53, 4, 0, 0,   0, 1, true)
      | "Drain"         -> Spell (name,  73, 2, 0, 2,   0, 1, true)
      | "Shield"        -> Spell (name, 113, 0, 7, 0,   0, 7, false)
      | "Poison"        -> Spell (name, 173, 3, 0, 0,   0, 7, false)
      | "Recharge"      -> Spell (name, 229, 0, 0, 0, 101, 6, false)
      | _               -> Spell ("no spell",     0, 0, 0, 0,   0, 0, false)
 
    member _.Drain() = Spell(name, cost, damage, armour, healing, mana, turns - 1, true)
    member _.Name = name
    member _.Cost = cost
    member _.Damage = damage
    member _.Armour = armour
    member _.Healing = healing
    member _.Mana = mana
    member _.Turns = turns
    member _.IsActive = isActive
    override _.ToString() = name

  type Spellbook(spells:seq<Spell>) =

    member _.Drain()   = spells |> Seq.map (fun s -> s.Drain()) |> Seq.filter (fun s -> s.Turns > 0)
    member _.Damage()  = spells |> Seq.filter (fun s -> s.IsActive) |> Seq.sumBy (fun s -> s.Damage)
    member _.Armour()  = spells |> Seq.filter (fun s -> s.IsActive) |> Seq.sumBy (fun s -> s.Armour)
    member _.Healing() = spells |> Seq.filter (fun s -> s.IsActive) |> Seq.sumBy (fun s -> s.Healing)
    member _.Mana()    = spells |> Seq.filter (fun s -> s.IsActive) |> Seq.sumBy (fun s -> s.Mana)
    member _.Add(spell:Spell) = Spellbook(Seq.concat [spells; [spell]])

  type Wizard(mana:int, hitPoints:int, spells:Spellbook) =
 
    member _.HitPoints = hitPoints
    member _.Mana = mana
    member _.Spells = spells

    new(mana:int, hitPoints:int, spells:seq<Spell>) = Wizard(mana, hitPoints, Spellbook(spells))

    new(wizard:Wizard, damageFromBoss:int) =
      Wizard(
        (if wizard.Mana < 0 then wizard.Mana else wizard.Mana + wizard.Spells.Mana()),
        wizard.HitPoints + wizard.Spells.Healing() - damageFromBoss,
        wizard.Spells.Drain()
        )

  type Boss(damage:int, hitPoints:int) =
 
    member _.HitPoints = hitPoints
    member _.Damage = damage

    new(boss:Boss, damageFromWizard:int) = Boss(boss.Damage, boss.HitPoints - damageFromWizard)

  let rec fight(player:Wizard, boss:Boss, fightSequence:List<Spell>) =

    // printfn "FIGHT Wizard HP %i Mana %i Boss HP %i" player.HitPoints player.Mana boss.HitPoints
    if   List.length fightSequence = 0 then false
    elif boss.HitPoints   <= 0         then true
    elif player.HitPoints <= 0         then false
    else
      let nextSpell = List.head fightSequence
      let playerWithNewSpell = Wizard(player.Mana - nextSpell.Cost, player.HitPoints + player.Spells.Healing(), player.Spells.Add(nextSpell))

      let bossAfterPlayersTurn = Boss(boss, playerWithNewSpell.Spells.Damage())
      
      let playerAfterPlayersTurn = Wizard(playerWithNewSpell, 0)

      // printfn "_____ Wizard HP %i Mana %i Boss HP %i" player.HitPoints playerAfterPlayersTurn.Mana bossAfterPlayersTurn.HitPoints
      let playerAfterBosssTurn = Wizard(playerAfterPlayersTurn, max 1 (bossAfterPlayersTurn.Damage - playerAfterPlayersTurn.Spells.Armour()))

      let bossAfterBosssTurn = Boss(bossAfterPlayersTurn, playerAfterPlayersTurn.Spells.Damage())

      fight(playerAfterBosssTurn, bossAfterBosssTurn, List.tail fightSequence)


  let rec last n xs =
    if List.length xs <= n then xs
    else last n xs.Tail

  let rec getOptions(options:seq<seq<string>>, numberOfRounds:int) =

      if numberOfRounds <= 0 then
        options
      else
        let availableSpells(castingOrder:seq<string>) =
          if castingOrder |> Seq.rev |> Seq.head = "cast no spell" then
            ["cast no spell"]
          else
            let isAvailable(spell:string, duration:int) =
              if last duration (List.ofSeq castingOrder) |> List.contains spell then [] else [spell]

            ["Magic Missile"; "Drain"; "cast no spell"] |> Seq.append (isAvailable("Shield", 6)) |> Seq.append (isAvailable("Poison", 6)) |> Seq.append (isAvailable("Recharge", 5)) |> List.ofSeq

        let newOptions = options |> Seq.map (fun o -> (availableSpells(o) |> Seq.map (fun s -> Seq.append o [s]))) |> Seq.concat

        getOptions(newOptions, numberOfRounds - 1)
       

  // 797  850 870 all too low
  //  890 not the answer

  let find(wizard:Wizard, boss:Boss, numberOfRounds:int) =
    
    getOptions([["Magic Missile"]; ["Drain"]; ["Shield"]; ["Poison"]; ["Recharge"]], numberOfRounds)
    |> Seq.map (fun sequence -> sequence |> List.ofSeq |> List.map Spell )
    |> Seq.filter (fun sequence -> (wizard.Mana, sequence) ||> List.scan (fun mana spell -> mana - spell.Cost) |> List.min >= 0)
    |> Seq.filter (fun sequence -> fight(wizard, boss, sequence))
    |> Seq.map    (fun sequence -> List.sumBy (fun (spell:Spell) -> spell.Cost) sequence)
    |> Seq.min

  let findCheapestWinningOption() = find(Wizard(500, 50, []), Boss(8, 55), 15)