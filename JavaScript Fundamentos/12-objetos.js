// objetos

//sintaxis

let person = {
    nombre: "jabes",
    age: 16,
    apodo: "mbappe",
    happy: true
}

//acceder a las propiedades 

// natacion 1 por punto
console.log(person.nombre)

// notacion 2 por corchetaes 
console.log(person["nombre"])

// modificacion 

person.age = 23
console.log(person.age)

// eliminar propiedades 
delete person.happy
console.log(person)

// anadir propiedade3s 

person.noseque = "algo.com"
console.log(person)
person["gustos"] = "futbol"

//metodos(funiones)

let persona2 ={
    nombre: "jabes",
    age: 23,
    apodo: "el 9",
    walk: function(){
        console.log("camina")
    }
}
persona2.walk()

//anidar objetos
let persona22 ={
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
            console.log("estoy trabajando")
        }
    }

}

console.log(persona22)
console.log(persona22.job.name)
console.log(persona22.job)
persona22.job.work()

// igualdad de objetos


let person5 = {
    nombre: "jabes",
    age: 16,
    apodo: "mbappe",
    happy: true
}
let person6 = {
    nombre: "jabes",
    age: 16,
    apodo: "mbappe",
    happy: true
}
// no se guardan como un valor sino como una direccion de memoria por eso no es lo mismo de la mima porma 
console.log(person5 == person6)
//ahora las propiedades si con un valor por esos si da true
console.log(person5.nombre == person6.nombre)

//iteracion
// se itre con in y  de normal te tira las claves pero para los valores no puedes poner persona.key porque se lo toma literal como que hay una propiedad key 
// lo que tienes que hacer es poner lo con persona[variable]
for (let x in person6){
    console.log(x + ":" + person6[x])
}



// para hacer referecia a las propidades ponemos el this
// siempre  hace referencia al objeto en el cual se encuentra
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
persona22sd.job.work()

// fuciones como objetos

function person444(name, age){ // deveria ser una clase no es muy recomendada
    this.name = name
    this.age = age
}

let personasaaa = new person444("jabes",12)
console.log(personasaaa)