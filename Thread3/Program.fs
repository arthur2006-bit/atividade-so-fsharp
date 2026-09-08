open System
open System.Threading


let trabalhador numero tempoTrabalho =
    printfn "Trabalhador %d começou" numero

    Thread.Sleep(tempoTrabalho * 1000)

    printfn "Trabalhador %d terminou (levou %ds)"
        numero tempoTrabalho


[<EntryPoint>]
let main argv =

    printfn "Iniciando 5 trabalhadores..."

    let inicio = DateTime.Now

    // Criar lista de threads
    let threads = ResizeArray<Thread>()

    
    for i in 0 .. 4 do

        let thread =
            new Thread(
                ThreadStart(fun () ->
                    trabalhador i 2
                )
            )

        threads.Add(thread)

        thread.Start()

    
    for thread in threads do
        thread.Join()

    let fim = DateTime.Now

    let tempoTotal =
        (fim - inicio).TotalSeconds

    printfn ""
    printfn "Todos os trabalhadores terminaram!"
    printfn "Tempo total: %.2fs" tempoTotal
    printfn "(Se fosse sequencial, levaria ~10s)"

    0
