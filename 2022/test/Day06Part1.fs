namespace AoC2022.Tests

open NUnit.Framework
open AoC2022

[<TestFixture>] 
type Day06Part1 () =

    [<Test>]
    member _.Example1() = Assert.AreEqual(7, Day06Part1.FindPosition "mjqjpqmgbljsphdztnvjfqwrcgsmlb" )

    [<Test>]
    member _.Example2() = Assert.AreEqual(5, Day06Part1.FindPosition "bvwbjplbgvbhsrlpgdmjqwftvncz" )

    [<Test>]
    member _.Example3() = Assert.AreEqual(6, Day06Part1.FindPosition "nppdvjthqldpwncqszvftbrmjlhg" )

    [<Test>]
    member _.Example4() = Assert.AreEqual(10, Day06Part1.FindPosition "nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg" )
    
    [<Test>]
    member _.Example5() = Assert.AreEqual(11, Day06Part1.FindPosition "zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw" )
    