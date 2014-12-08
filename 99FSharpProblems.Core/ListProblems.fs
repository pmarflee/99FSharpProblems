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

    let Problem3 input i =
        let rec getNth remaining j =
            match remaining with
            | hd :: tl when i = j -> hd
            | hd :: tl -> getNth tl (j + 1)
            | [] -> failwith "Empty list"
        getNth input 1

    let Problem4 input =
        let rec count remaining i =
            match remaining with
            | hd :: tl -> count tl (i + 1)
            | [] -> i
        count input 0

    let Problem5 input =
        let rec rev state remaining =
            match remaining with
            | [] -> state
            | hd :: tl -> rev (hd :: state) tl
        rev [] input