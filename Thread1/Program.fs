open System.Threading

// Função que será executada na thread
let minhaFuncao () =
    printfn "Thread iniciada!"
    Thread.Sleep(2000)
    printfn "Thread finalizada!"

[<EntryPoint>]
let main argv =

    // Criar a thread
    let thread = new Thread(ThreadStart(minhaFuncao))

    // Iniciar a thread
    thread.Start()

    // Aguardar a thread terminar
    thread.Join()

    printfn "Programa principal finalizado!"

    0
    