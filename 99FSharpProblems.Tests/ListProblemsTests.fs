namespace _99FSharpProblems.Tests

open Xunit
open Xunit.Extensions
open FsUnit.Xunit
open _99FSharpProblems.Core

module ListProblemsTests =

    module Problem1Tests =

        [<Fact>]
        let ``Last element of list containing elements 1,2,3,4 should be 4``() =
            ListProblems.Problem1 [1..4] |> should equal 4

        [<Fact>]
        let ``Last element of list containing elements x,y,z should be z``() =
            ListProblems.Problem1 ['x'..'z'] |> should equal 'z'

    module Problem2Tests =

        [<Fact>]
        let ``Last but 1 element of list containing elements 1,2,3,4 should be 3``() =
            ListProblems.Problem2 [1..4] |> should equal 3

        [<Fact>]
        let ``Last but 1 element of list containing elements x,y,z should be y``() =
            ListProblems.Problem2 ['x'..'z'] |> should equal 'y'

    module Problem3Tests =

        [<Fact>]
        let ``Second element of list containing elements 1,2,3 should be 2``() =
            ListProblems.Problem3 [1..3] 2 |> should equal 2

        [<Fact>]
        let ``Fifth element of 'Haskell' should be e``() =
            ListProblems.Problem3 (List.ofSeq "Haskell") 5 |> should equal 'e'

    module Problem4Tests =

        [<Fact>]
        let ``Number of elements in list 123,456,789 should be 3``() =
            ListProblems.Problem4 [123;456;789] |> should equal 3

        [<Fact>]
        let ``Number of characters in 'Hello, world!' should be 13``() =
            ListProblems.Problem4 <| List.ofSeq "Hello, world!" |> should equal 13

    module Problem5Tests =

        [<Fact>]
        let ``Reverse of 'A man, a plan, a canal, panama!' should be 3``() =
            ListProblems.Problem5 <| List.ofSeq "A man, a plan, a canal, panama!" |> should equal <| List.ofSeq "!amanap ,lanac a ,nalp a ,nam A"

        [<Fact>]
        let ``Reverse of list 1,2,3,4 should be 4,3,2,1``() =
            ListProblems.Problem5 <| [1..4] |> should equal [4..-1..1]

    module Problem6Tests =

        [<Fact>]
        let ``List 1,2,3 is not a palindrome``() =
            ListProblems.Problem6 [1..3] |> should be False

        [<Fact>]
        let ``'madamimadam' is a palindrome``() =
            ListProblems.Problem6 <| List.ofSeq "madamimadam" |> should be True

        [<Fact>]
        let ``List 1,2,4,8,16,8,4,2,1 is a palindrome``() =
            ListProblems.Problem6 [1;2;4;8;16;8;4;2;1] |> should be True

    module Problem8Tests = 

        [<Fact>]
        let ``Compress list (a a a a b c c a a d e e e e) should return (a b c a d e)``() =
            ListProblems.Problem8 ['a'; 'a'; 'a'; 'a'; 'b'; 'c'; 'c'; 'a'; 'a'; 'd'; 'e'; 'e'; 'e'; 'e'] 
            |> should equal ['a'; 'b'; 'c'; 'a'; 'd'; 'e']

    module Problem9Tests = 

        [<Fact>]
        let ``{Pack list (a a a a b c c a a d e e e e) should return ((a a a a) (b) (c c) (a a) (d) (e e e e))``() =
            ListProblems.Problem9 ['a'; 'a'; 'a'; 'a'; 'b'; 'c'; 'c'; 'a'; 'a'; 'd'; 'e'; 'e'; 'e'; 'e'] 
            |> should equal [['a'; 'a'; 'a'; 'a']; ['b']; ['c'; 'c']; ['a'; 'a']; ['d']; ['e'; 'e'; 'e'; 'e']] 