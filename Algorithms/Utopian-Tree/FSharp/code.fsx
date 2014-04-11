let growTree (input:string) =
    let args = input.Split([|'\n'|]) |> Array.map (fun c -> int c)
    let testcases = args |> Seq.head
        
    for i = 1 to testcases do
        let cycle = args.[i]
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
    let mutable input = []
    
    let mutable loop = true
    while loop do
        let line = System.Console.ReadLine()
        if System.String.IsNullOrEmpty(line) then
            loop <- false

        Array.append
    printfn "%s" input
    growTree input
    0
     