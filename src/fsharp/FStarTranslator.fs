module FStarTramslator

let toFStar fstarVals errorLogger =
 fstarVals |> Seq.iter (fun x -> printfn "%A" x)