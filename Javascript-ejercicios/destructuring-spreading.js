// 1. Usa desestructuración para extraer los dos primeros elementos de un array 
let array = [6,2,5,4,5,6,7]
let [valor1,valor2] = array

// 2. Usa desestructuración en un array y asigna un valor predeterminado a una variable
let [valor3 = 1, valor4 = 2, valor5 = "alf"] = array
console.log(valor3)
console.log(valor1)

// 3. Usa desestructuración para extraer dos propiedades de un objeto
let persona ={
    nombre: "jabes",
    age: 23,
    apodo: "el 9",
    walk: function(){
        console.log("camina")
    },
    
    job: {
        name: "programador ",
        experiencia: "nada",
        work: function(){
            console.log(`estoy trabajando con ${this.experiencia}`)
        }
    }

}
let {nombre: name, age: edad} = persona
console.log(name)
console.log(edad)


// 4. Usa desestructuración para extraer dos propiedades de un objeto y asígnalas
//    a nuevas variables con nombres diferentes
let {nombre: name2, age: edad2} = persona
// 5. Usa desestructuración para extraer dos propiedades de un objeto anidado
let {job: {name: nombre323}} = persona
console.log(nombre323)

// 6. Usa propagación para combinar dos arrays en uno nuevo1
let array1 = ["asldfja", 'a", "asldkfjaslkfdj"']
let nuevo = [...array, ...array1]

// 7. Usa propagación para crear una copia de un array
let otromas = [...nuevo]
// 8. Usa propagación para combinar dos objetos en uno nuevo
let persona2 = {
    posicion: "MC0",
    ritmo: 89,
    tiro: 99,
    pase: 99
}
let jugador = {...persona, ...persona2}
console.log(jugador)
// 9. Usa propagación para crear una copia de un objeto

let newjugaro = {...jugador}

// 10. Combina desestructuración y propagación
let algooo = [1,2,3,4,2,56,3]
let [noseque, ...noseque2] = algooo
console.log(noseque)
console.log(noseque2)

//basicamente esto copia los ultimos valores estantes 