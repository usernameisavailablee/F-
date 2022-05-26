open System

let rec divisors (a:int,init:int,beg:int,func: int->int->int):int = 
    match beg with
    | _ when beg>a/2 ->init
    | _ when a%beg=0 -> divisors (a,func beg init,beg+1,func)
    | _ -> divisors (a,init,beg+1,func)


let UberFunc (a:int,init:int,func: int->int->int):int = divisors (a,init,1,func)

[<EntryPoint>]
let main argv =
    let a = System.Convert.ToInt32(System.Console.ReadLine())
    printfn $"{UberFunc(a,0,fun a b->a+b)}"
    printfn $"{UberFunc(a,1,fun a b->a*b)}"
    0