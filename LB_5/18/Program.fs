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

[<EntryPoint>]
let main argv =
    let a=System.Convert.ToInt32(System.Console.ReadLine())
    System.Console.WriteLine("Максимальный простой делитель числа:{0}",maxdiv a )

    
    0 