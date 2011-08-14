// Learn more about F# at http://fsharp.net

open System

let random = new Random(DateTime.Now.Millisecond)

let roll dice sides = 
    Seq.initInfinite(fun index -> random.Next(1, (sides + 1)))
    |> Seq.take(dice)
    |> Seq.sum

type Climate = 
    | Plain
    | Scrub
    | Forest
    | Rough
    | Hill
    | Mountain
    | Swamp
    | Desert
    
type Frequency = 
    | Common
    | Uncommon
    | Rare
    | VeryRare
    
type Organization = 
    | Solitary
    | Tribal
    
type Diet = 
    | Carnivore 
    | Herbivore
    | Omnivore
  
[<Measure>] type Copper

[<Measure>] type Silver

[<Measure>] type Gold

[<Measure>] type Electrum

[<Measure>] type Platinum


//type Treasure = 
        
    
type ICreature = 
    abstract member Climate : unit -> Climate
    abstract member Frequency : unit -> Frequency
    abstract member Organization : unit -> Organization
    abstract member Diet : unit -> Diet
    abstract member Intelligence : unit -> int
    
    