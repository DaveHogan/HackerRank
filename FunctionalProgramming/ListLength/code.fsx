open System
(*

List Length
Hacker Rank - https://www.hackerrank.com/challenges/fp-list-length

*)

let countAll input = 
     List.fold (fun acc x -> acc + 1) 0 input

(* Boiler plate stuff for HackerRank *)
[<EntryPoint>]
let main argv = 
    
    let readInputsAsInts = 
      Seq.initInfinite (fun _ -> System.Console.ReadLine())
      |> Seq.takeWhile (fun s -> s <> null)
      |> Seq.map(fun c -> int c)
      |> Seq.toList
    
    Console.Write (countAll readInputsAsInts)
    0