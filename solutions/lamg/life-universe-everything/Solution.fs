module Solution

let main (xs: string seq) : string seq = xs |> Seq.takeWhile (fun x -> x <> "42")