//arrays

let forma1 =[] // esta forma es mejor es lo mismo per es mejor 
let forma2 =new Array()

console.log(forma1)

forma1 = [1, "hola"]
console.log(forma1)

forma2 = new Array(5) // basicamente como c++ dice que hay un array con 5 espacios
console.log(forma2)

forma2 = new Array(5, "fghjkl")
console.log(forma2)

//establecer calores

forma1[2] = "jalsjfd"
console.log(forma1)

// push y pop para poner y quitar valores
let otroarray = []
otroarray.push("nose que") // para anadir un valor ultimo
otroarray.push(32)
otroarray.pop() // por defecto elemina el ultimo valor del array y lo devuelve
otroarray.push("jsd", 234)
console.log(otroarray.pop())
console.log(otroarray)
console.log(otroarray.pop(1))// en elimina la pocicion especifica 
console.log(otroarray)


// shift y unshift
console.log(otroarray.shift()) // elimina el primer elimento
console.log(otroarray.unshift("slkjfs,", 23))// añade desde el principio
console.log(otroarray)

// length
console.log(otroarray.length)// nos dice cuantos elementos tiene el array

//crear 
//otroarray = [] // por si lo quieres borra no existe un .clear()
//o  otroarray.length = 0  tambien es otra forma

// slice

let myArray = ["Brais", "Moure", "mouredev", 37, true]

let myNewArray = myArray.slice(1, 3)// va desde un indice hasta otro  sin tener el cuenta el ultimo  1 ,2 solo tima el elemento 1 no el 2

console.log(myArray)
console.log(myNewArray)

//splice


myArray.splice(1, 2)// esto lo que dice es empieza en el elemento 1 y borra 2
myArray.splice(2, 3, "algo")// lo que hace es lo mismo pero que donde estaban esos elementos poene ese algo
