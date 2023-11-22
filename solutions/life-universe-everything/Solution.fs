module Solution

// problem: user/problem_identifier

let main (xs: string seq) : string seq = xs |> Seq.takeWhile (fun x -> x <> "42")
