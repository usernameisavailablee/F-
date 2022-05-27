open System

let rec NOD a b =
    if a%b=0 then b
    else NOD b (a%b)

let rec Divisors (a:int,init:int,beg:int,func: int->int->int):int = 
    match beg with
    | _ when beg>a ->init
    | _ when (NOD a beg) = 1 -> Divisors (a,func beg init,beg+1,func)
    | _ -> Divisors (a,init,beg+1,func)

let UberFunc (a:int,init:int,func: int->int->int):int = Divisors (a,init,1,func)

[<EntryPoint>]
let main argv =
    let a = System.Convert.ToInt32(System.Console.ReadLine())
    printfn $"{UberFunc(a,0,fun a b->a+b)}"
    printfn $"{UberFunc(a,1,fun a b->a*b)}"
    0
