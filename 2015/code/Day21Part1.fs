namespace AoC2015

module Day21Part1 =

  type Item(name:string, cost:int, damage:int, armour:int) =
    member _.Name = name
    member _.Cost = cost
    member _.Damage = damage
    member _.Armour = armour
    override _.ToString() = name

  type Stats(cost:int, damage:int, armour:int, hitPoints:int) =
 
    new(items:seq<Item>, hitPoints:int) =
      Stats(
        items |> Seq.fold (fun total (item:Item) -> total + item.Cost) 0,
        items |> Seq.fold (fun total (item:Item) -> total + item.Damage) 0,
        items |> Seq.fold (fun total (item:Item) -> total + item.Armour) 0,
        hitPoints
      )

    new(defender:Stats, attacker:Stats) =
      Stats(
        defender.Cost,
        defender.Damage,
        defender.Armour,
        defender.HitPoints - max 1 (attacker.Damage - defender.Armour)
      )

    member _.HitPoints = hitPoints
    member _.Cost = cost
    member _.Damage = damage
    member _.Armour = armour

  let getOptions() = 
   
    let weapons = [| Item("Dagger", 8, 4, 0); Item("Shortsword", 10, 5, 0); Item("Warhammer", 25, 6, 0); Item("Longsword", 40, 7, 0); Item("Greataxe", 78, 8, 0) |]

    let armour = [| Item("none", 0, 0, 0); Item("Leather", 13, 0, 1); Item("Chainmail", 31, 0, 2); Item("Splitmail", 53, 0, 3);
    Item("Bandedmail", 75, 0, 4); Item("Platemail", 102, 0, 5) |]
    
    let rings = [| Item("left-hand bare", 0, 0, 0); Item("right-hand bare", 0, 0, 0);
    Item("Damage +1", 25, 1, 0); Item("Damage +2", 50, 2, 0); Item("Damage +3", 100, 3, 0);
    Item("Defence +1", 20, 0, 1); Item("Defence +2", 40, 0, 2); Item("Defence +3", 80, 0, 3) |]
    
    weapons 
      |> Seq.map (fun w -> armour |> Seq.map (fun a -> rings 
                                                        |> Seq.map (fun r1 -> rings |> Seq.filter (fun r2 -> not (r1.Equals r2)) 
                                                                                |> Seq.map (fun r2 -> [w; a; r1; r2]))))
      |> Seq.concat |> Seq.concat |> Seq.concat
      |> Seq.map (fun x -> Stats(x, 100))

  let rec fight(player:Stats, boss:Stats) =
    if   boss.HitPoints   <= 0 then true
    elif player.HitPoints <= 0 then false
    else
      let bossAfterPlayersTurn = Stats(boss, player)
      fight(Stats(player, bossAfterPlayersTurn), bossAfterPlayersTurn)

  let findCheapestWinningOption() =
    getOptions() |> Seq.filter (fun p -> fight(p, Stats(0, 8, 2, 109))) |> Seq.map (fun p -> p.Cost) |> Seq.min