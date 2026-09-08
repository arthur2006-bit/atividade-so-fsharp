open System.Threading

// Função que será executada na thread
let saudar nome vezes =
    for i in 1 .. vezes do
        printfn "Olá, %s! (mensagem %d)" nome i

[<EntryPoint>]
let main argv =

    // Criar a thread com argumentos
    let thread =
        new Thread(
            ThreadStart(fun () ->
                saudar "Maria" 3
            )
        )

    // Iniciar a thread
    thread.Start()

    // Aguardar a thread terminar
    thread.Join()

    0