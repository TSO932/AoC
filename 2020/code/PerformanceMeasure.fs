namespace AoC2020

open System.Diagnostics

module PerformanceMeasure =
    let measurePerformance (func, input) =

        let watch = Stopwatch()
        
        watch.Start()
        func(input) |> ignore
        watch.Stop()

        let itterations = max 10L (min 10000L (10000L / watch.ElapsedMilliseconds))
 
        watch.Reset()
        watch.Start()
        for _ in seq {1L..itterations} do
            func(input)|> ignore
        watch.Stop()

        float watch.ElapsedMilliseconds / float itterations
