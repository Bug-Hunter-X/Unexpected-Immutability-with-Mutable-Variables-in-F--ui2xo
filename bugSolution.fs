let mutable x = 1
let mutable y = 2
let z = ref (x + y) //Use a reference cell to achieve the desired mutability
printf "%d\n" !z
x <- 3
printf "%d\n" !z //Now z updates correctly