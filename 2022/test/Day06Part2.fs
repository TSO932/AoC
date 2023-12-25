namespace AoC2022.Tests

open NUnit.Framework
open AoC2022

[<TestFixture>] 
type Day06Part2 () =

    [<Test>]
    member _.Example1() = Assert.AreEqual(19, Day06Part2.FindPosition "mjqjpqmgbljsphdztnvjfqwrcgsmlb" )

    [<Test>]
    member _.Example2() = Assert.AreEqual(23, Day06Part2.FindPosition "bvwbjplbgvbhsrlpgdmjqwftvncz" )

    [<Test>]
    member _.Example3() = Assert.AreEqual(23, Day06Part2.FindPosition "nppdvjthqldpwncqszvftbrmjlhg" )

    [<Test>]
    member _.Example4() = Assert.AreEqual(29, Day06Part2.FindPosition "nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg" )
    
    [<Test>]
    member _.Example5() = Assert.AreEqual(26, Day06Part2.FindPosition "zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw" )
    