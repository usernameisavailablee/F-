open System

let ADD n list=
    let rec ad list n=
        if n%3=0 then list
           else 
           let newn=n+1
           let newList= list@[1]
           ad newList newn
    ad list n

let rec ReadList n = 
        if n=0 then []
        else
        let Head = System.Convert.ToInt32(System.Console.ReadLine())
        let Tail = ReadList (n-1)
        Head::Tail
    
let rec WriteList = function
        [] ->   let z = System.Console.ReadKey()
                0
        | (head : int)::tail -> 
                           System.Console.WriteLine(head)
                           WriteList tail 
                         
let Sum list func=
    let rec s list func newList=
        match list with
        |[]-> newList
        |h::t-> 
            let s1=h
            let s2=t.Head
            let s3=t.Tail.Head
            let all= func s1 s2 s3
            let NewList1=newList@[all]
            s t.Tail.Tail func NewList1
    s list func []

[<EntryPoint>]


   
let main argv =
    let n=System.Convert.ToInt32(Console.ReadLine())
    let l= ReadList n
    let l2= ADD n l
    let l3= Sum l2 (fun x y z-> x + y + z)
    WriteList l3|>ignore
    0 