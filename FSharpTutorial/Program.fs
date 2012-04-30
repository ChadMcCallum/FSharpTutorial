open System

//defining a function
let square x = x * x

//calling a function
let result = square 3

let sum x y = x + y
//using system commands inline
Console.WriteLine("Sum of 3 and 4 is: " + (sum 3 4).ToString())

Console.WriteLine("Square of 3 is: " + (result).ToString())

//try to add strings
//let stringResult = sum "Hello " "There"
//doesn't work because argument type has already been determined
//would work if used before sum 3 4

let product x y = x * y
//"function type"
//int -> int -> int

let timesFive = product 5
//currying - declaring half the function
//int -> (int -> int)

Console.WriteLine(timesFive 4)

//function as an argument
let modifyFive fn = fn 5
//passing function as an argument
let result2 = modifyFive square

Console.WriteLine(result2)
//anonymous function
let funResult = modifyFive (fun x -> x + x)

Console.WriteLine(funResult)
//recursive function, adds all the numbers that are divisible by 3 and 5
let rec multipleSum limit x = 
    if x > limit then 0
    else if x % 3 = 0 && x % 5 = 0 then x + (multipleSum limit (x+1))
    else multipleSum limit (x+1)
    
//same thing, using matching
let rec multipleSumMatch limit = function
    | x when x > limit -> 0
    | x when x % 3 = 0 && x % 5 = 0 -> x + (multipleSum limit (x+1))
    | x -> multipleSum limit (x+1)

let result3 = multipleSum 1000 1

Console.WriteLine(result3)

let result4 = multipleSumMatch 2000 2

Console.WriteLine(result4)

Console.ReadLine() |> ignore