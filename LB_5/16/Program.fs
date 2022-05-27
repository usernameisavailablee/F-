open System

let rec NOD a b =
    if a%b=0 then b
    else NOD b (a%b)

let rec Divisors (a:int,init:int,beg:int,func: int->int->int):int = 
    match beg with
    | _ when beg>a ->init
    | _ when (NOD a beg) = 1 -> Divisors (a,func beg init,beg+1,func)
    | _ -> Divisors (a,init,beg+1,func)

let rec Eiler a amout beg = 
    match beg with
    | _ when beg>a ->amout
    | _ when (NOD a beg) = 1 -> 
        printfn $"Простая компонента {beg}" 
        Eiler a (amout+1) (beg+1)
    | _ -> Eiler a amout (beg+1)

let UberFunc (a:int,init:int,func: int->int->int):int = Divisors (a,init,1,func)
let UberEiler a init = Eiler a init 1

[<EntryPoint>]
let main argv =
    let a = System.Convert.ToInt32(System.Console.ReadLine())
    printfn $"Сумма - {UberFunc(a,0,fun a b->a+b)}"
    printfn ""
    printfn $"Колво взаимно простых компонент {UberEiler a 0}"
    0
