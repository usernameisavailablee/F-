open System

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

[<EntryPoint>]
let main argv =
    let a=System.Convert.ToInt32(System.Console.ReadLine())
    System.Console.WriteLine("Максимальный простой делитель числа:{0}",maxdiv a )
    System.Console.WriteLine("Произведение цифр числа, не кратных 5:{0}",comp a)
    
    0 