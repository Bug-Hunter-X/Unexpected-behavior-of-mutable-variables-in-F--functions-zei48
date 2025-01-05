let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y //This will print 20 10

//However, if we try to use swap function in a different way,
//we might not get the expected results.

let a = 10
let b = 20

let swap2 a b = 
    let temp = a
    a <- b
    b <- temp

swap2 a b
printfn "%d %d" a b //This will print 10 20