// 1. Crea un objeto con 3 propiedades
let persona ={
    nombre: "jabes",
    edad: 23,
    noseque: "algo"
}
// 2. Accede y muestra su valor
console.log(persona.edad)
// 3. Agrega una nueva propiedad
persona.algo = "nose que "
console.log(persona)
// 4. Elimina una de las 3 primeras propiedades
delete persona.noseque
// 5. Agrega una función e invócala
persona.cantar = function(){
    console.log("estoy cantando")
}

persona.cantar()

// 6. Itera las propiedades del objeto
for (let x in persona){
    console.log(`${x} : ${persona[x]}`)
}

// 7. Crea un objeto anidado

let persona2 = {
    nombre: "elvis",
    edad: 23,
    trabajo: {
        nombre: "fiver",
        expereicia: "2 anos"
    }
}

// 8. Accede y muestra el valor de las propiedades anidadas
console.log(persona2.trabajo.nombre)
// 9. Comprueba si los dos objetos creados son iguales
console.log(persona == persona2)
// 10. Comprueba si dos propiedades diferentes son iguales
console.log(persona.edad == persona2.age)