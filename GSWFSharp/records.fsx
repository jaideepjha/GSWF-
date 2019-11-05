open System

type Address =
    {
        Street: string;
        Town: string;
        City: string;
    }

type Customer =
    {
        Forename  : string;
        Surname : string;
        Age : int;
        Address : Address;
        EmailAddress : string;
    }

let customer = {Forename="Joe"; 
                Surname = "Dimagio"; 
                Age = 80; 
                Address = { Street = "12-Park Avenue"; 
                            Town = "Brooklyn"; 
                            City="NY"}
                EmailAddress = "joe.dimagio@gmail.com"}

customer.Address.Town      

type Car =
    {
        Manufacturer : string;
        EngineSize : int;
        NumberOfDoors : int;
    }

let car = {
    Manufacturer="Ferrari"; 
    EngineSize = 30; 
    NumberOfDoors = 2 
    }
let car2 : Car= {
    Manufacturer="Ferrari"; 
    EngineSize = 30; 
    NumberOfDoors = 4 
    }

let printAddress address =
    printfn "%s %s" address.City address.Street


//customer record is immutable, a copy can be created by specifying attributes that need to be changed
let customer3 =
    {
        customer with 
            EmailAddress = "joe@abc.com" 
            Age = 22
    }

let UpdateAge customer_ newAge =
    printfn "Earlier Age: %d" customer_.Age
    let updatedCustomer = 
        {
            customer_ with
                Age = newAge
        }
    printfn "New Age: %d" updatedCustomer.Age
    updatedCustomer


//Shadowing doesn't seem to work on my computer

let myHome = { Street = "The Street"; Town = "The Town"; City = "The City" }
//let myHome = { myHome with City = "The Other City" }
//let myHome = { myHome with City = "The Third City" }
