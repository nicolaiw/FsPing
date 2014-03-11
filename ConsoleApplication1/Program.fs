// Weitere Informationen zu F# unter "http://fsharp.net".
// Weitere Hilfe finden Sie im Projekt "F#-Lernprogramm".

open System
open System.Net.NetworkInformation

let rec ping() =
    printfn "<IP> or exit: "
    let ip = Console.ReadLine()
    match ip with
    | "exit" -> printfn "cu"
    | _ ->  
            let sender = new Ping()
            let res = sender.Send(ip)
            let status = res.Status
            match status with
            | IPStatus.Success -> let res = res.RoundtripTime
                                  printfn "Ping %d" res
            | _ -> printfn "%A" status
            ping()
        

[<EntryPoint>]
let main argv = 
    
    ping()
    System.Console.ReadKey() |> ignore
    0 // Exitcode aus ganzen Zahlen zurückgeben
