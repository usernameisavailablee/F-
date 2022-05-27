open System


let rec NOD a b =
    if (a%b)=0 then b
    else NOD b (a%b)

let rec Divisors (a:int,init:int,beg:int,func: int->bool,counter:int):int = 
    match beg with
    | _ when beg>a ->init
    | _ when ((NOD a beg) = 1 )&&(func beg) ->
    printfn $"{counter}. НОД({a},{beg}) = 1 и {beg} удов. условию"
    Divisors (a,init+1,beg+1,func,counter+1)
    | _ -> Divisors (a,init,beg+1,func,counter)


let UberFunc (a:int,func: int->bool):int = Divisors (a,0,1,func,0)


let rec Divisors1 (a:int,init:int,beg:int,func: int->bool,counter:int):int = 
    match beg with
    | _ when beg>a ->init
    | _ when ((a%beg=0)&&(func beg))-> 
    printfn $"{counter}. Делитель числа {a} число {beg} удовлетворяющие условию"
    Divisors1 (a,init+1,beg+1,func,counter+1)
    | _ -> Divisors1 (a,init,beg+1,func,counter)


let UberFunc1 (a:int,func: int->bool):int = Divisors1 (a,0,1,func,0)

[<EntryPoint>]
let main argv =
    let a = System.Convert.ToInt32(System.Console.ReadLine())
    printfn ""
    printfn $"Колво делителей числа удов. условию: {UberFunc1(a,fun a->a>4)}"
    printfn ""
    printfn $"Колво взаимно простых компонент: {UberFunc (a,fun a->a>4)}"
    printfn ""
    0