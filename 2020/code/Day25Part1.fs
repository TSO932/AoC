namespace AoC2020

module Day25Part1 =

    let transform(x:int64, sn:int64) = (x * sn) % 20201227L

    let getLoopSize(publicKey:int64) =

        let mutable subjectNumber = 7L
        let mutable steps = 0

        let originalSubjectNumber = subjectNumber

        while subjectNumber <> publicKey do
            subjectNumber <- transform(subjectNumber, originalSubjectNumber)
            steps <- steps + 1

        steps

    let getEncryptionKey(publicKeyA:int64, loopSizeB:int) =

        let mutable subjectNumber = publicKeyA

        let originalSubjectNumber = subjectNumber

        for _ in seq {1..loopSizeB} do
            subjectNumber <- transform(subjectNumber, originalSubjectNumber)

        subjectNumber

    let crackTheLock(publicKeyA:int64, publicKeyB:int64) =
        getEncryptionKey(publicKeyA, getLoopSize(publicKeyB))

    let merryChristmas(publicKeys:seq<string>) =
        let keys = publicKeys |> Array.ofSeq
        crackTheLock(int64 keys.[0], int64 keys.[1])


        