// 1. Crea un array que almacene cinco animales
let array = new Array(5)
array = [1,2,3,4,5,6]

// 2. Añade dos más. Uno al principio y otro al final
array.push("algo")
array.unshift(23)
console.log(array)
// 3. Elimina el que se encuentra en tercera posición
array.pop(3)

// 4. Crea un set que almacene cinco libros
let seta = new Set(["nose que no se", 23,23,12,423,123,])
// 5. Añade dos más. Uno de ellos repetido
seta.add("nlsdjf")
seta.add(23)
// 6. Elimina uno concreto a tu elección
seta.delete(23)

// 7. Crea un mapa que asocie el número del mes a su nombre
let mapa = new Map([
    ["1 ", "enero"],
    ["2", "febrero"]
])
console.log(mapa)

// 8. Comprueba si el mes número 5 existe en el map e imprime su valor

console.log(mapa.has("5"))

// 9. Añade al mapa una clave con un array que almacene los meses de verano
mapa.set("meses", ["nose que ", "mesnos"])


// 10. Crea un Array, transfórmalo a un Set y almacénalo en un Map

let narray= [1,2,3,4,5,6]
let seta2 = new Set(narray)
let mapa2 = new Map()
mapa2.set("numeros", seta2)

console.log(mapa2)
