open System

exception MyException1
exception MyException2

let x =
  try 42
  with
    | MyException1 -> 1
    | MyException2 -> 2

let safeAdd (a: int) (b: int) =
  a + b // MAKE IT SAFE!

let safeSub a b = failwith "implement"
  // if abnormal then raise System.OverflowException

// let y =
  // a + b - c
  // safeSub (safeAdd a b) c

type UInt128 = uint64 * uint64

// let bidAdd a b =
  // ???
  //         uint64 |      uint64
  // HEXADECIMAL: 01 FFFFFFFF FFFFFFFF
  // HEXADECIMAL: 00 00000000 00000001
  //            + 02 00000000 00000000

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
