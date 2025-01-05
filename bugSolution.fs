let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y //This will print 20 10

//The correct way to swap variables using reference cells
let a = ref 10
let b = ref 20

let swapRef a b = 
    let temp = !a
    a := !b
    b := temp

swapRef a b
printfn "%d %d" !a !b //This will print 20 10 