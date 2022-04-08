open System

    //поиск минимального
let minf a =
    let rec min a f=
        if (a=0) then f
        elif f > (a%10) then min (a/10) (a%10)
        else min (a/10) f
    min a a%10

    //поиск максимального
let maxf a =
    let rec max a f=
        if (a=0) then f
        elif f < (a%10) then max (a/10) (a%10)
        else max (a/10) f
    max a 0

    //хвостовая
let comp a =
    let rec f a c=
        if a=0 then c
        else  f (a/10) (c*(a%10))
    f a 1

    //вверх
let rec comp1 a =
    if a=0 then 1
    else (a%10)*(comp1(a/10))
    



[<EntryPoint>]
let main argv =
    (Console.ReadLine>>Convert.ToInt32>>minf>>Console.WriteLine)()
    (Console.ReadLine>>Convert.ToInt32>>maxf>>Console.WriteLine)()
    (Console.ReadLine>>Convert.ToInt32>>comp>>Console.WriteLine)()
    (Console.ReadLine>>Convert.ToInt32>>comp1>>Console.WriteLine)()
    0 
