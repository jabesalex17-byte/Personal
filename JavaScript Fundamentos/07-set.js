//set
let seta= new Set()
console.log(seta)

//ponerle valores tiene que sr  con llaves

seta = new Set(["jabes" , 23 , false, "jsldkjfa;lksjdf"])
console.log(seta)

//metodos comunes

//add y delete

seta.add("hola")// lo anade al final
console.log(seta)

seta.delete(23) // indicar que quiers borrar ya sea texto o lo que sea
console.log(seta)

console.log(seta.delete(false))//tira true o flase si se borro o no

//has 
seta.has(23)
console.log(seta.has(23)) // true or false si existe o no 

//size

console.log(seta.size)// tamano maestero 

//convertir un seta  array

let array = Array.from(seta)


//se array a set

seta = new Set(array)


//la principal diferencia de un set es que no  pueden haber valores duplicados 

seta.add("hoal")
seta.add("hoal")
seta.add("hoal")
console.log(seta)