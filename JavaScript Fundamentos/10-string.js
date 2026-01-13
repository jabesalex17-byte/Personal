// 1. Concatena dos cadenas de texto

let hola1 = "men sajesfs fs"
hola1 += "hola"
console.log(hola1)

// 2. Muestra la longitud de una cadena de texto

console.log(hola1.length)

// 3. Muestra el primer y último carácter de un string

console.log(hola1[15])

// 4. Convierte a mayúsculas y minúsculas un string
console.log(hola1.toUpperCase())
console.log(hola1.toLowerCase())
// 5. Crea una cadena de texto en varias líneas
let nose = `lsajf;
alsjfslkjja`
// 6. Interpola el valor de una variable en un string
let  numero = 2342

console.log(`estosdf es uan ${numero} no se que `)
// 7. Reemplaza todos los espacios en blanco de un string por guiones
console.log(hola1.replaceAll(" ", "-"))
// 8. Comprueba si una cadena de texto contiene una palabra concreta
console.log(hola1.includes("men"))

// 9. Comprueba si dos strings son iguales

console.log( nose == hola1)

// 10. Comprueba si dos strings tienen la misma longitud
console.log(nose.length == hola1.length)