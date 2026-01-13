// 1. Crea un bucle que imprima los números del 1 al 20

for ( let i = 0 ; i <= 20; i++){
    console.log(i)
}

// 2. Crea un bucle que sume todos los números del 1 al 100 y muestre el resultado
let suma = 0

for (let x = 0; x <= 100; x++){
    suma += x
}
console.log(suma)

// 3. Crea un bucle que imprima todos los números pares entre 1 y 50
for (let y = 0 ; y <= 50 ; y += 2){
    console.log(y)
}
// 4. Dado un array de nombres, usa un bucle para imprimir cada nombre en la consola
let nombre = ["jabes", "pedro", "nose que "]
for (let n of nombre){
    console.log(n)
}
// 5. Escribe un bucle que cuente el número de vocales en una cadena de texto

let cadena = "aweoirucnmx,vla;lsdf=wefosidjfsldf"
let contador = 0
for ( let l of cadena.toLocaleLowerCase()){
    if (l == "a" || l == "e"|| l == "i" || l == "o" || l == "u" ){
        contador += 1
    }
}
console.log(contador)

// 6. Dado un array de números, usa un bucle para multiplicar todos los números y mostrar el producto
let numeross = [1,2,3,4,5,6,7]
let multiplicaicon = 1

for (let s of numeross){
    multiplicaicon *= s
}
console.log(multiplicaicon)

// 7. Escribe un bucle que imprima la tabla de multiplicar del 5
// muy easy
// 8. Usa un bucle para invertir una cadena de texto
let scadena = "holaasdsdas"
let sdsfsdfna = ""

for (let y = 0; y < scadena.length;y++){
    sdsfsdfna += scadena[scadena.length - 1 - y]
}
console.log(sdsfsdfna)
// 9. Usa un bucle para generar los primeros 10 números de la secuencia de Fibonacci
//no

// 10. Dado un array de números, usa un bucle para crear un nuevo array que contenga solo los números mayores a 10
let afas = [1,2,43,24,5,62]
let asdf= []
for (let c of afas){
    if (c > 10 ){
        asdf.push(c)
    }
}

console.log(asdf)