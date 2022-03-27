
open System


let answer (s:string) = 
    System.Console.WriteLine()
    match s with
    |_ when s="1"||s="2" -> printfn "Подлиза" 
    |_ when s="3"-> 
        let s= System.Console.ReadLine()
        if   s="Python" then printfn "питонисты..."
        else printfn "Слушай, а неплохой выбор!"
    
[<EntryPoint>]
let main argv =

    printfn "Какой у вас любимый язык программирования?"
    printfn "1.Prolog"
    printfn "2.F#"
    printfn "3.Впишу свой"

    System.Convert.ToString(System.Console.ReadLine())|> answer |> System.Console.WriteLine
    
    0 // return an integer exit code
