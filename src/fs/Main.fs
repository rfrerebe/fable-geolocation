module App.Main

open FSharp.Core
open Fable.Core
open Fable.Core.JsInterop

open Fable.Import
open Fable.Import.Browser
open Fable.PowerPack
open Fable.PowerPack.Result

let toFunc<'I, 'T> f =
    System.Func<'I,'T>(f)

let getPosition (pos : Position) = 
    console.log("Latitude " + pos.coords.latitude.ToString() + ". Longitude " +  pos.coords.longitude.ToString())

let getPosition2 : PositionCallback =
    getPosition
    |> toFunc<Position,unit>

let getPosition3 : PositionCallback =
    getPosition
  

