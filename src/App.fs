module babylonFable

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open babylonjs
open Fable.Import.Browser
open babylonjs

let init() =
    let canvas = Browser.document.getElementById "renderCanvas" :?> Fable.Import.Browser.HTMLCanvasElement   //.getElementById("renderCanvas")
    let engine = Scene.getEngine () //Engine(canvas, true, { preserveDrawingBuffer = true; stencil = true})
    canvas.width <- 1000.
    canvas.height <- 800.
    let ctx = canvas.getContext_2d()
    // The (!^) operator checks and casts a value to an Erased Union type
    // See http://fable.io/docs/interacting.html#Erase-attribute
    ctx.fillStyle <- !^"rgb(200,0,0)"
    ctx.fillRect (10., 10., 55., 50.)
    ctx.fillStyle <- !^"rgba(0, 0, 200, 0.5)"
    ctx.fillRect (30., 30., 55., 50.)

init()