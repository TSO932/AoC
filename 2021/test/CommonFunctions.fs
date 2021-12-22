namespace AoC2021.Tests

open NUnit.Framework
open AoC2021

[<TestFixture>] 
type CommonFunctions () =

    [<Test>]
    member _.SingleValue() = CollectionAssert.AreEqual([[1]], CommonFunctions.permute ([1]))

    [<Test>]
    member _.NoValues() = CollectionAssert.AreEqual([[]], CommonFunctions.permute ([]))
    
    [<Test>]
    member _.TwoIdenticalValues() = CollectionAssert.AreEqual([[[2; 1]]], CommonFunctions.permute ([[2; 1]]))

    [<Test>]
    member _.ThreeValues() = 
        CollectionAssert.AreEqual([[1; 2; 3]; [2; 1; 3]; [2; 3; 1]; [1; 3; 2]; [3; 1; 2]; [3; 2; 1]], CommonFunctions.permute ([1; 2; 3]))
