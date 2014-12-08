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
