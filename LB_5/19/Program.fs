﻿open System

let Issimle a=
    let rec simle a div=
      if div=0 then false
         else 
         if div=1 then true else
            if a%div=0 then false
             else
             let newdiv=div-1
             simle a newdiv
    simle a (a-1)

let maxdiv a  =
    let rec max a init div=
        if div<=0 then init
        else
           let newInit= 
            if Issimle div && a%div=0 && div>init then div
            else init
           let newdiv=div-1
           max a newInit newdiv
    max a 0 a

let comp a =
    let rec c a init =
        if a=0 then init else
           let newInit = if (a%10)%5<>0 then init*(a%10) else init
           let newCand=a/10
           c newCand newInit 
    c a 1

let rec NOD a b =
    if a%b=0 then b
    else NOD b (a%b)

let composition a =
    let rec compos a init=
        if a=0 then init else
           let newinit=init*(a%10)
           let newa=a/10
           compos newa newinit
    compos a 1

let max a =
    let rec max1 a init cand=
        if cand=0 then init else
           let newInit=if a%cand=0 && cand%2=1 && not(Issimle a) && cand>init then cand else init
           let newCand=cand-1
           max1 a newInit newCand
    max1 a 1 a
[<EntryPoint>]
let main argv =
    let a=System.Convert.ToInt32(System.Console.ReadLine())
    System.Console.WriteLine("Максимальный простой делитель числа:{0}",maxdiv a )
    System.Console.WriteLine("Произведение цифр числа, не кратных 5:{0}",comp a)
    System.Console.WriteLine("(1)Произведение цифр числа:{0}",composition a )
    System.Console.WriteLine("(2)Максимальный нечетный простой делитель:{0}",max a )
    System.Console.WriteLine("НОД (1) и (2):{0}",NOD (composition a) (max a) )
    0 // return an integer exit code
