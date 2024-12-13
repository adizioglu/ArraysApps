// 0-based counting - 0,1,2,3,4
// 1-based counting - 1,2,3,4,5

//let firstNames = Array.create 5 ""

//firstNames.[0] <- "Tim"
//firstNames.[1] <- "Sue"
//firstNames.[2] <- "Bob"
//firstNames.[4] <- "Jane"

//printfn "The firstNames are %s, %s, %s, %s" firstNames.[0] firstNames.[1] firstNames.[2] firstNames.[4]

//firstNames.[0] <- "Timothy"

//printfn "%s" firstNames.[0]

//firstNames.[5] <- "Robert"

// single quote identifies a char
// double quotes identifies a string
let data = "Tim,Sue,Bob,Jane,Frank"
let firstNames = data.Split(',')

printfn "%s" firstNames.[firstNames.Length - 1]

printfn "%d" firstNames.Length

let lastNames = [| "Corey"; "Smith"; "Jones" |]

let ages = [| 2; 3; 4 |]

