open System

let parseName(name:string) =
    let parts = name.Split(' ')
    let forename = parts.[0]
    let surname = parts.[1]
    forename, surname


let fname, sname = parseName("Jaideep Jha")


let parsescore(person : string) =
  let parts = person.Split(' ')
  let name = parts.[0]
  let game = parts.[1]
  let score = int(parts.[2])
  name, game, score

             
let a,b,c = parsescore("Mary Asteroids 230")

let nameAndAge = ("Jaideep", "Jha"), 33

let result, parsed = Int32.TryParse("234")

