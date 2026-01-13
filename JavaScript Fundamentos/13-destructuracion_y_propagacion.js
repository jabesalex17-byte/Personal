
numeros = [1,2,3,4,5]
let persona = {
    nombre: "jabes",
    apodo: "el 9",
    edad: null
}

let valor = numeros[2]
console.log(valor)

let dato = persona.edad
console.log(dato)

//destructuracion 
//nos permite traer valores y nos permite pnerlo a una variable (varias varialbes)

//sintaxis arrays

let [valor1, valor2] = numeros
console.log(valor1, valor2)
// le pone los primeros valores a las variables 

//ahra con valores por defecto
//cuando no haya nada o que no se ponga nada o asi
let algo = ["asldf", "lksd", "sldfjlskf","laksjfd"]
let [noseque1 = 0 ,noseque2= "ajdsa",noseque3 = 23 ,noseque4 = null, noseque5 = 0] = algo


//ignorara elementos 
// si pones las comas y no pones nada se lo salta y ya asi vas al que quieres
let sdflsdfjs = [5,6,7,87,8,9,3,4,3,433]
let [aultimo,,,,,,penultimo] = sdflsdfjs


// sintaxis objets con {}
let persona2 = {
    nombre: "jabes",
    apodo: "el 9",
    edad: null
}
let {name, alias, age}= persona2

//lo mismo pero por defecto 

let {name2, alias2, age2}= persona2
// el detalle con esto es que esas caracteristica no existen osea no existe name2 como una propiedad

// ahoroa con nuevos nombres de bariables 
let {nombre: nombre3 , apodo: alias3, edad: age3}= persona2
console.log(nombre3)
console.log(age3)
console.log(alias3)


let persona22sd ={
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

let { nombre: namek , job: {name: namekk}} = persona22sd
console.log(namek)
console.log(namekk)


//propagacion
//sintacis arrays
let arraynose = [1,2,3,4,5,5]
let nuevo = [...arraynose] // una copia
let otro = [...arraynose, 5,32,4324,"asa"] // copiar una array u ponerle mas valores
console.log(nuevo)

//combinacion de arryas
let array23 = [...otro ,...arraynose] // los 3 puntos es para poner los datos que tiene ese array no hay mas osea ya sabes como combinar e

//sintaxis objetos 
let personanoseque = {...persona, ministro: "no me acuertdo"} // es mas para una copia y que le anadimos cosas
console.log(personanoseque)



//basicamente esto copia los ultimos valores estantes 
let algooo = [1,2,3,4,2,56,3]
let [noseque, ...noseque23] = algooo
console.log(noseque)
console.log(noseque23)
