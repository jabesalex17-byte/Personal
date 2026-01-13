//console 


//log 
console.log("holamudno")

//error

console.error("este es un error") // vasicamente sale en error
console.error("esto es un error generico ",  new Error("conoionsdl"))

//warn

console.warn("esto es una adverdencia")// deveria ser amario lo que pasa es que el depurador esta loco

//info
console.info("este es un mensaje de infmacion adicional")


//talble
let dato = [
    ["jabes", 23],
    ["elvis", 23]
]
console.table(dato)

let data = [
    {nombre: "jabes" , edad: 22},
    {nombre: "marlene" , edad: 3}
]

console.table(data)

//group 

console.group("usauraio:") /// abrir un grupo
console.log("nombre: jabes") // dato del grupo
console.groupEnd() // cerrar


//time

console.time("tiempo de ejjecucion ")
for(let x = 0;  x < 1000000; x++){}
console.timeEnd("tiempo de ejjecucion ") // tiene que ser el mismo texoto


//assert muestra un mensaje de error si es falso

let algo = 17
console.assert(algo > 99, "no se que hiciste mals")


// count cuenta la cnatidad de veces de una cuenta especifica

console.count("click")
console.count("click")
console.count("click")
console.count("click")
console.count("click")
console.countReset("click")


// trace seguimeineto de la pila de ejecucion
function funti(){
    funti2()
}
function funti2 (){
    console.trace("seguimiento de la ejecucion")
}
funti()
// como se ha ejecutado 

// clear

//console.clear() // elimina todo