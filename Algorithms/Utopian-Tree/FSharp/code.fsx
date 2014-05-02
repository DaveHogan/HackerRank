let growTree (input:int[]) =
    let numTestcases = input.[0]
       
    for i = 1 to numTestcases do
        let cycle = input.[i]
        let mutable treeSize = 1
        for c = 1 to cycle do
            if (c % 2 = 0) then
                treeSize <- treeSize + 1 // Add 1 - Summer 
            else
                treeSize <- treeSize + treeSize // Double - Monsoon Season
            
        printfn "%A" treeSize;

(* Tests 
growTree("2\n0\n1")
growTree("2\n3\n4") *)

(* Boiler plate stuff for HackerRank *)
[<EntryPoint>]
let main argv = 

    let readInputsAsInts = 
      Seq.initInfinite (fun _ -> System.Console.ReadLine())
      |> Seq.takeWhile (fun s -> s <> null)
      |> Seq.map(fun c -> int c)
      |> Seq.toArray

    growTree readInputsAsInts
    0
     