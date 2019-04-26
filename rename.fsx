open System.IO
open System.Text.RegularExpressions

//__SOURCE_DIRECTORY__ is a keyword that represents the working directory in the commandline for F#
let sourceDirectory = __SOURCE_DIRECTORY__

let fileNames = Directory.GetFiles sourceDirectory

printf "%s" sourceDirectory

//fsi.CommandLineArgs is the list of command line arguments
// [file.fsx; arg1; arg2]
let args : string array = fsi.CommandLineArgs |> Array.tail
// the regex pattern to be replaced
let pattern :string = args.[0]
printf "%s" pattern
//the text we want it to be replaced to
let replacement :string = args.[1]
printf "%s" replacement
//the array of files to be renamed
let filesToBeRenamed = 
  fileNames 
  |> Array.filter (fun s -> s.Contains pattern)

//the array of files with the name we would like them to have
let renamedFiles = 
  filesToBeRenamed     
  |> Array.map (fun t -> Regex.Replace (t, pattern, replacement))

//zip together and rename

Array.zip filesToBeRenamed renamedFiles
|> Array.iter (fun (s,t) -> File.Move (s,t))
|> ignore

0