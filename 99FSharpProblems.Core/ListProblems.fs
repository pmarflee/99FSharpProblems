namespace _99FSharpProblems.Core

module ListProblems =

    let Problem1 input =
        let rec getlast remaining =
            match remaining with
            | hd :: tl when tl.IsEmpty -> hd
            | _ :: tl -> getlast tl
            | [] -> failwith "Empty list"
        getlast input