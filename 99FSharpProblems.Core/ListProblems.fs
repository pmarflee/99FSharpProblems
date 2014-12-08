namespace _99FSharpProblems.Core

module ListProblems =

    let Problem1 input =
        let rec getlast remaining =
            match remaining with
            | hd :: [] -> hd
            | _ :: tl -> getlast tl
            | [] -> failwith "Empty list"
        getlast input

    let Problem2 input =
        let rec getlastbut1 remaining =
            match remaining with
            | hd :: last :: [] -> hd
            | _ :: tl -> getlastbut1 tl
            | [] -> failwith "Empty list"
        getlastbut1 input