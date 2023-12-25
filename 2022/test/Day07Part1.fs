namespace AoC2022.Tests

open System.IO
open NUnit.Framework
open AoC2022

[<TestFixture>] 
type Day07Part1 () =

    [<Test>]
    member _.getDirectoryRoot() = Assert.AreEqual("", Day07Part1.getDirectory ("$ cd /", "harry"))

    [<Test>]
    member _.getDirectoryUp() = Assert.AreEqual("harry/met", Day07Part1.getDirectory ("$ cd ..", "harry/met/sally"))

    [<Test>]
    member _.getDirectoryDown() = Assert.AreEqual("sullivan/met/mike", Day07Part1.getDirectory ("$ cd mike", "sullivan/met"))
    
    [<Test>]
    member _.getDirectoryUnchanged() = Assert.AreEqual("unchanged", Day07Part1.getDirectory ("random", "unchanged"))

    [<Test>]
    member _.getSize() = Assert.AreEqual(834738, Day07Part1.getSize ("834738 de"))

    [<Test>]
    member _.getSizeNotAFile() = Assert.AreEqual(0, Day07Part1.getSize ("abcde"))

    [<Test>]
    member _.getFolders() = CollectionAssert.AreEqual(["aa/b/ccc/d"; "aa/b/ccc"; "aa/b"; "aa"; "/"], Day07Part1.getFolders ("aa/b/ccc/d", []))

    [<Test>]
    member _.getFoldersEmpty() = CollectionAssert.AreEqual(["/"], Day07Part1.getFolders ("", []))

    [<Test>]
    member _.getFoldersLeadingSlash() = CollectionAssert.AreEqual(["/aa/b/ccc/d"; "/aa/b/ccc"; "/aa/b"; "/aa"; "/"], Day07Part1.getFolders ("/aa/b/ccc/d", []))

    [<Test>]
    member _.getSizes() = CollectionAssert.AreEqual([|0; 0; 148; 85; 0|], Day07Part1.getSizes ([|"j"; "k"; "148 485"; "85 p"; "dir"|]))

    [<Test>]
    member _.getDirs() = CollectionAssert.AreEqual([|""; ""; ""; "d"; "d/a"|], Day07Part1.getDirs ([|"$ cd /"; "$ ls"; "148 b.txt"; "$ cd d"; "$ cd a"|]))

    [<Test>]
    member _.getDirsAndSizes() = CollectionAssert.AreEqual([|("", 148); ("d/a", 99)|], Day07Part1.getDirsAndSizes ([|"$ cd /"; "$ ls"; "148 b.txt"; "$ cd d"; "$ cd a"; "99 flake"|]))

    [<Test>]
    member _.getFoldersWithSize() = CollectionAssert.AreEqual([("aa/b", 44); ("aa", 44); ("/", 44)], Day07Part1.getFoldersWithSize ("aa/b", 44))

    [<Test>]
    member _.getFoldersWithSizeEmpty() = CollectionAssert.AreEqual([("/", 7)], Day07Part1.getFoldersWithSize ("", 7))

    [<Test>]
    member _.getAllFoldersWithSizes() = CollectionAssert.AreEqual([|("/", 148); ("d/a", 99); ("d", 99); ("/", 99)|], Day07Part1.getAllFoldersWithSizes ([|"$ cd /"; "$ ls"; "148 b.txt"; "$ cd d"; "$ cd a"; "99 flake"|]))

    [<Test>]
    member _.getFolderTotals() = CollectionAssert.AreEqual([|("/", 247); ("d/a", 99); ("d", 99)|], Day07Part1.getFolderTotals ([|("/", 148); ("d/a", 99); ("d", 99); ("/", 99)|]))

    [<Test>]
    member _.getSumOfSmallDirectories() = Assert.AreEqual(100445, Day07Part1.getSumOfSmallDirectories ([|("/", 247); ("d/a", 99); ("d", 99); ("e", 100000); ("f", 100001)|]))

    [<Test>]
    member _.example() = Assert.AreEqual(95437, Day07Part1.runProgram (File.ReadAllLines("../../../../input/Day07/test.txt")))