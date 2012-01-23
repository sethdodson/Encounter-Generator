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

type GemTreaure = 
    | Ornamental
    | SemiPrecious
    | Fancy
    | Precious
    | Gems
    | Jewels
    member gt.BaseValue = 
        match gt with
        | Ornamental -> 10<Gold>
        | SemiPrecious -> 50<Gold>
        | Fancy -> 100<Gold>
        | Precious -> 500<Gold>
        | Gems -> 1000<Gold>
        | Jewels -> 5000<Gold>                    

type TreasureType = 
    | A
    | B
    | C
    | D
    | E
    | F
    | G
    | H
    | I
    | J
    | K
    | L
    | M
    | N
    | O
    | P
    | Q
    | R
    | S
    | T
    | U
    | V
    | W
    | X
    | Y
    | Z
                
type ICreature = 
    abstract member Climate : unit -> Climate
    abstract member Frequency : unit -> Frequency
    abstract member Organization : unit -> Organization
    abstract member Diet : unit -> Diet
    abstract member Intelligence : unit -> int
    
    