open System.Threading


let saudar nome vezes =
    for i in 1 .. vezes do
        printfn "Olá, %s! (mensagem %d)" nome i

[<EntryPoint>]
let main argv =

    
    let thread =
        new Thread(
            ThreadStart(fun () ->
                saudar "Maria" 3
            )
        )

    
    thread.Start()

    
    thread.Join()

    0
