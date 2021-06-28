module App

open Browser.Dom

// Mutable variable to count the number of times we clicked the button
let mutable count = 0

// Get a reference to our button and cast the Element to an HTMLButtonElement
let myButton = document.querySelector(".my-button") :?> Browser.Types.HTMLButtonElement

// Register our listener
myButton.onclick <- fun _ ->
    count <- count + 1
    myButton.innerText <- sprintf "You clicked: %i time(s)" count



open Fable.Core.JsInterop

type IFoo =
    abstract member stringProp: string
let foo: IFoo = importDefault "./foo.ts"
console.log("TS imported foo.stringProp is:", foo.stringProp)


let bar: string = importDefault "./bar.ts"
console.log("TS imported bar is:", bar)